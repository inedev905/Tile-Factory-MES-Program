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

namespace Team2_Project
{
    public partial class frmProcessManagement : Team2_Project.frmListUpAreaDown
    {
        public event EventHandler BtnClick;
        string loginedUser = "";
        bool isAdd, isEdit = false;
        ProcessMasterService service;

        // 리스트
        List<ProcessMasterDTO> processList = null;
        List<CodeDTO> code;

        public frmProcessManagement()
        {
            InitializeComponent();
        }

        private void frmProcessManagement_Load(object sender, EventArgs e)
        {
            //loginedUser = this.MdiParent. //로그인 유저
            
            service = new ProcessMasterService();
            CodeSetting();
            // DGV 설정
            DataGridViewUtil.SetInitDataGridView(dgvProcess);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정코드", "Process_Code", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정명", "Process_Name", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "공정그룹", "Process_Group", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "비고", "Remark", 900);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProcess, "사용유무", "Use_YN", 120);
            dgvProcess.MultiSelect = false;
            
            //CBO 설정
            CommonCodeUtil.ComboBinding(cboProcessGroupArea, code, "PROC_GROUP");
            CommonCodeUtil.ComboBinding(cboProcessGroupSub, code, "PROC_GROUP");
            CommonCodeUtil.ComboBinding(cboUseArea, code, "use");
            CommonCodeUtil.ComboBinding(cboUseSub, code, "use");

            //데이터 불러오기
            processList = service.SetData();
            BindingSource bs = new BindingSource(new AdvancedList<ProcessMasterDTO>(processList), null);
            dgvProcess.DataSource = bs;
            // 기본설정
            //아래 패널 크기 120 으로 고정
            splitContainer1.SplitterDistance = 467;

            // 콤보박스 초기화
            cboProcessGroupSub.SelectedIndex = cboUseSub.SelectedIndex = cboProcessGroupArea.SelectedIndex = cboUseArea.SelectedIndex = 0;

