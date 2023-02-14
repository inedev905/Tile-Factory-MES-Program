using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project.Utils
{
    public class DataGridViewUtil
    {
        public static void SetInitDataGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;//DataSource를 기준으로 자동 컬럼을 생성 (기본값이 true)
            dgv.AllowUserToAddRows = false;//마지막에 + 행추가 삭제 (기본값이 true)
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersWidth = 25;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 30;                        
        }

        public static void AddGridTextBoxColumn(
            DataGridView dgv,
            string headerText,
            string propertyName,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft,
            bool visible = true,
            bool frosen = false,
            bool OrangebackColor = false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = propertyName;
            col.HeaderText = headerText;
            
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            //Alignment : 가운데정렬 (길이가 고정적인 경우)
            //Alignment : 왼쪽정렬 (길이가 가변적인 문자열인 경우)
            //Alignment : 오른쪽정렬 (길이가 가변적인 숫자인 경우, 돈, 수량 등)
            col.DataPropertyName = propertyName;
            col.DefaultCellStyle.Alignment = align;
            col.Width = colWidth;
            col.ReadOnly = true;
            col.Visible = visible;
            col.Frozen = frosen;

            if (OrangebackColor)
            {
                col.DefaultCellStyle.BackColor = Color.PeachPuff;
            }

            dgv.Columns.Add(col);
        }



        public static DataGridViewTextBoxColumn ReturnNewDgvColumn(
            string headerText,
            string propertyName,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();

            col.Name = propertyName;
            col.HeaderText = headerText;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DataPropertyName = propertyName;
            col.DefaultCellStyle.Alignment = align;
            col.Width = colWidth;
            col.ReadOnly = true;

            return col;
        }
    }
}
