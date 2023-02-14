using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2_Project.BaseForms;
using Team2_Project.Utils;

namespace Team2_Project
{
    public partial class frmUserManagement : frmListLeftLAreaDownListRight
    {
        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvUserGroup);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserGroup, "사용자 그룹코드", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserGroup, "사용자 그룹명", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserGroup, "사용여부", "", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserGroup, "Admin여부", "", 150);

            DataGridViewUtil.SetInitDataGridView(dgvUserAuthority);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserAuthority, "메뉴코드", "", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserAuthority, "메뉴명", "", 400);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserAuthority, "조회권한", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserAuthority, "전체권한", "", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvUserAuthority, "권한문자열", "", 150);
        }
    }
}
