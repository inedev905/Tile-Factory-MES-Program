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

namespace Team2_Project_POP
{
    public partial class frmParent : Form
    {
        public WorkCenterDTO LoginedWorkCenter { get; set; }
        public frmParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            menuStrip1.Hide();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            frmSelect frm = new frmSelect();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //MDI메뉴와 Child메뉴가 합쳐질때 발생하는 이벤트
            //최소화(&N) 이전 크기로(&R)  닫기(&C) ""
            //if (e.Item.Text == "" ||
            //    e.Item.Text == "최소화(&N)" ||
            //    e.Item.Text == "이전 크기로(&R)" ||
            //    e.Item.Text == "닫기(&C)")
            //    e.Item.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
