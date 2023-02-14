using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmWorkCenter : frmListUpAreaDown
    {
        WorkCenterService srv = new WorkCenterService();
        ProcessMasterService prosrv = new ProcessMasterService();
        List<WorkCenterDTO> wcList;
        List<CodeDTO> code;
        List<ProcessMasterDTO> processList = null;
        string empID;       
        string clickState = "";
        public frmWorkCenter()
        {
            InitializeComponent();
        }

        private void frmWorkShopInfo_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmp.User_ID;
            ComboBoxCode();

            DataGridViewUtil.SetInitDataGridView(dgvWorkShop);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 상태", "Wc_Status", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 코드", "Wc_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 명", "Wc_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 그룹 명", "Wc_Group_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업지시 상태", "Wo_Status_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정 코드", "Process_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "공정명", "Process_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "팔렛생성여부", "Pallet_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "사용여부", "Use_YN", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "비고", "Remark", 150);

            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업장 그룹", "Wc_Group",visible:false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWorkShop, "작업지시 상태코드", "Wo_Status", visible: false);
            dgvWorkShop.MultiSelect = false;

            CommonCodeUtil.UseYNComboBinding(cboSearchUseYN);
            cboSearchUseYN.SelectedIndex = 0;
            CommonCodeUtil.UseYNComboBinding(cboUseYN, false);
            CommonCodeUtil.UseYNComboBinding(cboPalletYN, false);
            CommonCodeUtil.ComboBinding(cboWCGroup, code, "WC_GROUP");
            CommonCodeUtil.ComboBinding(cboWCGroup, code, "WC_GROUP");
            CommonCodeUtil.ComboBinding(cboWCGroup, code, "WC_GROUP");


            SetInitEditPnl();
            LoadData();
        }
        private void LoadData()
        {
            wcList = srv.GetWorkCenterInfo();
            BindingSource wc = new BindingSource(new AdvancedList<WorkCenterDTO>(wcList), null);
            processList = prosrv.SetData();
            dgvWorkShop.ClearSelection();
            dgvWorkShop.DataSource = null;
            dgvWorkShop.DataSource = wc;
        }
        #region 패널 이벤트
        private void SetSearchPnl()  //검색 패널 값 clear 및 잠금
        {
            foreach (Control ctrl in pnlSub.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }

            ucSrchProcCode._Code = "";
            ucSrchProcCode._Name = "";
            cboSearchUseYN.SelectedIndex = -1;
        }
        private void OpenSearchPnl()    //검색 패널 Clear 및 잠금해제
        {
            txtSearchCode.Text = txtSearchName.Text = ucSrchProcCode._Code = ucSrchProcCode._Name = "";
            txtSearchCode.Enabled = txtSearchName.Enabled = ucSrchProcCode.Enabled = cboSearchUseYN.Enabled = true;
            cboSearchUseYN.SelectedIndex = 0;
        }
        private void SetInitEditPnl()   //폼 하단 패널 정보 값 clear 및 잠금
        {
            foreach (Control ctrl in pnlArea.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                    continue;

                if (ctrl is TextBox)
                    ctrl.Text = "";

                ctrl.Enabled = false;
            }
            ucProcCode._Code = ucProcCode._Name = "";
            cboUseYN.SelectedIndex = cboWCGroup.SelectedIndex = cboPalletYN.SelectedIndex = -1;
        }
        private void OpenInitEditPnl()  //폼 하단 패널 잠금해제 
        {
            if (clickState == "Add")    //클릭 상태가 추가일때 PK text 잠금해제 및 clear
            {
                txtCenterCode.Text = txtCenterName.Text = txtRemark.Text =  ucProcCode._Code = ucProcCode._Name = txtRemark.Text = "";
                txtCenterCode.Enabled = txtCenterName.Enabled = txtRemark.Enabled 
                = ucProcCode.Enabled = cboPalletYN.Enabled = cboUseYN.Enabled = cboWCGroup.Enabled =true;
                cboPalletYN.SelectedIndex = cboUseYN.SelectedIndex = cboWCGroup.SelectedIndex = 0;
            }
            else if (clickState == "Edit")
            {
                txtCenterName.Enabled = txtRemark.Enabled = ucProcCode.Enabled = cboPalletYN.Enabled = cboUseYN.Enabled = cboWCGroup.Enabled = true;
                cboPalletYN.SelectedIndex = cboUseYN.SelectedIndex = cboWCGroup.SelectedIndex = 0;
            }
        }
        #endregion

        #region 버튼 이벤트

        public void OnSearch()  //검색
        {
            string groupCode = txtSearchCode.Text;
            string groupName = txtSearchName.Text;
            string processCode = ucSrchProcCode._Code;
            string useYN = (cboSearchUseYN.SelectedItem.ToString() == "전체")? "" : cboSearchUseYN.SelectedItem.ToString();

            var list = (from g in wcList
                        where g.Wc_Group.Contains(groupCode) && g.Wc_Group_Name.Contains(groupName) && g.Process_Code.Contains(processCode) && g.Use_YN.Contains(useYN)
                        select g).ToList();

            BindingSource wc = new BindingSource(new AdvancedList<WorkCenterDTO>(wcList), null);
            dgvWorkShop.DataSource = wc;
            dgvWorkShop.Enabled = true;
            SetInitEditPnl();
        }
        public void OnAdd()     //추가
        {
            clickState = "Add";             //현재 클릭 상태
            SetSearchPnl();                 //검색 패널 claer 및 잠금
            dgvWorkShop.Enabled = false;    //dgv 잠금
            dgvWorkShop.ClearSelection();   //셀 선택 초기화
            OpenInitEditPnl();              //폼 하단 패널 잠금 해제 및 값 초기화
        }
        public void OnEdit()    //수정
        {
            if (dgvWorkShop.SelectedRows.Count < 1)                 // 셀 선택 안했을 때
            {
                MessageBox.Show("수정할 항목을 선택하여 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);      // Main버튼 이벤트 초기화
                return;
            }
            clickState = "Edit";                                    //현재 클릭 상태
            dgvWorkShop.Enabled = false;                            //dgv 잠금
            dgvWorkShop.ClearSelection();                           //셀 선택 초기화
            SetSearchPnl();                                         //검색 패널 잠금 및 값 초기화
            OpenInitEditPnl();                                      //폼 하단 패널 잠금 해제 
        }
        public void OnDelete()  //삭제
        {
            if (dgvWorkShop.SelectedRows.Count < 1)                 // 셀 선택 안했을 때
            {
                MessageBox.Show("삭제할 항목을 선택하여 주세요.");
                return;
            }

            dgvWorkShop.Enabled = false;

            if (MessageBox.Show($"{txtCenterName.Text}를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int result = srv.DeleteWorkCenter(txtCenterCode.Text);

                if (result == 0)
                {
                    MessageBox.Show("삭제에 성공하였습니다.");
                }
                else if (result == 3726)
                {
                    MessageBox.Show("데이터를 삭제할 수 없습니다.");
                }
                else
                {
                    MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
                OnReLoad();
            }
            dgvWorkShop.Enabled = true;
        }
        public void OnSave()    //저장
        {
            if (string.IsNullOrWhiteSpace(txtCenterCode.Text) || string.IsNullOrWhiteSpace(txtCenterName.Text) || string.IsNullOrWhiteSpace(ucProcCode._Code))
            {
                MessageBox.Show("필수 항목을 입력해주시기 바랍니다.");
                return;
            }
            else if (cboPalletYN.SelectedIndex == 0 || cboWCGroup.SelectedIndex == 0)
            {
                MessageBox.Show("필수 항목을 입력해주시기 바랍니다.");
                return;
            }
            if (clickState == "Add")    //신규 추가
            {
                bool result = srv.FindSamePK(txtCenterCode.Text);   //PK값 중복체크
                if (!result)                                        //PK값 중복되었을 때
                {
                    MessageBox.Show("작업장 코드가 중복되었습니다. 다시 시도하여 주세요.");
                    return;
                }

                WorkCenterDTO dto = new WorkCenterDTO
                {
                    Wc_Code = txtCenterCode.Text,
                    Wc_Name = txtCenterName.Text,
                    Wc_Group = cboWCGroup.SelectedValue.ToString(),
                    Process_Code = ucProcCode._Code,
                    Process_Name = ucProcCode._Name,
                    Pallet_YN = (cboPalletYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Ins_Emp = empID
                };

                result = srv.InsertWorkCenter(dto);
                if (result)
                {
                    MessageBox.Show("등록이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("등록 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            else if (clickState == "Edit")  //기본값 수정
            {
                WorkCenterDTO dto = new WorkCenterDTO
                {
                    Wc_Code = txtCenterCode.Text,
                    Wc_Name = txtCenterName.Text,
                    Wc_Group = cboWCGroup.SelectedValue.ToString(),
                    Process_Code = ucProcCode._Code,
                    Process_Name = ucProcCode._Name,
                    Pallet_YN = (cboPalletYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Use_YN = (cboUseYN.SelectedItem.ToString() == "예") ? "Y" : "N",
                    Remark = txtRemark.Text,
                    Ins_Emp = empID
                };

                bool result = srv.UpdateWorkCenter(dto);
                if (result)
                {
                    MessageBox.Show("수정이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
            clickState = "";    //클릭 상태 초기화
            SetInitEditPnl();   //폼 하단 패널 clear 및 잠금 
            OpenSearchPnl();    //검색 패널 잠금 해제
            dgvWorkShop.Enabled = true; //dgv 잠금 해제
            LoadData();         //초기 로드 화면
        }
        public void OnCancel()  //취소
        {
            clickState = "";    //클릭 상태 초기화
            SetInitEditPnl();   //폼 하단 패널 clear 및 잠금 
            OpenSearchPnl();    //검색 패널 잠금 해제
            dgvWorkShop.Enabled = true; //dgv 잠금 해제
            LoadData();         //초기 로드 화면 
        }
        public void OnReLoad()  //새로고침
        {
            OpenSearchPnl();    //검색 패널 clear
            SetInitEditPnl();   //폼 하단 입력 패널 clear 및 잠금 
            LoadData();         //초기 로드 화면
        }
        #endregion

        public void ComboBoxCode()
        {
            code = new List<CodeDTO>();

            CodeDTO cd1 = new CodeDTO(); //시유 1
            cd1.Code = "WC02";
            cd1.Category = "WC_GROUP";
            cd1.Name = "W1";
            cd1.Pcode = "";
            code.Add(cd1);

            CodeDTO cd2 = new CodeDTO(); //시유 2
            cd2.Code = "WC03";
            cd2.Category = "WC_GROUP";
            cd2.Name = "W2";
            cd2.Pcode = "";
            code.Add(cd2);

            CodeDTO cd3 = new CodeDTO(); //포장
            cd3.Code = "WC04";
            cd3.Category = "WC_GROUP";
            cd3.Name = "포장";
            cd3.Pcode = "";
            code.Add(cd3);

        }
        private void dgvWorkShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ) return;

            txtCenterCode.Text = dgvWorkShop["Wc_Code", e.RowIndex].Value.ToString();
            txtCenterName.Text = dgvWorkShop["Wc_Name", e.RowIndex].Value.ToString();
            cboWCGroup.SelectedValue = dgvWorkShop["Wc_Group", e.RowIndex].Value.ToString();
            ucProcCode._Code = dgvWorkShop["Process_Code", e.RowIndex].Value.ToString();
            ucProcCode._Name = dgvWorkShop["Process_Name", e.RowIndex].Value.ToString();
            cboPalletYN.SelectedItem = dgvWorkShop["Pallet_YN", e.RowIndex].Value.ToString();
            cboUseYN.SelectedItem = dgvWorkShop["Use_YN", e.RowIndex].Value.ToString();
            txtRemark.Text = dgvWorkShop["Remark", e.RowIndex].Value.ToString();
        }

        private void dgvWorkShop_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWorkShop.Rows[e.RowIndex].Cells[0].Value.ToString() == "Run")
            {
                dgvWorkShop.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.DarkGreen;
                dgvWorkShop.Rows[e.RowIndex].Cells[0].Style.ForeColor = Color.Black;
            }
            else if (dgvWorkShop.Rows[e.RowIndex].Cells[0].Value.ToString() == "Stop")
            {
                dgvWorkShop.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Red;
                dgvWorkShop.Rows[e.RowIndex].Cells[0].Style.ForeColor = Color.White;
            }
        }

        private void ucSrchProcCode_BtnClick(object sender, EventArgs e)
        {           
            string codes = ucSrchProcCode._Code;
            string names = ucSrchProcCode._Name;
            var list = (from p in processList
                        where p.Process_Code.Contains(codes) && p.Process_Name.Contains(names)
                        select p).ToList();
            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공정코드", "Process_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공종코드명", "Process_Name", 200));

            CommonPop<ProcessMasterDTO> popInfo = new CommonPop<ProcessMasterDTO>();
            popInfo.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목코드 검색";
            ucSrchProcCode.OpenPop(popInfo);
        }

        private void ucProcCode_BtnClick(object sender, EventArgs e)
        {
            ucProcCode._Code = ucProcCode._Name = "";
            string codes = ucProcCode._Code;
            string names = ucProcCode._Name;
            var list = (from p in processList
                        where p.Process_Code.Contains(codes) && p.Process_Name.Contains(names)
                        select p).ToList();
            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공정코드", "Process_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공종코드명", "Process_Name", 200));

            CommonPop<ProcessMasterDTO> popInfo = new CommonPop<ProcessMasterDTO>();
            popInfo.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목코드 검색";
            ucProcCode.OpenPop(popInfo);
        }

    }
}
