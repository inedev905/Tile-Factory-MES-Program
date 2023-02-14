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
using Team2_Project.Controls;

namespace Team2_Project
{
    public partial class frmOrder : frmList
    {
        OrderService ordSrv;
        string empId;
        DataTable dt;
        List<ItemDTO> itemCodeList;
        List<ProjectDTO> projectCodeList;
        int idx;    //추가/수정하는 행의 index
        int stat;   //0 = 일반, 1 = 추가, 2 = 수정 상태
        //bool cellEditStat = false;
        int[] orangeCols = new int[] { 2, 6, 7, 9, 10 };
        int dtpMinDays = 1;
        int dtpMaxMonths = 0;

        public frmOrder()
        {
            InitializeComponent();
            ordSrv = new OrderService();
            
            idx = -1;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            empId = ((frmMain)this.MdiParent).LoginEmp.User_ID;
            DataGridViewUtil.SetInitDataGridView(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "생산요청코드", "Prd_Req_No", 120, align:DataGridViewContentAlignment.MiddleCenter, frosen:true); //0
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "순번", "Req_Seq", 50, align: DataGridViewContentAlignment.MiddleCenter, frosen: true); //1
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "프로젝트코드", "Prj_No", 120); //2
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "프로젝트명", "Prj_Name", 140); //3
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "Company_Name", 140); //4
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "요청일자", "Req_Date", 100, align: DataGridViewContentAlignment.MiddleCenter); //5
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "납기일자", "Delivery_Date", 130, align: DataGridViewContentAlignment.MiddleCenter); //6
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목코드", "Item_Code", 120); //7
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "품목명", "Item_Name", 140); //8
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "수량", "Req_Qty", 80, align: DataGridViewContentAlignment.MiddleRight); //9
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "비고", "Remark", 535); //10
            dgvOrder.MultiSelect = false;

            foreach (int i in orangeCols)
            {
                dgvOrder.Columns[i].DefaultCellStyle.BackColor = Color.Orange;
            }

            dtpSearchOrd1.MaxDate = dtpSearchDue1.MaxDate = DateTime.Today;
            dtpSearchOrd2.MinDate = dtpSearchDue2.MinDate = DateTime.Today;

            ResetDtpNSearch();

            stat = 0;
        }

        /// <summary>
        /// 검색조건을 초기화한다.
        /// </summary>
        private void ResetSearchCtrls()
        {
            dtpSearchOrd1.Value = DateTime.Today.AddDays(-7);
            dtpSearchOrd2.Value = DateTime.Today;
            dtpSearchDue1.Value = DateTime.Today.AddMonths(-1);
            dtpSearchDue2.Value = DateTime.Today.AddMonths(1);
            ucSearchItem._Code = "";
            ucSearchItem._Name = "";
            ucSearchProject._Code = "";
            ucSearchProject._Name = "";
        }

        private string[] GetSearchValues()
        {
            return new string[] { dtpSearchOrd1.Value.ToString("yyyy-MM-dd"), dtpSearchOrd2.Value.ToString("yyyy-MM-dd"), 
                    dtpSearchDue1.Value.ToString("yyyy-MM-dd"), dtpSearchDue2.Value.ToString("yyyy-MM-dd"),
                    ucSearchItem._Code, ucSearchProject._Code};
        }

        /// <summary>
        /// ResetSearchCtrls 메서드로 검색조건을 초기화하고 검색한다.
        /// </summary>
        private void ResetDtpNSearch()
        {
            ResetSearchCtrls();
            dt = ordSrv.GetOrderList(GetSearchValues());
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = dt;
        }

        public void OnSearch()
        {
            idx = -1;
            dt = ordSrv.GetOrderList(GetSearchValues());
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = dt;
        }

        /// <summary>
        /// 검색조건 패널을 활성화/비활성화 한다
        /// </summary>
        /// <param name="val">활성화 시키려면 true, 비활성화 시키려면 false를 전달</param>
        private void SetPannel(bool val)
        {
            foreach (Control ctrl in pnlSub.Controls)
            {
                if (ctrl is DateTimePicker || ctrl is ucSearch)
                    ctrl.Enabled = val;
            }
        }

        public void OnAdd()
        {
            SetPannel(false);

            dt.Rows.Add();
            idx = dt.Rows.Count - 1;
            dgvOrder["Req_Qty", idx].ReadOnly = false;
            dgvOrder["Remark", idx].ReadOnly = false;
            dgvOrder.FirstDisplayedCell = dgvOrder[2, idx];

            stat = 1;
        }

        public void OnEdit()
        {
            if (idx < 0)
            {
                MessageBox.Show("수정할 생산요청을 선택해 주세요.");
                ((frmMain)this.MdiParent).BtnEditReturn(true);
                return;
            }

            SetPannel(false);

            dgvOrder.Rows[idx].Cells["Req_Qty"].ReadOnly = false;
            dgvOrder.Rows[idx].Cells["Remark"].ReadOnly = false;
            dgvOrder.FirstDisplayedCell = dgvOrder[2, idx];

            stat = 2;
        }

        public void OnDelete()
        {
            if (idx < 0)
            {
                MessageBox.Show("삭제할 생산요청을 선택해 주세요.");

                return;
            }

            if (MessageBox.Show("선택한 생산요청을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            string msg = ordSrv.Delete(dgvOrder["Prd_Req_No", idx].Value.ToString(), empId);
            
            if (string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("생산요청이 정상적으로 삭제되었습니다.");
                ResetDtpNSearch();

                stat = 0;
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        public void OnSave()
        {
            int i = 0; //유효성 체크용

            try
            {
                if (dgvOrder["Prj_No", idx].Value == null || dgvOrder["Prj_No", idx].Value == DBNull.Value)
                {
                    throw new Exception("프로젝트 정보는 필수 입력 항목입니다.");
                    //MessageBox.Show("프로젝트 정보는 필수 입력 항목입니다.");
                    //return;
                }
                if (dgvOrder["Delivery_Date", idx].Value == null || dgvOrder["Delivery_Date", idx].Value == DBNull.Value)
                {
                    throw new Exception("납기일자는 필수 입력 항목입니다.");
                    //MessageBox.Show("납기일자는 필수 입력 항목입니다.");
                    //return;
                }
                if (dgvOrder["Item_Code", idx].Value == null || dgvOrder["Item_Code", idx].Value == DBNull.Value)
                {
                    throw new Exception("품목정보는 필수 입력 항목입니다.");
                    //MessageBox.Show("품목정보는 필수 입력 항목입니다.");
                    //return;
                }
                if (dgvOrder["Req_Qty", idx].Value == null || dgvOrder["Req_Qty", idx].Value == DBNull.Value)
                {
                    throw new Exception("수량은 필수 입력 항목입니다.");
                    //MessageBox.Show("수량은 필수 입력 항목입니다.");
                    //return;
                }
                if (!int.TryParse(dgvOrder["Req_Qty", idx].Value.ToString(), out i))
                {
                    throw new Exception("수량은 숫자만 입력 가능합니다.");
                    //MessageBox.Show("수량은 숫자만 입력 가능합니다.");
                    //return;
                }

                if (MessageBox.Show("입력한 정보를 저장하시겠습니까?", "저장확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    throw new Exception("");
                    //return;
                }

                string remark = dgvOrder["Remark", idx].Value.ToString();
                if (remark.Length > 200)
                {
                    remark = remark.Substring(0, 200);
                }

                OrderDTO data = new OrderDTO
                {
                    Prd_Req_No = dgvOrder["Prd_Req_No", idx].Value.ToString(),
                    Item_Code = dgvOrder["Item_Code", idx].Value.ToString(),
                    Req_Qty = Convert.ToInt32(dgvOrder["Req_Qty", idx].Value),
                    Prj_No = dgvOrder["Prj_No", idx].Value.ToString(),
                    Delivery_Date = dgvOrder["Delivery_Date", idx].Value.ToString(),
                    Remark = remark
                };

                if (stat == 1) //추가
                {
                    bool result = ordSrv.Insert(data, empId);
                    if (result)
                    {
                        MessageBox.Show("생산요청이 정상적으로 추가되었습니다.");

                        idx = -1;
                        ResetDtpNSearch();
                        stat = 0;
                        SetPannel(true);
                    }
                    else
                    {
                        throw new Exception("생산요청 추가에 실패하였습니다. 다시 시도하여 주세요.");
                        //MessageBox.Show("생산요청 추가에 실패하였습니다. 다시 시도하여 주세요.");
                    }
                }
                else if (stat == 2) //수정
                {
                    string msg = ordSrv.Update(data, empId);
                    if (string.IsNullOrWhiteSpace(msg))
                    {
                        MessageBox.Show("생산요청이 정상적으로 수정되었습니다.");

                        idx = -1;
                        ResetDtpNSearch();
                        stat = 0;
                        SetPannel(true);
                    }
                    else
                    {
                        throw new Exception(msg);
                    }
                }
            }
            catch(Exception err)
            {
                if (!string.IsNullOrWhiteSpace(err.Message))
                    MessageBox.Show(err.Message);

                if(stat == 1)
                    ((frmMain)this.MdiParent).AddClickEvent();
                else
                    ((frmMain)this.MdiParent).EditClickEvent();
            }    
        }

        public void OnCancel()
        {
            if (MessageBox.Show("취소하시겠습니까?", "취소확인", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                if (stat == 1)
                    ((frmMain)this.MdiParent).AddClickEvent();
                else
                    ((frmMain)this.MdiParent).EditClickEvent();

                return;
            }

            idx = -1;
            ResetDtpNSearch();
            dgvOrder.ClearSelection();
            SetPannel(true);

            stat = 0;
        }

        public void OnReLoad()
        {
            idx = -1;
            ResetDtpNSearch();
        }

        private void ucSearchItem_BtnClick(object sender, EventArgs e)
        {
            ucSearchItem.OpenPop(GetPopInfo_Item());
        }

        private void ucSearchProject_BtnClick(object sender, EventArgs e)
        {
            ucSearchProject.OpenPop(GetPopInfo_Project());
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(stat != 0)
            {
                if (e.RowIndex == idx) 
                {
                    switch (e.ColumnIndex)
                    {
                        case 2: OpenPop(GetPopInfo_Project()); break;
                        case 6: SetDtpCell(dgvOrder[e.ColumnIndex, e.RowIndex]); break;
                        case 7: OpenPop(GetPopInfo_Item()); break;
                        default: break;
                    }
                }
            }
        }

        private void SetDtpCell(DataGridViewCell cell)
        {
            dgvOrder.ScrollBars = ScrollBars.None;
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.MinDate = DateTime.Now.AddDays(dtpMinDays);
            if(dtpMaxMonths > 0)
                dtp.MaxDate = DateTime.Now.AddMonths(dtpMaxMonths);
            dtp.Visible = true;
            if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                dtp.Value = DateTime.Parse(cell.Value.ToString());
            else
            {
                dtp.Value = DateTime.Now.AddDays(dtpMinDays);
            }

            var rect = dgvOrder.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, true);
            dtp.Size = new Size(rect.Width, rect.Height);
            dtp.Location = new Point(rect.X, rect.Y);
            dgvOrder.Controls.Add(dtp);

            dtp.CloseUp += Dtp_CloseUp;
            dtp.TextChanged += Dtp_TextChanged;
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            dgvOrder.SelectedRows[0].Cells["Delivery_Date"].Value = ((DateTimePicker)sender).Value.ToString("yyyy-MM-dd");
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Visible = false;
            dgvOrder.Controls.Remove((DateTimePicker)sender);
            dgvOrder.ScrollBars = ScrollBars.Both;
        }

        private CommonPop<ProjectDTO> GetPopInfo_Project()
        {
            if (projectCodeList == null || projectCodeList.Count() < 1)
            {
                projectCodeList = ordSrv.GetProjectList();
            }

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("프로젝트코드", "Prj_No", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("프로젝트명", "Prj_Name", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("거래처명", "Company_Name", 200));

            CommonPop<ProjectDTO> popInfo = new CommonPop<ProjectDTO>();
            popInfo.DgvDatasource = projectCodeList;
            popInfo.DgvCols = colList;
            popInfo.PopName = "프로젝트 검색";

            return popInfo;
        }

        private CommonPop<ItemDTO> GetPopInfo_Item()
        {
            if (itemCodeList == null || itemCodeList.Count() < 1)
            {
                itemCodeList = ordSrv.GetItemCodeName();
            }

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            CommonPop<ItemDTO> popInfo = new CommonPop<ItemDTO>();
            popInfo.DgvDatasource = itemCodeList;
            popInfo.DgvCols = colList;
            popInfo.PopName = "품목 검색";

            return popInfo;
        }

        private void OpenPop<T>(CommonPop<T> popInfo) where T : class, new()
        {
            frmPop pop = new frmPop();
            pop.PopLoadData<T>(popInfo);

            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                dgvOrder[popInfo.DgvCols[0].DataPropertyName, idx].Value = pop.SelCode;
                dgvOrder[popInfo.DgvCols[1].DataPropertyName, idx].Value = pop.SelName;
                if(popInfo.DgvCols.Count > 2)
                    dgvOrder[popInfo.DgvCols[2].DataPropertyName, idx].Value = pop.SelEtc;
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stat == 0)
                idx = e.RowIndex;
        }

        private void dgvOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= CheckNumberOnly;

            if (dgvOrder.CurrentCell.ColumnIndex == 9)
            {
                e.Control.KeyPress += CheckNumberOnly;
            }
        }

        private void CheckNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
