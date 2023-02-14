using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;
using System.Linq;
using System.Diagnostics;

namespace Team2_Project
{
    public partial class frmNopMiCode : frmCodeControlBase
    {
        NopCodeService srv = new NopCodeService();
        //List<NopMaCodeDTO> NopMaList = new List<NopMaCodeDTO>();
        List<NopMiCodeDTO> NopMiList = new List<NopMiCodeDTO>();
        string situation = "";

        public frmNopMiCode()
        {
            InitializeComponent();
        }

        private void frmNopMiCode_Load(object sender, EventArgs e)
        {
            LoadData();     //로드            
            OnSearch();     //조회
        }

        private void LoadData()
        {
            DataGridViewUtil.SetInitDataGridView(dgvMaData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaData, "비가동 대분류코드", "Nop_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaData, "비가동 대분류명", "Nop_Ma_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaData, "사용유무", "Use_YN");

            DataGridViewUtil.SetInitDataGridView(dgvMiData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 상세분류코드", "Nop_Mi_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 상세분류명", "Nop_Mi_Name", 200);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 구분", "Regular_Type", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "비가동 유형", "Nop_type", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMiData, "사용유무", "Use_YN", 100);
            dgvMaData.MultiSelect = false;
            dgvMiData.MultiSelect = false;

            cboNoptype.Items.Add("-선택-");
            cboNoptype.Items.Add("시유");
            cboNoptype.Items.Add("포장");
            cboNoptype.SelectedIndex = 0;
            cboNoptype.DropDownStyle = ComboBoxStyle.DropDownList;

            CommonCodeUtil.UseYNComboBinding(cboSearchUse);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboSearchUse.SelectedIndex = 0;
            cboSearchUse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUseYN.DropDownStyle = ComboBoxStyle.DropDownList;

            DeactivationBottom(); //입력패널 비활성화
            OnSearch();
            nudSort.Visible = label13.Visible = label8.Visible = txtRemark.Visible = false;
        }

        private void AdvancedListBind(List<NopMiCodeDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<NopMiCodeDTO>(datasource), null);
            dgv.DataSource = null;
            dgv.DataSource = bs;
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            NopMiCodeDTO item = new NopMiCodeDTO
            {
                Nop_Ma_Code = ucMaCodeSC._Code,
                Nop_Ma_Name = ucMaCodeSC._Name,
                Use_YN = cboSearchUse.Text
            };
            NopMiList = srv.GetNopMiSearch(item);

            if (NopMiList != null && NopMiList.Count > 0)
            {
                var list = NopMiList.GroupBy((n) => n.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
                AdvancedListBind(list, dgvMaData);

                //var list = from n in NopMiList
                //           group new { Nop_Ma_Code = n.Nop_Ma_Code }
                //           by n.Nop_Ma_Code;

                //var list = (from n in NopMiList 
                //            group n by n.Nop_Ma_Code).ToList();
                //new
                //{
                //    n.Nop_Ma_Code,
                //    n.Nop_Ma_Name,
                //    n.Use_YN
                //}).ToList();

                //Debug.WriteLine(list);
            }

            if (situation == "")
                dgvMiData.DataSource = null;
            //dgvMiData.DataSource = NopMiList;

            ResetBottom();        //입력 리셋
            DeactivationBottom(); //입력 비활성화
        }


