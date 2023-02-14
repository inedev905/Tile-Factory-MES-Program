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
using Team2_Project_DTO;

namespace Team2_Project.Controls
{
    public partial class ucSearch : UserControl
    {
        public event EventHandler BtnClick;

        public string _Code { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string _Name {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public ucSearch()
        {
            InitializeComponent();
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            if (BtnClick != null)
                BtnClick(this, e);
        }

        /// <summary>
        /// 돋보기 아이콘 클릭 시 사용하는 메서드 (pop 창 열기)
        /// BtnClick 이벤트핸들러 구현 부분에 호출해서 사용할 것
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="popInfo"></param> => CodeDTO의 CommonPop Class 주석 참고
        public void OpenPop<T>(CommonPop<T> popInfo) where T : class, new()
        {
            frmPop pop = new frmPop();
            pop.PopLoadData<T>(popInfo);

            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                textBox1.Text = pop.SelCode;
                textBox2.Text = pop.SelName;
            }
        }


        #region OpenPop() 메서드 사용 예시
        /*
        private void ucSearch_BtnClick(object sender, EventArgs e)
        {
            //pop dgv에 binding할 datasource
            var list = codeList.GroupBy((g) => g.Userdefine_Ma_Code).Select((g) => g.FirstOrDefault()).ToList();

            //pop dgv 컬럼 생성 (생성 시 주의사항 *** 컬럼 순서는 (1) 코드 => (2) 이름 순으로 할 것)
            //코드, 이름 외 추가 필요한 컬럼은 이름 뒤로 추가 가능
            List<DataGridViewTextBoxColumn> colList = new List<DataGridViewTextBoxColumn>();
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("대분류코드", "Userdefine_Ma_Code", 200));   //(1) 첫번째 컬럼 => 코드
            colList.Add(DataGridViewUtil.ReturnNewDgvColumn("대분류명", "Userdefine_Ma_Name", 200));    //(2) 두번째 컬럼 => 이름

            //Commonpop class로 전달
            CommonPop<UserCodeDTO> popInfo = new CommonPop<UserCodeDTO>();
            popInfo.DgvDatasource = list;
            popInfo.DgvCols = colList;
            popInfo.PopName = "대분류코드 검색";

            ucSearchCode.OpenPop(popInfo);
        }
        */
        #endregion

    }

}
