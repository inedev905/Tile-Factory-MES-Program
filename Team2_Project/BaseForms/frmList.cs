using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project
{
    public partial class frmList : Form
    {
        public string TITleMain { get; set; }

        
        public frmList()
        {
            InitializeComponent();
            lblTitle.Text = TITleMain;
        }

        private void frmList_Load(object sender, EventArgs e)
        {
          
        }
    }
}
