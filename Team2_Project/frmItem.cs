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
    public partial class frmItem : frmListUpAreaDown
    {
        ItemService srv = new ItemService();
        List<ItemDTO> itemList = new List<ItemDTO>();
        List<CodeDTO> CodeList = new List<CodeDTO>();
        string situation = "";

        public frmItem()
        {
            InitializeComponent();
        }

        #region Main 버튼 클릭이벤트  /////////////////// 이거 복사해서 쓰세요 ///////////////////
        //public void OnSearch()  //검색 
        //{

        //}

        //public void OnAdd()     //추가
        //{


        //}
        //public void OnEdit()    //수정
        //{

        //}
        //public void OnDelete()  //삭제
        //{

        //}
        //public void OnSave()    //저장
        //{

        //}
        //public void OnCancel()  //취소
        //{

        //}
        //public void OnReLoad()  //새로고침
        //{

        //}
        //public void OnPrint()   //프린트(액셀)
        //{

        //}
        #endregion


        private void frmMenu_Load(object sender, EventArgs e)
        {
            //1. 추가,수정버튼 클릭 -> 입력패널이 활성화
            //2. 저장버튼 클릭 시   -> 추가,수정 적용 

            LoadData();     //로드            
            OnSearch();     //조회
        }

        private void LoadData()
        {
            //CodeList = srv.GetCode("ITEM_TYPE");
            ////CommonCodeUtil.ComboBinding(cboTypeSC, CodeList, "ITEM_TYPE");

            //var cboList = (from li in CodeList
            //                   where li.Name == cboTypeSC.Text
            //                   select new CodeDTO
            //                   {
            //                       Code = li.Code,
            //                       Name = li.Name,
            //                       Category = "ITEM_TYPE"
            //                   }).ToList();
            //CommonCodeUtil.ComboBinding(cboTypeSC, cboList, "ITEM_TYPE");



            cboTypeSC.Items.Add("전체");
            cboTypeSC.Items.Add("완제품");
            cboTypeSC.Items.Add("반제품");
            cboTypeSC.SelectedIndex = 0;
            cboTypeSC.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목유형", "Item_Type", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "규격", "Item_Spec", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "사용유무", "Use_YN", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "비고", "Remark", 500);
            dgvData.MultiSelect = false;

            CommonCodeUtil.UseYNComboBinding(cboUseYNSC);
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            cboUseYNSC.SelectedIndex = 0;
            cboUseYNSC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUseYN.DropDownStyle = ComboBoxStyle.DropDownList;

            cboType.Items.Add("-선택-");
            cboType.Items.Add("완제품");
            cboType.Items.Add("반제품");
            cboType.SelectedIndex = 0;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;

            cboSpec.Items.Add("-선택-");
            cboSpec.Items.Add("300x600");
            cboSpec.Items.Add("200x500");
            cboSpec.SelectedIndex = 0;
            cboSpec.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AdvancedListBind(List<ItemDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<ItemDTO>(datasource), null);
            dgv.DataSource = null;
            dgv.DataSource = bs;
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            ItemDTO item = new ItemDTO
            {
                Item_Code = ucCodeSearch._Code,
                Item_Name = ucCodeSearch._Name,
                Item_Type = cboTypeSC.Text,
                Use_YN = cboUseYNSC.Text
            };
            itemList = srv.GetItemSearch(item);

            AdvancedListBind(itemList, dgvData);

            //dgvData.ClearSelection();
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
                int result = srv.DeleteItemCode(txtCode.Text);
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
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text) || cboType.SelectedIndex == 0)
            {
                MessageBox.Show("필수항목을 입력하여 주십시오.");
                return;
            }
            else if (cboType.SelectedIndex != 2 && cboSpec.SelectedIndex == 0)
            {
                MessageBox.Show("규격을 선택하여 주십시오.");
                return;
            }

            ItemDTO item = new ItemDTO
            {
                Item_Code = txtCode.Text,
                Item_Name = txtName.Text,
                Item_Type = cboType.Text.Equals("완제품") ? "PR" : "SA",
                Item_Spec = cboSpec.Text.Equals("-선택-") ? "" : cboSpec.Text,
                Use_YN = cboUseYN.Text.Equals("예") ? "Y" : "N",
                Remark = txtRemark.Text,
                Ins_Emp = "홍길동", ///////////////////////////////////////////////////// 추후수정
                Up_Emp = "홍길동"   ///////////////////////////////////////////////////// 추후수정
            };

            if (situation == "Add")
            {
                bool pkresult = srv.CheckPK(txtCode.Text);
                if (!pkresult)
                {
                    MessageBox.Show("품목코드가 중복되었습니다. 다시 입력하여 주십시오.");
                    txtCode.Clear();
                    txtCode.Focus();
                    return;
                }

                bool result = srv.GetItemAdd(item);
                if (result) MessageBox.Show("등록이 완료되었습니다.", "등록완료");
                else
                {
                    MessageBox.Show("다시 시도하여주십시오.", "등록오류");
                    return;
                }
            }
            else if (situation == "Update")
            {
                bool result = srv.GetItemUpdate(item);
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
            cboTypeSC.SelectedIndex = cboUseYNSC.SelectedIndex = 0;
        }

        private void ActivationTop() //검색 활성화
        {
            ucCodeSearch.Enabled = cboTypeSC.Enabled = cboUseYNSC.Enabled = true;
        }

        private void DeactivationTop() //검색 비활성화
        {
            ucCodeSearch.Enabled = cboTypeSC.Enabled = cboUseYNSC.Enabled = false;
        }

        private void ResetBottom() //입력 리셋
        {
            txtCode.Text = txtName.Text = txtRemark.Text = "";
            cboType.SelectedIndex = cboSpec.SelectedIndex = 0;
            cboUseYN.SelectedIndex = -1;
        }

        private void ActivationBottom(string situation) //입력 활성화
        {
            if (situation.Equals("Add")) txtCode.Enabled = true;
            else txtCode.Enabled = false; //PK유지
            txtName.Enabled = txtRemark.Enabled = cboType.Enabled = cboSpec.Enabled = cboUseYN.Enabled = true;
            dgvData.Enabled = false;
            dgvData.ClearSelection();
        }

        private void DeactivationBottom() //입력 비활성화
        {
            txtCode.Enabled = txtName.Enabled = txtRemark.Enabled = cboType.Enabled = cboSpec.Enabled = cboUseYN.Enabled = false;
        }

        private void ucCodeSearch_BtnClick(object sender, EventArgs e)
        {
            var list = itemList.GroupBy((g) => g.Item_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            CommonPop<ItemDTO> popInfo = new CommonPop<ItemDTO>();
            popInfo.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목코드 검색";
            ucCodeSearch.OpenPop(popInfo);
        }

        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboType == null) return; // || cboType.SelectedIndex < 1
            if (cboType.Enabled == true)
            {
                if (cboType.Text == "반제품")
                {
                    cboSpec.SelectedIndex = 0;
                    cboSpec.Enabled = false;
                }
                else
                    cboSpec.Enabled = true;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Test");

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            txtCode.Text = dgvData["Item_Code", e.RowIndex].Value.ToString();
            txtName.Text = dgvData["Item_Name", e.RowIndex].Value.ToString();
            cboType.SelectedItem = dgvData["Item_Type", e.RowIndex].Value.ToString();
            if (dgvData["Item_Spec", e.RowIndex].Value.Equals("")) cboSpec.SelectedIndex = -1;
            else cboSpec.SelectedItem = dgvData["Item_Spec", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvData["Use_YN", e.RowIndex].Value.ToString();
            txtRemark.Text = dgvData["Remark", e.RowIndex].Value.ToString();
        }
    }
}

/*[품목정보]
	시유전 “반제품” 2개
	사이즈2개 프린트8개 (시유라인4개)
	총 “완제품” 16가지*/