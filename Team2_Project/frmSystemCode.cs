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
using Team2_Project.Services;
using Team2_Project_DTO;

namespace Team2_Project
{
    public partial class frmSystemCode : frmCodeControlBase
    {
        public frmSystemCode()
        {
            InitializeComponent();
        }

        private void frmSystemCode_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("테스트");

            //cboUserYNSC.Items.Add("전체");
            //cboUserYNSC.Items.Add("사용");
            //cboUserYNSC.Items.Add("미사용");
            //cboUserYNSC.SelectedIndex = 0;
            //cboUserYNSC.DropDownStyle = ComboBoxStyle.DropDownList;

            //DataGridViewUtil.SetInitDataGridView(dgvSysMa);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvSysMa, "시스템정의 대분류코드", "", 400, align: DataGridViewContentAlignment.MiddleCenter);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvSysMa, "시스템정의 대분류명", "", 400);

            //DataGridViewUtil.SetInitDataGridView(dgvSysMi);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvSysMi, "시스템정의 상세분류코드", "", 400);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvSysMi, "시스템정의 상세분류명", "", 400);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvSysMi, "정렬순서", "", 300);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvSysMi, "비고", "", 300);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvSysMi, "사용유무", "", 100);

            //cboMaUse.Items.Add("전체");
            //cboMaUse.Items.Add("사용");
            //cboMaUse.Items.Add("미사용");
            //cboMaUse.SelectedIndex = 0;
            //cboMaUse.DropDownStyle = ComboBoxStyle.DropDownList;

            //cboMinUse.Items.Add("전체");
            //cboMinUse.Items.Add("사용");
            //cboMinUse.Items.Add("미사용");
            //cboMinUse.SelectedIndex = 0;
            //cboMinUse.DropDownStyle = ComboBoxStyle.DropDownList;
        }


    }
}