            // Enable 처리
            txtProcessCode.Enabled = txtProcessCodeName.Enabled = txtRemark.Enabled = cboProcessGroupArea.Enabled = cboUseArea.Enabled = false;
            dgvProcess.ClearSelection();
        }



        /// <summary>
        /// 메인 버튼 이벤트정렬
        /// 검색, 추가, 수정, 삭제, 저장, 취소, 새로고침, 엑셀
        /// </summary>
        //검색
        public void OnSearch()
        {
            // 검색
            string processCode = ucSearch1._Code;
            string processGroup = (cboProcessGroupSub.SelectedValue.ToString() == "선택") ? "" : cboProcessGroupSub.SelectedValue.ToString();
            string useYN;
            if (cboUseSub.SelectedValue.ToString() == "")
                useYN = "";
            else if (cboUseSub.SelectedValue.ToString() == "Y")
                useYN = "예";
            else useYN = "아니요";
            
            var list = (from c in processList
                        where c.Process_Code.Contains(processCode) && c.Process_Group.Contains(processGroup) && c.Use_YN.Contains(useYN)
                        select c).ToList();
            
            BindingSource bs = new BindingSource(new AdvancedList<ProcessMasterDTO>(list), null);
            dgvProcess.DataSource = bs;
            dgvProcess.Enabled = true;
            dgvProcess.ClearSelection();
        }
        //추가
        public void OnAdd()
        {
            if (isAdd) return;
            if (isEdit) return;
            //추가
            isAdd = true;
            txtProcessCode.Enabled = txtProcessCodeName.Enabled = txtRemark.Enabled = cboProcessGroupArea.Enabled = cboUseArea.Enabled = true;
            
            // 중복 업무 처리 금지
            dgvProcess.Enabled = false;
            ucSearch1.Enabled = cboProcessGroupSub.Enabled = cboUseSub.Enabled = false;
        }
        //수정
        public void OnEdit()
        {
            if (isAdd) return;
            if (isEdit) return;
            if (string.IsNullOrWhiteSpace(txtProcessCodeName.Text))
            {
                MessageBox.Show("선택된 정보가 없습니다.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            //수정
            isEdit = true;
            txtProcessCodeName.Enabled = txtRemark.Enabled = cboProcessGroupArea.Enabled = cboUseArea.Enabled = true;

            // 중복 업무 처리 금지
            dgvProcess.Enabled = ucSearch1.Enabled = cboProcessGroupSub.Enabled = cboUseSub.Enabled = false;
        }
        //삭제
        public void OnDelete()
        {
            if (isAdd || isEdit) return;
            
            if (string.IsNullOrWhiteSpace(txtProcessCodeName.Text))
            {
                MessageBox.Show("선택된 정보가 없습니다.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            //삭제
            try 
            {
                processList = service.DelProcess(txtProcessCode.Text);
                MessageBox.Show("삭제 성공 했습니다.");
            }
            catch 
            {
                MessageBox.Show("삭제 실패 했습니다.");
            }
            finally
            {
                BindingSource bs = new BindingSource(new AdvancedList<ProcessMasterDTO>(processList), null);
                dgvProcess.DataSource = bs;

                //후처리
                txtProcessCode.Clear();
                txtProcessCodeName.Clear();
                txtRemark.Clear();
                cboProcessGroupSub.SelectedIndex = cboUseSub.SelectedIndex = cboProcessGroupArea.SelectedIndex = cboUseArea.SelectedIndex = 0;
                dgvProcess.Enabled = true;
                dgvProcess.ClearSelection();
            }
        }
        //저장
        public void OnSave()
        {
            if (!isAdd && !isEdit) return;
            
            if (string.IsNullOrWhiteSpace(txtProcessCode.Text)) 
            {
                txtProcessCode.Focus();
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProcessCodeName.Text))
            {
                txtProcessCodeName.Focus();
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            if (cboProcessGroupArea.SelectedIndex == 0)
            {
                cboProcessGroupArea.Focus();
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }
            if (cboUseArea.SelectedIndex == 0)
            {
                cboUseArea.Focus();
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            ProcessMasterDTO Process = new ProcessMasterDTO
            {
                Process_Code = txtProcessCode.Text,
                Process_Name = txtProcessCodeName.Text,
                Process_Group = cboProcessGroupArea.SelectedValue.ToString(),
                Use_YN = cboUseArea.SelectedValue.ToString(),
                Remark = txtRemark.Text,
                Up_Date = DateTime.Now,
                Up_Emp = "1000" //loginedUser
            };

            List<ProcessMasterDTO> empt = new List<ProcessMasterDTO>();

            // 중복
            if (isAdd)
            {
                //중복 처리
                if (processList.Find((l) => l.Process_Code == txtProcessCode.Text.Trim()) != null)
                {
                    MessageBox.Show("이미 있는 코드 입니다.");
                    txtProcessCode.Focus();
                    return;
                }
                empt = service.InputProcess(Process);
                if (empt == null)
                    MessageBox.Show("추가 실패 했습니다.");
                else
                    processList = empt;
            }   
            if (isEdit)
            {
                empt = service.EditProcess(Process);
                if (empt == null)
                    MessageBox.Show("수정 실패 했습니다.");
                else
                    processList = empt;
                }
            BindingSource bs = new BindingSource(new AdvancedList<ProcessMasterDTO>(processList), null);
            dgvProcess.DataSource = bs;

            // 후처리
            OnCancel();
            txtProcessCode.Clear();
            txtProcessCodeName.Clear();
            txtRemark.Clear();
            cboProcessGroupSub.SelectedIndex = cboUseSub.SelectedIndex = 0;
            ucSearch1._Code = ucSearch1._Name = "";
            dgvProcess.Enabled = true;
            dgvProcess.ClearSelection();
            //txtProcessCode.Enabled = txtProcessCodeName.Enabled = txtRemark.Enabled = cboProcessGroupArea.Enabled = cboUseArea.Enabled = isAdd = isEdit = false;
            //ucSearch1.Enabled = cboProcessGroupSub.Enabled = cboUseSub.Enabled = true;
            //txtProcessCode.Clear();
            //txtProcessCodeName.Clear();
            //txtRemark.Clear();
            //cboProcessGroupArea.SelectedIndex = 0;
            //cboUseArea.SelectedIndex = 0;
        }
        //취소
        public void OnCancel()
        {
            if (!isAdd && !isEdit) return;
            //취소
            txtProcessCode.Clear();
            txtProcessCodeName.Clear();
            cboProcessGroupArea.SelectedIndex = cboUseArea.SelectedIndex = 0;
            txtRemark.Clear();
            dgvProcess.Enabled = true;
            dgvProcess.ClearSelection();
            // 후처리
            txtProcessCode.Enabled = txtProcessCodeName.Enabled = txtRemark.Enabled = cboProcessGroupArea.Enabled = cboUseArea.Enabled = isAdd = isEdit = false;
            ucSearch1.Enabled = cboProcessGroupSub.Enabled = cboUseSub.Enabled = true;
        }

        private void dgvProcess_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtProcessCode.Text = dgvProcess["Process_Code", e.RowIndex].Value.ToString();
            txtProcessCodeName.Text = dgvProcess["Process_Name", e.RowIndex].Value.ToString();
            cboProcessGroupArea.SelectedValue = dgvProcess["Process_Group", e.RowIndex].Value.ToString();
            cboUseArea.SelectedValue = (dgvProcess["Use_YN", e.RowIndex].Value.ToString() == "예") ? "Y" : "N";
            txtRemark.Text = dgvProcess["Remark", e.RowIndex].Value.ToString();
        }

        //새로고침
        public void OnReLoad()
        {
            OnCancel();
            // 새로 고침
            cboProcessGroupSub.SelectedIndex = cboUseSub.SelectedIndex = 0;
            ucSearch1._Code = ucSearch1._Name = "";
            
            //ReLoad
            processList = service.SetData();
            
            BindingSource bs = new BindingSource(processList, null);
            dgvProcess.DataSource = bs;
            dgvProcess.Enabled = true;
            dgvProcess.ClearSelection();
        }

        private void ucSearch1_BtnClick(object sender, EventArgs e)
        {
            string codes = ucSearch1._Code;
            string names = ucSearch1._Name;
            var list = (from c in processList
                        where c.Process_Name.Contains(names) && c.Process_Code.Contains(codes)
                        select c).ToList();

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공정코드", "Process_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("공종코드명", "Process_Name", 200));

            CommonPop<ProcessMasterDTO> popInfo = new CommonPop<ProcessMasterDTO>();
            popInfo.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목코드 검색";
            ucSearch1.OpenPop(popInfo);
        }

        public void CodeSetting()
        {
            code = new List<CodeDTO>();
            CodeDTO item = new CodeDTO();
            item.Code = "PG050";
            item.Category = "PROC_GROUP";
            item.Name = "시유";
            item.Pcode = "";
            code.Add(item);
            CodeDTO item2 = new CodeDTO();
            item2.Code = "PG070";
            item2.Category = "PROC_GROUP";
            item2.Name = "포장";
            item2.Pcode = "";
            code.Add(item2);
            CodeDTO item3 = new CodeDTO();
            item3.Code = "Y";
            item3.Category = "use";
            item3.Name = "예";
            item3.Pcode = "";
            code.Add(item3);
            CodeDTO item4 = new CodeDTO();
            item4.Code = "N";
            item4.Category = "use";
            item4.Name = "아니요";
            item4.Pcode = "";
            code.Add(item4);
        }
    }
}
