using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmSettings : Form
    {
        public EmployeeDTO LoginEmp { get; set; }
        frmChangePassword frmChPwd = null;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.LoginEmp = ((frmMain)this.Owner).LoginEmp;
            btnChanPwd.PerformClick();
        }

        private void OpenSettingPage<T>() where T : Form, new()
        {
            //열려있는 폼을 닫고, 새로 연다.
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
        }


        private void btnChanPwd_Click(object sender, EventArgs e)
        {
            btnChanPwd.Enabled = false;
            btnChanPwd.BackColor = Color.White;
            btnDashboard.BackColor = Color.FromArgb(211, 226, 223);
            OpenSettingPage<frmChangePassword>();

            //if (frmChPwd == null)
            //{
            //    frmChPwd = new frmChangePassword();
            //    DialogResult result = frmChPwd.ShowDialog(this);
            //    if (result == DialogResult.OK)
            //    {
            //        btnChanPwd.Enabled = true;
            //        frmChPwd = null;
            //    }
            //}
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {           
            btnDashboard.BackColor = Color.White;
            btnChanPwd.BackColor = Color.FromArgb(211, 226, 223);
            //OpenSettingPage<>();  대쉬보드 폼 생성시 <> 안에 폼이름 넣기 
        }
        

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "" ||
                e.Item.Text == "최소화(&N)" ||
                e.Item.Text == "이전 크기로(&R)" ||
                e.Item.Text == "닫기(&C)")
                e.Item.Visible = false;
        }

        void Function_Invoke2(string funcName)
        {
            try
            {
                Type frmType = this.ActiveMdiChild.GetType();

                MethodInfo btnEventHandlerCall = frmType.GetMethod(funcName, BindingFlags.Instance | BindingFlags.Public);

                if (btnEventHandlerCall != null)
                {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Function_Invoke2("SettingSave");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Function_Invoke2("SettingCancel");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
