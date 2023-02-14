using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_DTO;
using Team2_Project.BaseForms;
using Team2_Project.Utils;
using Team2_Project.Services;

namespace Team2_Project
{
    public partial class frmChangePassword : Form
    {
        EmployeeDTO loginInfo;
        EmployeeService srv = new EmployeeService();
        string id = null;
        string pw = null;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            
            loginInfo = ((frmSettings)this.MdiParent).LoginEmp;
            btnCheck.ImageIndex = 0;
            txtNewPW.Enabled = txtCheckNewPW.Enabled = false;
            id = loginInfo.User_ID;
            pw = loginInfo.UserPW;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCheckPwd.Text))
            {
                MessageBox.Show("기존 비밀번호를 입력해주시기 바랍니다.");
                return;
            }
            string curID = id;
            string curPW = txtCheckPwd.Text;
            bool result = srv.CheckUserpW(curID, curPW);
            if (!result)
            {
                MessageBox.Show("비밀번호가 틀렸습니다. 다시시도하여 주세요.");
                return;
            }

            btnCheck.ImageIndex = 1;
            txtNewPW.Enabled = txtCheckNewPW.Enabled = true;
            txtCheckPwd.ReadOnly = true;

        }

        public void SettingSave()   //저장 버튼 클릭시 
        {
            if (string.IsNullOrWhiteSpace(txtCheckPwd.Text) ||
                string.IsNullOrWhiteSpace(txtNewPW.Text) ||
                string.IsNullOrWhiteSpace(txtCheckNewPW.Text))
            {
                MessageBox.Show("모든 항목을 입력해주세요.");
                return;
            }
            if (txtNewPW.Text != txtCheckNewPW.Text)
            {
                MessageBox.Show("신규 비밀번호와 신규 비밀번호확인 값이 틀립니다. 다시 입력하세요.");
                return;
            }
            else
            {
                string curID = id;
                string curPW = txtNewPW.Text;
                bool result = srv.UpdatePW(curID, curPW);
                if (result)
                {
                    MessageBox.Show("비밀번호 변경이 완료되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //SettingCancel();
                }
                else
                {
                    MessageBox.Show("비밀번호 변경 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
            }
        }

        public void SettingCancel() //취소 버튼 클릭시 
        {
            txtCheckPwd.ReadOnly = false;
            txtCheckPwd.Text = txtNewPW.Text = txtCheckNewPW.Text = "";
            btnCheck.ImageIndex = 0;
            txtNewPW.Enabled = txtCheckNewPW.Enabled = false;
        }
    
    }
}
