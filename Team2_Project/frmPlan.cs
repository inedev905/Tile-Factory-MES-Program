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
    public partial class frmPlan : Form
    {
        PlanService srv = new PlanService();

        frmPop pop;
        CommonPop<WorkCenterDTO> wcCodePop;
        CommonPop<ItemDTO> itemCodePop;

        DataTable ReqDt;
        DataTable planDt;

        public frmPlan()
        {
            InitializeComponent();
        }

        private void frmPlan_Load(object sender, EventArgs e)
        {
            //생산요청 tab
            DataGridViewUtil.SetInitDataGridView(dgvReq);
            DataGridViewCheckBoxColumn cbk = new DataGridViewCheckBoxColumn();
            cbk.Width = 30;
            cbk.DefaultCellStyle.BackColor = Color.PeachPuff;
            cbk.Frozen = true;
            dgvReq.Columns.Add(cbk);

            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "생산요청번호", "Prd_Req_No", 150, frosen:true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "의뢰일", "Req_Date", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "순번", "Req_Seq", 60, DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "납기일자", "Delivery_Date", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장코드", "Wc_Code", OrangebackColor: true); //입력값
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "작업장명", "Wc_Name", 150, OrangebackColor: true); //입력값
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "품목", "Item_Name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "계획수량", "In_Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight, OrangebackColor: true); //계획 수량(입력값)
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "계획반영수량", "Plan_Qty", 120, DataGridViewContentAlignment.MiddleRight); //계획 수량 합계
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "요청수량/잔량", "Plan_Rest_Qty", 120, DataGridViewContentAlignment.MiddleRight); //요청수량(Req) - 계획반영수량(Plan_Qty)
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "Plan_YN", "Plan_YN", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReq, "Item_Code", "Item_Code", visible: false);

            CommonCodeUtil.UseYNComboBinding(cboReqStat);

            //생산요청 tab
            DataGridViewUtil.SetInitDataGridView(dgvWcPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "작업장코드", "Wc_Code");
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "작업장명", "Wc_Name");
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "계획반영수량", "Plan_Qty", align: DataGridViewContentAlignment.MiddleRight); //작업장별 합계
            DataGridViewUtil.AddGridTextBoxColumn(dgvWcPlan, "계획수량", "In_Plan_Qty", align: DataGridViewContentAlignment.MiddleRight); //작업장별 합계

            //생산계획 tab
            DataGridViewUtil.SetInitDataGridView(dgvPlan);

            tab1SetInit();
            tab1LoadData();
        }

        #region tabPage1 (생산요청tab)
        private void tab1LoadData()
        {
            ReqDt = srv.GetPlanReq(dtpReqFrom.Value.ToShortDateString(), dtpReqTo.Value.ToShortDateString());
            dgvReq.DataSource = ReqDt;

            DgvWcPlanBinding(ReqDt);
        }

        private void tab1SetInit()
        {
            dtpReqFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpReqTo.Value = dtpReqFrom.Value.AddMonths(1).AddDays(-1);
            dtpDue.Format = DateTimePickerFormat.Custom;
            dtpDue.CustomFormat = " ";

            ucProd._Code = ucProd._Name = "";
            cboReqStat.SelectedIndex = 0;
        }

        private void DgvWcPlanBinding(DataTable dt)
        {
            var SortTable = (from row in dt.AsEnumerable()
                             group row by new
                             {
                                 Wc_Code = row.Field<string>("Wc_Code"),
                                 Wc_Name = row.Field<string>("Wc_Name")
                             } into g
                             where g.Key.Wc_Code != null
                             select new
                             {
                                 Wc_Code = g.Key.Wc_Code,
                                 Wc_Name = g.Key.Wc_Name,
                                 In_Plan_Qty = g.Sum((c) => c.Field<int>("In_Plan_Qty")),
                                 Plan_Qty = g.Sum((c) => c.Field<int>("Plan_Qty"))
                             }).ToList();

            if (SortTable.Count > 0)
            {
                dgvWcPlan.DataSource = SortTable;
            }
        }

        private void ucProd_BtnClick(object sender, EventArgs e)
        {
            if (itemCodePop == null)
            {
                itemCodePop = new CommonPop<ItemDTO>();
                ItemService srv = new ItemService();

                itemCodePop.DgvDatasource = srv.GetItemCodeName();
                itemCodePop.PopName = "품목 검색";
            }

            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목코드", "Item_Code", 200));
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("품목명", "Item_Name", 200));

            itemCodePop.DgvCols = colList;
            ucProd.OpenPop(itemCodePop);
        }


        private void dgvReq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            int rIdx = e.RowIndex;

            if (e.ColumnIndex == dgvReq.Columns["Wc_Code"].Index || e.ColumnIndex == dgvReq.Columns["Wc_Name"].Index)
            {
                if(wcCodePop == null)
                {
                    pop = new frmPop();
                    wcCodePop = new CommonPop<WorkCenterDTO>();
                    WorkCenterService srv = new WorkCenterService();

                    wcCodePop.DgvDatasource = srv.GetWcCodeName();
                    wcCodePop.PopName = "작업장 검색";

                    List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
                    colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장코드", "Wc_Code", 200));
                    colList.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장명", "Wc_Name", 200));

                    wcCodePop.DgvCols = colList;

                    pop.PopLoadData<WorkCenterDTO>(wcCodePop);
                }

                if (pop.ShowDialog() == DialogResult.OK)
                {
                    dgvReq[wcCodePop.DgvCols[0].DataPropertyName, rIdx].Value = pop.SelCode;
                    dgvReq[wcCodePop.DgvCols[1].DataPropertyName, rIdx].Value = pop.SelName;
                }
            }

            if (e.ColumnIndex == dgvReq.Columns["In_Plan_Qty"].Index)
            {
                dgvReq[e.ColumnIndex, rIdx].ReadOnly = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<PlanDTO> plan = new List<PlanDTO>();

            foreach (DataGridViewRow row in dgvReq.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (row.Cells["Plan_Rest_Qty"].Value.ToString().Equals("0"))
                    {
                        MessageBox.Show("계획 잔량이 0입니다.");
                        return;
                    }

                    if (row.Cells["In_Plan_Qty"].Value == null || Convert.ToInt32(row.Cells["In_Plan_Qty"].Value) == 0)
                    {
                        MessageBox.Show("계획 수량을 입력해주세요.");
                        return;
                    }

                    plan.Add(new PlanDTO
                    {
                        Prd_Req_No = dgvReq["Prd_Req_No", row.Index].Value.ToString(),
                        Item_Code = dgvReq["Item_Code", row.Index].Value.ToString(),
                        Plan_Qty = Convert.ToInt32(dgvReq["In_Plan_Qty", row.Index].Value),
                        Plan_Rest_Qty = Convert.ToInt32(dgvReq["Plan_Rest_Qty", row.Index].Value) - Convert.ToInt32(dgvReq["In_Plan_Qty", row.Index].Value),
                        Wc_Code = dgvReq["Wc_Code", row.Index].Value.ToString(),
                        Ins_Emp = ((frmMain)this.MdiParent).LoginEmp.User_ID
                    });
                }
            }

            if (plan.Count < 1)
            {
                MessageBox.Show("생산계획을 생성할 항목을 선택하여 주십시오.");
                return;
            }

            bool result = srv.InsertPlan(plan);
            if (result)
            {
                MessageBox.Show("계획생성이 완료되었습니다.");
                tab1LoadData();
            }
            else
            {
                MessageBox.Show("계획생성 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }
        }


        //데이터그리드뷰 숫자만 입력 가능하게
        private void dgvReq_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string colName = dgvReq.CurrentCell.OwningColumn.Name;

            if (colName == "In_Plan_Qty")
                e.Control.KeyPress += CheckIsNum;
            else
                e.Control.KeyPress -= CheckIsNum;
        }

        private void CheckIsNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgvReq_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvReq.Columns["In_Plan_Qty"].ReadOnly = true;

            if (e.ColumnIndex == dgvReq.Columns["In_Plan_Qty"].Index)
            {
                DataTable newDt = (DataTable)dgvReq.DataSource;
                DgvWcPlanBinding(newDt);
            }
        }

        #endregion



        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            if (tabControl1.TabIndex == 0)
            {
                DateTime fromDt = dtpReqFrom.Value;
                DateTime toDt = dtpReqTo.Value;

                string dueDt = (dtpDue.Format == DateTimePickerFormat.Custom) ? null : dtpDue.Value.ToShortDateString();
                string itemCode = ucProd._Code;
                string planYN = (cboReqStat.SelectedItem.ToString() == "전체")? "" : cboReqStat.SelectedItem.ToString();


                var filter = from row in ReqDt.AsEnumerable()
                             where row.Field<DateTime>("Req_Date") >= fromDt
                                  && row.Field<DateTime>("Req_Date") <= toDt
                                  && row.Field<string>("Item_Code").Contains(itemCode)
                                  && row.Field<string>("Plan_YN").Contains(planYN)
                             select row;

                if (filter.Count() > 0 && dueDt != null)
                {
                    filter = from row in filter
                             where row.Field<DateTime>("Delivery_Date") == Convert.ToDateTime(dueDt)
                             select row;                                            
                }

                if (filter.Count() < 1)
                {
                    dgvReq.DataSource = null;
                    return;
                }

                dgvReq.DataSource = filter.CopyToDataTable();
            }
        }

        public void OnAdd()     //추가
        {
            if (tabControl1.TabIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
            }
        }

        public void OnEdit()    //수정
        {
            if (tabControl1.TabIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
            }
        }

        public void OnDelete()  //삭제
        {
            if (tabControl1.TabIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
            }
        }

        public void OnSave()    //저장
        {
            if (tabControl1.TabIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
            }
        }

        public void OnCancel()  //취소
        {
            if (tabControl1.TabIndex == 0)
            {
                ((frmMain)this.MdiParent).BtnEditReturn(true);
            }

        }

        public void OnReLoad()  //새로고침
        {
            if (tabControl1.TabIndex == 0)
            {
                tab1SetInit();
                tab1LoadData();
            }
        }

        #endregion

        private void dtpDue_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDue.Format == DateTimePickerFormat.Custom)
            {
                dtpDue.Format = DateTimePickerFormat.Short;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && planDt == null)
            {

            }
        }
    }
}