        public void OnAdd()     //추가
        {
            if (dgvMaData.SelectedRows.Count < 1)
            {
                MessageBox.Show("추가할 항목을 선택하여 주십시오.");
                return;
            }

            situation = "Add";
            DeactivationTop();            //검색조건 비활성화
            ResetBottom();                //입력패널 리셋
            ActivationBottom(situation);  //입력패널 활성화
            cboUseYN.SelectedIndex = 0;
            txtInfoCodeMi.Focus();
        }
        public void OnEdit()    //수정
        {
            if (dgvMiData.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            situation = "Update";
            DeactivationTop();      //검색조건 비활성화
            ActivationBottom(situation);  //입력패널 활성화
        }
        public void OnDelete()  //삭제
        {
            if (dgvMiData.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주십시오.");
                return;
            }

            dgvMaData.Enabled = dgvMiData.Enabled = false;

            if (MessageBox.Show($"{txtInfoNameMi.Text}을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeleteMiCode(txtInfoCodeMi.Text);
                if (result == 0) MessageBox.Show("삭제가 완료되었습니다."); //성공
                else if (result == 3726) MessageBox.Show("데이터를 삭제할 수 없습니다."); //FK 충돌
                else MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                ResetBottom(); //입력패널 리셋
                OnSearch();    //로드
            }
            dgvMaData.Enabled = dgvMiData.Enabled = true;
        }
        public void OnSave()    //저장
        {
            //필수입력항목: 코드, 명, 비가동유형, 사용유무
            if (string.IsNullOrWhiteSpace(txtInfoCodeMi.Text) || string.IsNullOrWhiteSpace(txtInfoNameMi.Text) || cboNoptype.SelectedIndex == 0) //|| cboUseYN.SelectedIndex == 0
            {
                MessageBox.Show("필수항목을 입력하여 주십시오.");
                return;
            }

            NopMiCodeDTO code = new NopMiCodeDTO
            {
                Nop_Ma_Code = ucMaCode._Code,
                Nop_Mi_Code = txtInfoCodeMi.Text,
                Nop_Mi_Name = txtInfoNameMi.Text,
                Nop_type = cboNoptype.Text.Equals("시유") ? "PG050" : "PG070",
                Use_YN = cboUseYN.Text.Equals("예") ? "Y" : "N",
                Ins_Emp = "홍길동", //////////////////////////
                Up_Emp = "홍길동" //////////////////////////////////////////////////////// 추후수정
            };

            if (situation == "Add")
            {
                bool pkresult = srv.CheckMiPK(txtInfoCodeMi.Text);
                if (!pkresult)
                {
                    MessageBox.Show("상세코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    txtInfoCodeMi.Clear();
                    txtInfoCodeMi.Focus();
                    return;
                }
                bool result = srv.NopMiCodeAdd(code);
                if (result) MessageBox.Show("등록이 완료되었습니다.", "등록완료");
                else
                {
                    MessageBox.Show("다시 시도하여주십시오.", "등록오류");
                    return;
                }
            }
            else if (situation == "Update")
            {
                bool result = srv.NopMiCodeUpdate(code);
                if (result) MessageBox.Show("수정이 완료되었습니다.", "수정완료");
                else
                {
                    MessageBox.Show("다시 시도하여주십시오.", "수정오류");
                    return;
                }
            }

            //OnReLoad();
            OnSearch();         //로드
            ActivationTop();    //검색 활성화
            situation = "";
            dgvMaData.Enabled = dgvMiData.Enabled = true;
        }

        public void OnCancel()  //취소
        {
            dgvMaData.Enabled = dgvMiData.Enabled = true;
            ResetBottom();          //입력 리셋
            DeactivationBottom();   //입력 비활성화
            OnSearch();             //로드
            ActivationTop();        //검색 활성화
        }
        public void OnReLoad()  //새로고침
        {
            //Deactivation();
            ResetTop();       //검색 리셋
            ResetBottom();    //입력 리셋
            OnSearch();       //로드
        }
        #endregion

        private void ResetTop() //검색 리셋
        {
            ucMaCodeSC._Code = ucMaCodeSC._Name = "";
            cboSearchUse.SelectedIndex = 0;
        }

        private void ActivationTop() //검색 활성화
        {
            ucMaCodeSC.Enabled = cboSearchUse.Enabled = true;
        }

        private void DeactivationTop() //검색 비활성화
        {
            ucMaCodeSC.Enabled = cboSearchUse.Enabled = false;
        }

        private void ResetBottom() //입력 리셋
        {
            foreach (Control ctrl in splitContainer2.Panel2.Controls)
            {
                if (ctrl is Label || ctrl is Panel) continue;
                if (ctrl is TextBox) ctrl.Text = "";
            }
            ucMaCode._Code = ucMaCode._Name = "";
            cboNoptype.SelectedIndex = cboUseYN.SelectedIndex = -1;
        }

        private void ActivationBottom(string situation) //입력 활성화
        {
            foreach (Control ctrl in splitContainer2.Panel2.Controls)
                ctrl.Enabled = true;
            if (situation.Equals("Update"))
            {
                ucMaCode.Enabled = false;
                txtInfoCodeMi.Enabled = false;
            }
            dgvMaData.Enabled = dgvMiData.Enabled = false;
            dgvMaData.ClearSelection();
            dgvMiData.ClearSelection();
        }

        private void DeactivationBottom() //입력 비활성화
        {
            foreach (Control ctrl in splitContainer2.Panel2.Controls)
                ctrl.Enabled = false;
        }

        private void ucCodeSearch_BtnClick(object sender, EventArgs e)
        {
            var list = NopMiList.GroupBy((g) => g.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류코드", "Nop_Ma_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류명", "Nop_Ma_Name", 200));

            CommonPop<NopMiCodeDTO> dto = new CommonPop<NopMiCodeDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "비가동 대분류코드 검색";
            ucMaCodeSC.OpenPop(dto);
        }

        private void ucMaCode_BtnClick(object sender, EventArgs e)
        {
            var list = NopMiList.GroupBy((g) => g.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류코드", "Nop_Ma_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류명", "Nop_Ma_Name", 200));

            CommonPop<NopMiCodeDTO> dto = new CommonPop<NopMiCodeDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "비가동 대분류코드 검색";
            ucMaCode.OpenPop(dto);
        }

        private void dgvMaData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (!string.IsNullOrWhiteSpace(NopMiList[0].Nop_Ma_Code))
            {
                string code = dgvMaData["Nop_Ma_Code", e.RowIndex].Value.ToString();
                //List<NopMiCodeDTO> list = NopMiList.FindAll((c) => c.Nop_Ma_Code == code);

                var list = (from n in NopMiList
                            where n.Nop_Ma_Code.Equals(code) && n.Nop_Mi_Code != null
                            select n).ToList();

                //var list = NopMiList.GroupBy((n) => n.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
                if (NopMiList == null) return;
                AdvancedListBind(list, dgvMiData);
            }
            dgvMiData.ClearSelection();
        }

        private void dgvMiData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ucMaCode._Code = dgvMaData[0, dgvMaData.CurrentRow.Index].Value.ToString();
            ucMaCode._Name = dgvMaData[1, dgvMaData.CurrentRow.Index].Value.ToString();
            txtInfoCodeMi.Text = dgvMiData["Nop_Mi_Code", e.RowIndex].Value.ToString();
            txtInfoNameMi.Text = dgvMiData["Nop_Mi_Name", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvMiData["Use_YN", e.RowIndex].Value.ToString();

            //ucMaCode._Code = dgvMaData["Nop_Ma_Code", dgvMaData.CurrentRow.Index].Value.ToString();
            //ucMaCode._Name = dgvMaData["Nop_Ma_Name", dgvMaData.CurrentRow.Index].Value.ToString();
        }


    }
}
