using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.Controls;
using System.Reflection;
using Team2_Project_DTO;
using Team2_Project.Utils;
using Team2_Project.Services;

namespace Team2_Project
{
    public partial class frmMain : Form
    {
        #region 유효성체크 실패 시 넣어줘야하는 버튼 이벤트 (!!!!!!!!필수!!!!!!!!)
        // 유효성 체크 후 return 값 주기 전에 이벤트 넣어주시면 됩니다. 
        // OnSave() 버튼 이벤트에서만 사용
        // 예시)
        // MessageBox.Show($"{lblGroupCode.Text} 항목을 입력해주시기 바랍니다.");
        //            if (clickState == "각 폼에서 clickstate를 '추가'로 정의해준 문자열 혹은 숫자 적어주시면됩니다")
        //            {
        //                ((frmMain)this.MdiParent).AddClickEvent();
        //            }
        //            else if (clickState == "각 폼에서 clickstate를 '수정'으로 정의해준 문자열 혹은 숫자 적어주시면됩니다")
        //            {
        //                ((frmMain)this.MdiParent).EditClickEvent();
        //            }
        //  return;
        #endregion

        public EmployeeDTO LoginEmp { get; set; }
        
        //public event EventHandler BtnClick;

        private Boolean showPanelTreenode1 = false;
        private Boolean showPanelTreenode2 = false;
        private Boolean showPanelTreenode3 = false;
        private Boolean showPanelTreenode4 = false;
        const int MaxWidth = 212;
        const int MinWidth = 56;
        Panel pnlChildMenu = new Panel();
        public string curP_MenuID { get; set; }
        public frmMain()
        {
            InitializeComponent();

            tooglepanels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            frmLogin login = new frmLogin();
            if (login.ShowDialog(this) != DialogResult.OK)
            {
                this.Close();
                return;
            }
            this.Visible = true;
            tStripDate.Text = DateTime.Now.ToShortDateString();
            tStripTime.Text = DateTime.Now.ToShortTimeString();
            tStripName.Text = LoginEmp.User_Name;
            tStripDept.Text = LoginEmp.UserGroup_Name;
            RoadClickEvent();
            OpenChildPage<frmDashBoard>();
            
        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked)
            {
                panel2.Width = MinWidth;
                pnlMenu.Width = MinWidth;
                pnlChildMenu.Visible = false;
                chkHide.Text = ">";
            }
            else
            {
                panel2.Width = MaxWidth;
                pnlMenu.Width = MaxWidth;
                pnlChildMenu.Visible = false;
                chkHide.Text = "<";
            }
        }

        private void OpenChildPage<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    form.BringToFront();

