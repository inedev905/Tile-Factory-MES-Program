using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtID.Text = "1000";
            txtPwd.Text = "1000";
            chkViewPW.ImageIndex = 0;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtPwd.Text))
                {
                    MessageBox.Show("ID와 비밀번호를 입력해주세요.");
                    return;
                }
                string userID = txtID.Text.Trim();
                string userPW = txtPwd.Text.Trim();
                EmployeeService srv = new EmployeeService();
                EmployeeDTO empInfo = srv.GetLoginEmp(userID, userPW);

                if (empInfo == null)
                {
                    MessageBox.Show("정보가 올바르지 않습니다. 다시 시도하여 주세요.");
                }
                else
                {
                    ((frmMain)this.Owner).LoginEmp = empInfo;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void chkViewPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewPW.Checked)
            {
                chkViewPW.ImageIndex = 1;
                txtPwd.PasswordChar = default;

            }
            else
            {
                chkViewPW.ImageIndex = 0;
                txtPwd.PasswordChar = '*';
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPwd.Text = "";
        }
    }
}
