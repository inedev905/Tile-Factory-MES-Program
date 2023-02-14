using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project_POP
{
    public partial class frmProductionList : Form
    {
        public frmProductionList()
        {
            InitializeComponent();
        }

        private void frmProductionList_Load(object sender, EventArgs e)
        {
            lblProductionLine.Location = new Point(panel1.Width / 2 - 120, panel1.Height / 2 - 30);
        }
    }
}