                    return;
                }
            }
            T frm = new T();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        } //자식폼 Open 이벤트 

        #region 왼쪽버튼 수정 예정
        private void tooglepanels()
        {
            if (showPanelTreenode1)
            {
                pnltreenode1.Height = 188;
                treeView1.ExpandAll();
            }
            else
            {
                pnltreenode1.Height = 0;
            }

            if (showPanelTreenode2)
            {
                pnltreenode2.Height = 336;
                treeView2.ExpandAll();
            }
            else
            {
                pnltreenode2.Height = 0;
            }

            if (showPanelTreenode3)
            {
                pnltreenode3.Height = 247;
                treeView3.ExpandAll();
            }
            else
            {
                pnltreenode3.Height = 0;
            }

            if (showPanelTreenode4)
            {
                pnltreenode4.Height = 100;
                treeView4.ExpandAll();
            }
            else
            {
                pnltreenode4.Height = 0;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
        private void btnsystem_Click(object sender, EventArgs e)
        {
            showPanelTreenode1 = !showPanelTreenode1;

            tooglepanels();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            showPanelTreenode2 = !showPanelTreenode2;

            tooglepanels();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            showPanelTreenode3 = !showPanelTreenode3;

            tooglepanels();
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
            showPanelTreenode4 = !showPanelTreenode4;

            tooglepanels();
        }
        #endregion

        #region 왼쪽 treeview 수정예정
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "사용자 그룹코드")
            {
                OpenChildPage<frmUserGroupCode>();
            }
            else if (e.Node.Text == "사용자 권한설정")
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else if (e.Node.Text == "사용자 관리")
            {
                OpenChildPage<frmEmpManagement>();
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "공정정보")
            {
                OpenChildPage<frmProcessManagement>();
            }
            else if (e.Node.Text == "작업장정보")
            {
                OpenChildPage<frmWorkCenter>();
            }
            else if (e.Node.Text == "품목정보")
            {
                OpenChildPage<frmItem>();
            }
            else if (e.Node.Text == "사용자 정의 관리")
            {
                OpenChildPage<frmUserCode>();
            }
            else if (e.Node.Text == "불량현상 대분류코드")
            {
                OpenChildPage<frmDefectCode>();
            }
            else if (e.Node.Text == "불량현상 상세분류코드")
            {
                OpenChildPage<frmDefectCodeDetail>();
            }
            else if (e.Node.Text == "비가동 대분류코드")
            {
                OpenChildPage<frmNopMaCode>();
            }
            else if (e.Node.Text == "비가동 상세분류코드")
            {
                OpenChildPage<frmNopMiCode>();
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }

        private void treeView3_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "작업지시 생성 및 마감")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else if (e.Node.Text == "시간대별 실적 조회")
            {
                OpenChildPage<frmTimeProductionHistory>();
            }
            else if (e.Node.Text == "작업지시 현황")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else if (e.Node.Text == "비가동 내역")
            {
                OpenChildPage<frmNop>();
            }
            else if (e.Node.Text == "일별 생산 현황")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }

        private void treeView4_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curP_MenuID = e.Node.Text.ToString();
            if (e.Node.Text == "생산요청 관리")
            {
                OpenChildPage<frmOrder>();
            }
            else if (e.Node.Text == "생산계획 관리")
            {
                OpenChildPage<frmPlan>();
            }
            else if (e.Node.Text == "시유 작업지시 생성")
            {
                //OpenGMMainPage<>();
                MessageBox.Show("빈 생성 화면입니다.");
            }
            else
            {
                MessageBox.Show("빈 생성 화면입니다.");
            }
        }
        #endregion
        private void OpenCreateForm(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                tabControl1.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

                if (this.ActiveMdiChild.Tag == null) //신규로 탭을 생성하는 경우
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "    ");
                    tabControl1.TabPages.Add(tp);

                    //tp.Tag = this.ActiveMdiChild;
                    tp.Tag = new TabTag { ActiveOpenForm = this.ActiveMdiChild, MenuID = curP_MenuID };
                    this.ActiveMdiChild.Tag = tp;

                    tabControl1.SelectedTab = tp;

                    //자식폼이 닫힐때 탭페이지도 같이 삭제
                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
                }
                else //기존에 탭이 있는 경우
                {
                    tabControl1.SelectedTab = (TabPage)this.ActiveMdiChild.Tag;
                }

                //화면당 조회, 저장, 출력여부를 메뉴테이블을 참고해서 버튼 비활성화 여부 코딩


                if (!tabControl1.Visible)
                {
                    tabControl1.Visible = true;
                }
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            ((TabPage)frm.Tag).Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                Form frm = ((TabTag)tabControl1.SelectedTab.Tag).ActiveOpenForm;
                frm.Select();
            }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                var r = tabControl1.GetTabRect(i);
                var closeImage = Properties.Resources.close_grey;
                var closeRect = new Rectangle((r.Right - closeImage.Width), r.Top + (r.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (closeRect.Contains(e.Location))
                {
                    this.ActiveMdiChild.Close();
                    break;
                }
            }
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //MDI메뉴와 Child메뉴가 합쳐질때 발생하는 이벤트
            //최소화(&N) 이전 크기로(&R)  닫기(&C) ""
            if (e.Item.Text == "" ||
                e.Item.Text == "최소화(&N)" ||
                e.Item.Text == "이전 크기로(&R)" ||
                e.Item.Text == "닫기(&C)")
                e.Item.Visible = false;
        }

        void Function_Invoke(string funcName)
        {
            try
            {
                Type frmType = this.ActiveMdiChild.GetType();

                MethodInfo btnEventHandlerCall = frmType.GetMethod(funcName, BindingFlags.Instance | BindingFlags.Public);

                if (btnEventHandlerCall != null)
                {
                    if (funcName == "OnAdd")
                    {
                        AddClickEvent();
                    }
                    else if (funcName == "OnEdit")
                    {
                        EditClickEvent();
                    }
                    else if (funcName == "OnSave" || funcName == "OnCancel")
                    {
                        SaveOrCancelClickEvent();
                    }
                    btnEventHandlerCall.Invoke(this.ActiveMdiChild, null);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("자식폼 이벤트핸들러 미구현");
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form d = this.ActiveMdiChild;
        //    OpenChildPage<frmStartMain>();
        //    Button btn = (Button)sender;
        //    if (this.BtnClick != null)
        //    {
        //        btn.Tag = btn.Name;
        //        BtnClick(btn, e);
        //    }    
        //}

        #region 버튼 클릭 이벤트
        public void RoadClickEvent()
        {
            btnSave.Enabled = btnCancel.Enabled = false;
            btnSave.BackColor = btnCancel.BackColor = Color.DarkGray;
        }
        public void AddClickEvent() //추가 버튼 클릭시
        {
            btnAdd.BackColor = Color.White;            
            btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true;
            btnSearch.BackColor = btnEdit.BackColor = btnDelete.BackColor = btnReLoad.BackColor = Color.DarkGray;
            btnSave.BackColor = btnCancel.BackColor = Color.FromArgb(211, 226, 223);
        }
        public void EditClickEvent() // 수정 버튼 클릭시 
        {
            btnEdit.BackColor = Color.White;
            btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true;
            btnSearch.BackColor = btnAdd.BackColor = btnDelete.BackColor = btnReLoad.BackColor = Color.DarkGray;
            btnSave.BackColor = btnCancel.BackColor = Color.FromArgb(211, 226, 223);
        }
        void SaveOrCancelClickEvent()   //저장 or 취소 버튼 클릭시  
        {
            if (btnSearch.Enabled == false &&
                btnAdd.Enabled == false &&
                btnEdit.Enabled == false &&
                btnDelete.Enabled == false &&
                btnReLoad.Enabled == false &&
                btnAdd.BackColor == Color.White ||
                btnEdit.BackColor == Color.White
                )
            {
                btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = true;
                btnAdd.BackColor = btnEdit.BackColor = btnSearch.BackColor =  btnDelete.BackColor = btnReLoad.BackColor = Color.FromArgb(211, 226, 223);
                RoadClickEvent();
            }
        }
        public void BtnEditReturn(bool bactive) //셀 선택없이 수정버튼 클릭시 값 초기화 이벤트
        {
            btnSearch.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReLoad.Enabled = bactive;
            btnAdd.BackColor = btnEdit.BackColor = btnSearch.BackColor = btnDelete.BackColor = btnReLoad.BackColor = Color.FromArgb(211, 226, 223);
            RoadClickEvent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnSearch");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnAdd");         
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnEdit");          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnDelete");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnSave");           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnCancel");            
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Function_Invoke("OnReLoad");
        }
        #endregion

        private void tsBtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void tsBtnSetting_Click(object sender, EventArgs e)
        {
            frmSettings pop = new frmSettings();
            pop.ShowDialog(this);
        }
    }
    class TabTag
    {
        public Form ActiveOpenForm { get; set; }
        public string MenuID { get; set; }
    }
}
