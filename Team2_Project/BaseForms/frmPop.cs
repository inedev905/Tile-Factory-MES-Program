using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2_Project.Utils;
using Team2_Project_DTO;

namespace Team2_Project.BaseForms
{
    public partial class frmPop : Form
    {
        IEnumerable<dynamic> list;

        public string SelCode { get; private set; }
        public string SelName { get; private set; }
        public string SelEtc { get; private set; }

        public frmPop()
        {
            InitializeComponent();
        }

        public void PopLoadData<T>(CommonPop<T> popInfo) where T : class, new()
        {
            DataGridViewUtil.SetInitDataGridView(dgvpop);
            dgvpop.RowHeadersVisible = false;

            foreach (var col in popInfo.DgvCols)
            {
                dgvpop.Columns.Add(col);
            }

            if(popInfo.DgvCols.Count == 3)
            {
                this.Size = new Size(620, 570);
            }

            dgvpop.DataSource = popInfo.DgvDatasource;
            this.Text = popInfo.PopName;

            list = popInfo.DgvDatasource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> colName = new List<string>();
            foreach(DataGridViewColumn col in dgvpop.Columns)
            {
                colName.Add(col.Name);
            }

            string keyword = txtKeyword.Text;

            foreach (var col in colName)
            {
                var items = ListFilter.Filter(list.ToList(), col, keyword);
                if (items.Count > 0)
                {
                    dgvpop.DataSource = items;
                }                
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblComment.Visible = false;

            if (e.KeyChar == 13)
                btnSearch_Click(this, null);
        }

        private void lblComment_Click(object sender, EventArgs e)
        {
            lblComment.Visible = false;
        }

        private void dgvpop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            SelCode = dgvpop[0, e.RowIndex].Value.ToString();
            SelName = dgvpop[1, e.RowIndex].Value.ToString();
            if(dgvpop.Columns.Count == 3)
                SelEtc = dgvpop[2, e.RowIndex].Value.ToString();
            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    static class ListFilter
    {
        public static List<T> Filter<T>(List<T> source, string columnName, string propertyValue)
        {
            var filter = source.Where(m => m.GetType().GetProperty(columnName).GetValue(m).ToString().ToLower().Contains(propertyValue.ToLower()));
            return filter.ToList();
            
        }
    }
}
