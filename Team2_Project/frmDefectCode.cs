using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;
using System.Linq;

namespace Team2_Project
{
    public partial class frmDefectCode : frmListUpAreaDown
    {
        DefCodeService srv = new DefCodeService();
        List<DefCodeDTO> defList;
        
        public frmDefectCode()
        {
            InitializeComponent();
        }

        private void frmDefectCode_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvMa);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류코드", "Def_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "불량현상 대분류명", "Def_Ma_Name", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMa, "사용유무", "Use_YN");

            CommonCodeUtil.UseYNComboBinding(cboUseSC);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboUseSC.SelectedIndex = 0;

            LoadData();
            SetInitPnl();

        }

        private void LoadData()
        {
            defList = srv.GetDefCode(true);
            if (defList != null)
            {
                AdvancedListBind(defList, dgvMa);
            }

            dgvMa.ClearSelection();
        }

        private void AdvancedListBind(List<DefCodeDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<DefCodeDTO>(datasource), null);

            dgv.DataSource = null;
            dgv.DataSource = bs;
        }

        private void SetInitPnl()
        {
            txtCode.Text = txtName.Text = "";
            cboUseYN.SelectedIndex = -1;

            txtName.Enabled = txtCode.Enabled = cboUseYN.Enabled = false;
        }


        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            string defName = txtNameSC.Text;
            string defCode = txtCodeSC.Text;
            string useYN = (cboUseSC.SelectedItem.ToString() == "전체") ? "" : cboUseSC.SelectedItem.ToString();

            var list = (from c in defList
                        where c.Def_Ma_Code.Contains(defCode) && c.Def_Ma_Name.Contains(defName) && c.Use_YN.Contains(useYN)
                        select c).ToList();

            AdvancedListBind(list, dgvMa);
        }

        public void OnAdd()     //추가
        {
            SetInitPnl();

            dgvMa.Enabled = false;
            txtName.Enabled = txtCode.Enabled = cboUseYN.Enabled = true;            
            cboUseYN.SelectedIndex = 0;
        }

        public void OnEdit()    //수정
        {
            if (dgvMa.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                return;
            }

            txtName.Enabled = cboUseYN.Enabled = true;
            dgvMa.Enabled = false;
        }

        public void OnDelete()  //삭제
        {
            if (dgvMa.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주십시오.");
                return;
            }

            dgvMa.Enabled = false;

            if (MessageBox.Show($"{txtName.Text}를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeleteDefCode(true, txtCode.Text);

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

            dgvMa.Enabled = true;            
        }

        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("필수항목을 입력해주세요.");
                return;
            }

            if (txtCode.Enabled) //신규 저장
            {
                bool result = srv.CheckPK(true, txtCode.Text);
                if (!result)
                {
                    MessageBox.Show("불량현상 대분류코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    return;
                }

                DefCodeDTO code = new DefCodeDTO
                {
                    Def_Ma_Code = txtCode.Text,
                    Def_Ma_Name = txtName.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                result = srv.InsertDefCode(true, code);
                if(result)
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
                DefCodeDTO code = new DefCodeDTO
                {
                    Def_Ma_Code = txtCode.Text,
                    Def_Ma_Name = txtName.Text,
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Up_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                };

                bool result = srv.UpdateDefCode(true, code);
                if (result)
                {
                    MessageBox.Show("수정이 완료되었습니다.");                    
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }

            dgvMa.Enabled = true;
            OnReLoad();

        }

        public void OnCancel()  //취소
        {
            SetInitPnl();

            dgvMa.Enabled = true;
            dgvMa.ClearSelection();
        }

        public void OnReLoad()  //새로고침
        {
            txtCodeSC.Text = txtNameSC.Text = "";
            cboUseSC.SelectedIndex = 0;
            
            SetInitPnl();
            LoadData();
        }
        #endregion

        private void dgvMa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            txtCode.Text = dgvMa["Def_Ma_Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvMa["Def_Ma_Name", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvMa["Use_YN", e.RowIndex].Value.ToString();
        }
    }
}
