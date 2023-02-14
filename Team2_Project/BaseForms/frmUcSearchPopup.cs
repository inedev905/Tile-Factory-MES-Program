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

namespace Team2_Project.BaseForms
{
    public partial class frmUcSearchPopup : Form
    {
        List<CodeDTO> list;
        string category = null;

        public string Code { get; set; }
        public string Name { get; set; }

        public frmUcSearchPopup()
        {
            InitializeComponent();
        }

        private void frmucSearchPopup_Load(object sender, EventArgs e)
        {
            
        }
    }
}
