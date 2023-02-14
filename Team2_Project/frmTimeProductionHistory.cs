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
using System.Windows.Forms.DataVisualization.Charting;

namespace Team2_Project
{
    public partial class frmTimeProductionHistory : Team2_Project.frmList
    {
        AnalysisService srv = new AnalysisService();
        List<TimeProductionHistoryDTO> TPHistoryList = new List<TimeProductionHistoryDTO>();

        public frmTimeProductionHistory()
        {
            InitializeComponent();
        }

        private void frmTimeProductionHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            cboWoStatus.Items.Add("전체");
            cboWoStatus.Items.Add("생산대기");
            cboWoStatus.Items.Add("생산중");
            cboWoStatus.Items.Add("생산중지");
            cboWoStatus.Items.Add("현장마감");
            cboWoStatus.Items.Add("작업지시마감"); //추후 DB에서 CODE 가져오기
            cboWoStatus.SelectedIndex = 0;
            cboWoStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            //작업지시목록 : 작업지시번호, 작업지시일자, 작업지시수량, 계획수량단위, 품목코드, 품목명, 작업장, 생산일자, 생산시작, 생산종료, 투입, 산출, 생산수량, 불량수량
            DataGridViewUtil.SetInitDataGridView(dgvData);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시번호", "Wo_Status", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시번호", "WorkOrderNo", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시일자", "Ins_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업지시수량", "Plan_Qty_Box", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "계획수량단위", "Plan_Unit", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목코드", "Item_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "품목명", "Item_Name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산일자", "Prd_Date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산시작", "Prd_StartTime", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산종료", "Prd_EndTime", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "투입수량", "In_Qty_Main", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "산출수량", "Out_Qty_Main", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "생산수량", "Prd_Qty", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "불량수량", "Def_Qty", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "작업장코드", "Wc_Code", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvData, "시작시간대", "Start_Hour", 150, visible:false);
            dgvData.MultiSelect = false;

            OnSearch();            
        }

        private void AdvancedListBind(List<TimeProductionHistoryDTO> datasource, DataGridView dgv)
        {
            BindingSource bs = new BindingSource(new AdvancedList<TimeProductionHistoryDTO>(datasource), null);
            dgv.DataSource = null;
            dgv.DataSource = bs;
        }

        #region Main 버튼 클릭이벤트
        public void OnSearch()  //검색 
        {
            TPHistoryList = srv.GetWorkOrder(dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));

            if (TPHistoryList != null && TPHistoryList.Count > 0)
            {
                //var list = TPHistoryList.GroupBy((n) => n.Nop_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();
                AdvancedListBind(TPHistoryList, dgvData);
            }

            ChartData(); /////////// CHART TEST
        }

        public void OnReLoad()  //새로고침
        {
            ResetTop();//검색리셋
            OnSearch();//로드
        }
        #endregion

        private void ResetTop() //검색 리셋
        {
            ResetDtp();
            cboWoStatus.SelectedIndex = 0;
            ucProcessCode._Code = ucProcessCode._Name = "";
            ucWcCode._Code = ucProcessCode._Name = "";
            chkDefQty.Checked = false;
        }

        private void ResetDtp() //날짜리셋
        {
            dtpFrom.Value = DateTime.Now.AddDays(-7);
            dtpTo.Value = DateTime.Now;
        }

        private void ucProcessCode_BtnClick(object sender, EventArgs e)
        {
            if (TPHistoryList == null || TPHistoryList.Count() < 1) return;

                //var list = (from g in TPHistoryList
                //            group g by g.Process_Code ).ToList();
                var list = TPHistoryList.GroupBy((g) => g.Process_Code).Select((g) => g.FirstOrDefault()).ToList();

            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("공정코드", "Process_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("공정명", "Process_Name", 200));

            CommonPop<TimeProductionHistoryDTO> dto = new CommonPop<TimeProductionHistoryDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "공정정보 검색";
            ucProcessCode.OpenPop(dto);
        }

        private void ucWcCode_BtnClick(object sender, EventArgs e)
        {
            if (TPHistoryList == null || TPHistoryList.Count() < 1) return;

            var list = TPHistoryList.GroupBy((g) => g.Wc_Code).Select((g) => g.FirstOrDefault()).ToList();
            List<DataGridViewTextBoxColumn> col = new List<DataGridViewTextBoxColumn>();
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장코드", "Wc_Code", 200));
            col.Add(DataGridViewUtil.ReturnNewDgvColumn("작업장명", "Wc_Name", 200));

            CommonPop<TimeProductionHistoryDTO> dto = new CommonPop<TimeProductionHistoryDTO>();
            dto.DgvDatasource = list;
            dto.DgvCols = col;
            dto.PopName = "작업장정보 검색";
            ucWcCode.OpenPop(dto);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. 조회조건으로 검색하면  (DB에서 List<작업지시테이블기반>가져와서)   dgv가 뜸 
            //2. 작업지시 dgv를 선택하면 작업지시번호 DB가져가서 (DB에서 List<시간대별실적조회>가져와서)    chart에 반영





        }


        public void ChartData()
        {
            TPHistoryList = srv.GetTimeProductionHistory();

            chtData.Series.Clear();
            chtData.Series.Add("생산량");
            chtData.Series["생산량"].Points.Clear();            
            chtData.Series["생산량"].ChartType = SeriesChartType.StackedColumn;          
            chtData.Series["생산량"].Color = Color.FromArgb(211, 226, 223);
            chtData.Series["생산량"].Points.DataBind(TPHistoryList, "Start_Hour", "Prd_Qty", null); // X축: 시간, Y축:  생산량    //Prd_Qty //Def_Qty

            if (!chkDefQty.Checked)
            {
                chtData.Series.Add("불량");
                chtData.Series["불량"].Points.Clear();
                chtData.Series["불량"].ChartType = SeriesChartType.StackedColumn;
                chtData.Series["불량"].Color = Color.FromArgb(255, 217, 217);
                chtData.Series["불량"].Points.DataBind(TPHistoryList, "Start_Hour", "Def_Qty", null); // X축: Time, Y축: Score
            }

            #region test
            //(방법2)//////////////////

            //chtData.Series["Series1"].Points.AddXY(10, 100);
            //chtData.Series["Series1"].Points.AddXY(20, 200);
            //chtData.Series["Series1"].Points.AddXY(30, 300);
            //chtData.Series["Series1"].Points.AddXY(40, 400);

            //List<string> x = new List<string> { "철수", "영희", "길동", "재동", "민희" };
            //List<double> y = new List<double> { 80, 90, 85, 70, 95 };
            //chtData.Series[0].Points.DataBindXY(x, y);




            //(방법3)//////////////////
            //List<Student> students = new List<Student>();
            //for (int i = 8; i <= 24; i++)
            //{
            //    students.Add(new Student($"{i}시", i * 100));
            //}
            //chtData.Series[0].Points.DataBind(students, "Time", "Score", null); // X축: Time, Y축: Score
            //                                                                    // (참고) DataBindTable() 사용시. (X축: Time, Y축: 자동검색)
            //                                                                    //chtData.DataBindTable(students, "Time");
            #endregion
        }
    }
}
