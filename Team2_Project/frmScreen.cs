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
using Team2_Project.Utils;

namespace Team2_Project
{
    public partial class frmScreen : frmListUpAreaDown
    {
        public frmScreen()
        {
            InitializeComponent();
        }

        private void frmScreen_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dataGridView1);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "화면코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "화면명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "사용유무", "", 200);
        }
    }
}
