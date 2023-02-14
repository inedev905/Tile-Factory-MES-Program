using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project_POP.Services;
using Team2_Project_DTO;

namespace Team2_Project_POP
{
    public partial class frmSelect : Form
    {
        PoPService ser = new PoPService();
        List<WorkCenterDTO> workCenterList = null;

        public frmSelect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidh = ((Screen.PrimaryScreen.Bounds.Width - 120) / 50);
            lblTitle.Location = new Point(screenWidh * 50 / 2, 30);

            lbl1.Location = new Point(20, 20);
            lbl1.Size = new Size(screenWidh * 8, 80);
            
            lbl2.Location = new Point(40 + lbl1.Size.Width, 20);
            lbl2.Size = new Size(screenWidh * 26, 80);
            
            lbl3.Location = new Point(60 + lbl1.Size.Width + lbl2.Size.Width, 20);
            lbl3.Size = new Size(screenWidh * 8, 80);

            //ucListSelect1.Location = new Point(0, 0);
            //ucListSelect1.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 120, 120);

            workCenterList = ser.GetWorkCenterInfo();

            for(int i = 0; i < workCenterList.Count;i++)
            {
                Controls.ucListSelect list = new Controls.ucListSelect();
                list.Location = new Point(0, i * 100);
                list.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 120, 100);
                list.Name = $"list{i}";
                list.Status = workCenterList[i].Wc_Status;
                list.Space = workCenterList[i].Wc_Name;
                list.Group = workCenterList[i].Wc_Group_Name;
                list.ListClick += List_ListClick;
                list.MouseEnter += List_MouseEnter;
                list.MouseLeave += List_MouseLeave;
                panel2.Controls.Add(list);
            }
        }

        private void List_MouseLeave(object sender, EventArgs e)
        {
            ((Controls.ucListSelect)sender).BackColor = Color.White;
        }

        private void List_MouseEnter(object sender, EventArgs e)
        {
            ((Controls.ucListSelect)sender).BackColor = Color.Black;
        }

        private void List_ListClick(object sender, EventArgs e)
        {
            //((Controls.ucListSelect)sender) ((frmParent)this.MdiParent).LoginedWorkCenter
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((((frmParent)this.MdiParent).LoginedWorkCenter == null))
            {
                MessageBox.Show("선택해주세요");
                return;
            }
        }
    }
}