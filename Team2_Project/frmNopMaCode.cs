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
    public partial class frmNopMaCode : frmListUpAreaDown
    {
        NopCodeService srv = new NopCodeService();
        List<NopMaCodeDTO> NopMaList = new List<NopMaCodeDTO>();
        string situation = "";

        public frmNopMaCode()
        {
            InitializeComponent();
        }

        private void frmDownCode_Load(object sender, EventArgs e)
        {
            LoadData();     //로드            
            OnSearch();     //조회
        }

        private void LoadData()
        {
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류코드", "Nop_Ma_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비가동 대분류명", "Nop_Ma_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "사용유무", "Use_YN");
            dgvData.MultiSelect = false;

            CommonCodeUtil.UseYNComboBinding(cboUseYNSC);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboUseYNSC.SelectedIndex = 0;
            cboUseYNSC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUseYN.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void AdvancedListBind(List<NopMaCodeDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<NopMaCodeDTO>(datasource), null);
            dgv.DataSource = null;
            dgv.DataSource = bs;
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            NopMaCodeDTO item = new NopMaCodeDTO
            {
                Nop_Ma_Code = ucCodeSearch._Code,
                Nop_Ma_Name = ucCodeSearch._Name,
                Use_YN = cboUseYNSC.Text
            };
            NopMaList = srv.GetNopMaSearch(item);
            AdvancedListBind(NopMaList, dgvData);
            dgvData.ClearSelection();
            ResetBottom();  //입력패널 리셋
            DeactivationBottom(); //입력패널 비활성화
        }
        public void OnAdd()     //추가
        {
            situation = "Add";
            DeactivationTop();      //검색조건 비활성화
            ResetBottom();          //입력패널 리셋
            ActivationBottom(situation);  //입력패널 활성화
            cboUseYN.SelectedIndex = 0;
            txtCode.Focus();
        }
        public void OnEdit()    //수정
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 항목을 선택하여 주십시오.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            situation = "Update";
            DeactivationTop();      //검색조건 비활성화
            ActivationBottom(situation);  //입력패널 활성화
            //txtName.Focus();
        }
        public void OnDelete()  //삭제
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택하여 주십시오.");
                return;
            }

            dgvData.Enabled = false;

            if (MessageBox.Show($"{txtName.Text}을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeleteMaCode(txtCode.Text);
                if (result == 0) MessageBox.Show("삭제가 완료되었습니다."); //성공
                else if (result == 3726) MessageBox.Show("데이터를 삭제할 수 없습니다."); //FK 충돌
                else MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                ResetBottom(); //입력패널 리셋
                OnSearch();    //로드
            }
            dgvData.Enabled = true;
        }
        public void OnSave()    //저장
        {
            //필수입력항목: 코드, 명, 사용유무
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text)) //|| cboUseYN.SelectedIndex == 0
            {
                MessageBox.Show("필수항목을 입력하여 주십시오.");
                return;
            }

            NopMaCodeDTO item = new NopMaCodeDTO
            {
                Nop_Ma_Code = txtCode.Text,
                Nop_Ma_Name = txtName.Text,
                Use_YN = cboUseYN.Text.Equals("예") ? "Y" : "N",
                Ins_Emp = "홍길동", ///////////////////////////////////
                Up_Emp = "홍길동" //////////////////////////////////////////////////////// 추후수정
            };

            if (situation == "Add") //cboUseYN "아니오"로 저장하면 "예"로 저장되는 오류찾기!!*****
            {
                bool pkresult = srv.CheckPK(txtCode.Text);
                if (!pkresult)
                {
                    MessageBox.Show("대분류코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    txtCode.Clear();
                    txtCode.Focus();
                    return;
                }

                bool result = srv.NopMaCodeAdd(item);
                if (result) MessageBox.Show("등록이 완료되었습니다.", "등록완료");
                else
                {
                    MessageBox.Show("다시 시도하여주십시오.", "등록오류");
                    return;
                }
            }
            else if (situation == "Update")
            {
                bool result = srv.NopMaCodeUpdate(item);
                if (result) MessageBox.Show("수정이 완료되었습니다.", "수정완료");
                else
                {
                    MessageBox.Show("다시 시도하여주십시오.", "수정오류");
                    return;
                }
            }

            OnReLoad();
            ActivationTop();    //검색 활성화
            situation = "";
            dgvData.Enabled = true;
        }

        public void OnCancel()  //취소
        {
            dgvData.Enabled = true;
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
            ucCodeSearch._Code = ucCodeSearch._Name = "";
            cboUseYNSC.SelectedIndex = 0;
        }

        private void ActivationTop() //검색 활성화
        {
            ucCodeSearch.Enabled = cboUseYNSC.Enabled = true;
        }

        private void DeactivationTop() //검색 비활성화
        {
            ucCodeSearch.Enabled = cboUseYNSC.Enabled = false;
        }

        private void ResetBottom() //입력 리셋
        {
            txtCode.Text = txtName.Text = "";
            cboUseYN.SelectedIndex = -1;
        }

        private void ActivationBottom(string situation) //입력 활성화
        {
            if (situation.Equals("Add")) txtCode.Enabled = true;
            else txtCode.Enabled = false; //Update : PK유지
            txtName.Enabled = cboUseYN.Enabled = true;
            dgvData.Enabled = false;
            dgvData.ClearSelection();
        }

        private void DeactivationBottom() //입력 비활성화
        {
            txtCode.Enabled = txtName.Enabled = cboUseYN.Enabled = false;
        }

        private void ucCodeSearch_BtnClick(object sender, EventArgs e)
        {
            var list = NopMaList.GroupBy((g) => g.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류코드", "Nop_Ma_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("비가동 대분류명", "Nop_Ma_Name", 200));

            CommonPop<NopMaCodeDTO> dto = new CommonPop<NopMaCodeDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "비가동 대분류코드 검색";
            ucCodeSearch.OpenPop(dto);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            txtCode.Text = dgvData["Nop_Ma_Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvData["Nop_Ma_Name", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvData["Use_YN", e.RowIndex].Value.ToString();
        }
    }
}