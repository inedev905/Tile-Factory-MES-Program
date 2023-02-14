using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project_POP.Controls
{
    public partial class ucListSelect : UserControl
    {
        public string Status { get; set; }
        public string Space { get; set; }
        public string Group { get; set; }
        public event EventHandler ListClick;
        public event EventHandler ListMouseEnter;
        public event EventHandler ListMouseOut;


        public ucListSelect()
        {
            InitializeComponent();
        }

        private void ucListSelect_Load(object sender, EventArgs e)
        {
            int screenWidh = ((Screen.PrimaryScreen.Bounds.Width - 120) / 50);
            
            lbl1.Location = new Point(20, 10);
            lbl1.Size = new Size(screenWidh * 8, 80);
            lbl1.Text = Status;
            
            if(Status == "Run") 
            {
                lbl1.BackColor = Color.Green;
                lbl1.ForeColor = Color.White;
            }   
            else
            {
                lbl1.BackColor = Color.Red;
                lbl1.ForeColor = Color.Black;
            }   
            
            lbl2.Location = new Point(40 + lbl1.Size.Width, 10);
            lbl2.Size = new Size(screenWidh * 26, 80);
            lbl2.Text = Space;

            lbl3.Location = new Point(60 + lbl1.Size.Width + lbl2.Size.Width, 10);
            lbl3.Size = new Size(screenWidh * 8, 80);
            lbl3.Text = Group;

        }
        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            if (ListMouseEnter != null)
                ListMouseEnter(this, e);
        }

        private void ucListSelect_Click(object sender, EventArgs e)
        {
            if (ListClick != null)
                ListClick(this, e);
        }

        private void ucListSelect_MouseLeave(object sender, EventArgs e)
        {
            if (ListClick != null)
                ListClick(this, e);
        }
    }
}
