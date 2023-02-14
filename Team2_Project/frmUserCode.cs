using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmUserCode : frmCodeControlBase
    {
        UserCodeService srv = new UserCodeService();
        List<UserCodeDTO> codeList;

        public frmUserCode()
        {
            InitializeComponent();
        }

        private void frmUserCode_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMa);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용자정의 대분류코드", "Userdefine_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용자정의 대분류명", "Userdefine_Ma_Name", 250);

            DataGridViewUtil.SetInitDataGridView(dgvMi);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용자정의 상세분류코드", "Userdefine_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용자정의 상세분류명", "Userdefine_Mi_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "정렬순서", "Sort_Index");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "사용유무", "Use_YN");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Remark", "Remark", visible:false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Userdefine_Ma_Code", "Userdefine_Ma_Code", visible:false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMi, "Userdefine_Ma_Name", "Userdefine_Ma_Name", visible: false);

            CommonCodeUtil.UseYNComboBinding(cboSearchUse);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboSearchUse.SelectedIndex = 0;

            SetInitPnl();
            LoadData();
        }

        private void LoadData()
        {
            codeList = srv.GetUserCode();
            if (codeList != null && codeList.Count > 0)
            {
                var list = codeList.GroupBy((g) => g.Userdefine_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
                AdvancedListBind(list, dgvMa);
            }
            dgvMi.DataSource = null;

            dgvMa.ClearSelection();
            dgvMi.ClearSelection();
        }

        private void AdvancedListBind(List<UserCodeDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<UserCodeDTO>(datasource), null);

            dgv.DataSource = null;
            dgv.DataSource = bs;
        }


        private void SetInitPnl()
        {
            foreach(Control ctrl in splitContainer2.Panel2.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;                
            }

            ucMaCode._Code = "";
            ucMaCode._Name = "";
            nudSort.Value = 0;
            cboUseYN.SelectedIndex = -1;
        }


        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string code = ucMaCodeSC._Code;
            string useYN = (cboSearchUse.SelectedItem.ToString() == "전체")? "" : cboSearchUse.SelectedItem.ToString();
           
            var list = (from c in codeList
                        where c.Userdefine_Ma_Code == (string.IsNullOrWhiteSpace(code)? c.Userdefine_Ma_Code : code) && c.Use_YN.Contains(useYN)
                        select c).ToList();

            if (string.IsNullOrWhiteSpace(code))
                dgvMi.DataSource = null;
            else
                AdvancedListBind(list, dgvMi);
                
            var maList = list.GroupBy((g) => g.Userdefine_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
            AdvancedListBind(maList, dgvMa);

            SetInitPnl();
        }

        public void OnAdd()     //추가
        {
            if (dgvMa.SelectedRows.Count < 1)
            {
                MessageBox.Show("추가할 항목을 선택하여 주십시오.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            SetInitPnl();

            dgvMa.Enabled = dgvMi.Enabled = false;
            dgvMi.ClearSelection();
            txtInfoCodeMi.Enabled = txtInfoNameMi.Enabled = txtRemark.Enabled = cboUseYN.Enabled = nudSort.Enabled = true;
            cboUseYN.SelectedIndex = 0;

            int idx = dgvMa.CurrentRow.Index;
            ucMaCode._Code = dgvMa["Userdefine_Ma_Code", idx].Value.ToString();
            ucMaCode._Name = dgvMa["Userdefine_Ma_Name", idx].Value.ToString();

        }

        public void OnEdit()    //수정
        {
            if (dgvMi.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            dgvMa.Enabled = dgvMi.Enabled = false;
            txtInfoNameMi.Enabled = txtRemark.Enabled = cboUseYN.Enabled = nudSort.Enabled = true;
        }

        public void OnDelete()  //삭제
        {
            if (dgvMi.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주십시오.");
                return;
            }

            dgvMa.Enabled = dgvMi.Enabled = false;

            if (MessageBox.Show($"{txtInfoNameMi.Text}를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeleteUserCode(ucMaCode._Code, txtInfoCodeMi.Text);

                if (result == 0) //성공
                {
                    MessageBox.Show("삭제가 완료되었습니다.");
                }
                else if (result == 3726) //FK 충돌
                {
                    MessageBox.Show("데이터를 삭제할 수 없습니다.");
                }
                else
                {
                    MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }

                OnReLoad();
            }

            dgvMa.Enabled = dgvMi.Enabled = true;
        }

        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtInfoCodeMi.Text) || string.IsNullOrWhiteSpace(txtInfoNameMi.Text))
            {
                MessageBox.Show("필수항목을 입력해주세요.");
                return;
            }

            if (txtInfoCodeMi.Enabled) //신규 저장
            {
                bool result = srv.CheckPK(ucMaCode._Code, txtInfoCodeMi.Text);
                if (!result)
                {
                    MessageBox.Show("상세코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    return;
                }

                UserCodeDTO code = new UserCodeDTO
                {
                    Userdefine_Ma_Code = ucMaCode._Code,
                    Userdefine_Mi_Code = txtInfoCodeMi.Text,
                    Userdefine_Mi_Name = txtInfoNameMi.Text,
                    Sort_Index = (int)nudSort.Value,
                    Remark = txtRemark.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                result = srv.InsertUserCode(code);
                if (result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");              
                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }

            }
            else //수정 저장
            {
                UserCodeDTO code = new UserCodeDTO
                {
                    Userdefine_Ma_Code = ucMaCode._Code,
                    Userdefine_Mi_Code = txtInfoCodeMi.Text,
                    Userdefine_Mi_Name = txtInfoNameMi.Text,
                    Sort_Index = (int)nudSort.Value,
                    Remark = txtRemark.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Up_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                bool result = srv.UpdateUserCode(code);
                if (result)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }

            dgvMa.Enabled = dgvMi.Enabled = true;
            OnReLoad();
        }

        public void OnCancel()  //취소
        {            
            SetInitPnl();

            dgvMa.Enabled = dgvMi.Enabled = true;
            dgvMi.ClearSelection();
        }

        public void OnReLoad()  //새로고침
        {
            ucMaCodeSC._Code = ucMaCodeSC._Name = "";
            cboSearchUse.SelectedIndex = 0;
            
            SetInitPnl();
            LoadData();
        }
        #endregion

        private void ucSearchCode_BtnClick(object sender, EventArgs e)
        {
            var list = codeList.GroupBy((g) => g.Userdefine_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("대분류코드", "Userdefine_Ma_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("대분류명", "Userdefine_Ma_Name", 200));

            CommonPop<UserCodeDTO> popInfo = new CommonPop<UserCodeDTO>();
            popInfo.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "대분류코드 검색";

            ucMaCodeSC.OpenPop(popInfo);
        }

        private void dgvMa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string useYN = (cboSearchUse.SelectedItem.ToString() == "전체") ? "" : cboSearchUse.SelectedItem.ToString();
            string code = dgvMa["Userdefine_Ma_Code", e.RowIndex].Value.ToString();

            var list = (from c in codeList
                        where c.Userdefine_Ma_Code == code && c.Use_YN.Contains(useYN)
                        select c).ToList();

            if (list.Count > 0 && list.FindIndex((c) => c.Use_YN == "") == -1)
                AdvancedListBind(list, dgvMi);                           
            else
                dgvMi.DataSource = null;
   
            dgvMi.ClearSelection();
        }

        private void dgvMi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            ucMaCode._Code = dgvMi["Userdefine_Ma_Code", e.RowIndex].Value.ToString();
            ucMaCode._Name = dgvMi["Userdefine_Ma_Name", e.RowIndex].Value.ToString();
            txtInfoCodeMi.Text = dgvMi["Userdefine_Mi_Code", e.RowIndex].Value.ToString();
            txtInfoNameMi.Text = dgvMi["Userdefine_Mi_Name", e.RowIndex].Value.ToString();
            nudSort.Value = Convert.ToInt32(dgvMi["Sort_Index", e.RowIndex].Value);
            txtRemark.Text = dgvMi["Remark", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvMi["Use_YN", e.RowIndex].Value.ToString();
        }


    }
}
