using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team2_Project
{
    public partial class frmStartMain : Team2_Project.frmTheCross
    {
        public event EventHandler BtnClick;
        public frmStartMain()
        {
            InitializeComponent();
        }

        public void test()
        {
            MessageBox.Show("fds");
        }
    }
}
