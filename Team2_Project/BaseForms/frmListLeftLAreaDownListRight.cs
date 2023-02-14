using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project.BaseForms
{
    public partial class frmListLeftLAreaDownListRight : Form
    {
        public string TITleMainLeft { get; set; }
        public string TITleMainRight { get; set; }
        public string TITleMainArea { get; set; }

        public frmListLeftLAreaDownListRight()
        {
            InitializeComponent();
            //lblTitleLeft.Text = TITleMainLeft;
            //lblTitleRight.Text = TITleMainRight;
            //lblTitleArea.Text = TITleMainArea;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
