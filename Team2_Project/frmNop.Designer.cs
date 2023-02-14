
namespace Team2_Project
{
    partial class frmNop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.ucCodeSearch = new Team2_Project.Controls.ucSearch();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlSub.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.dtpTo);
            this.pnlSub.Controls.Add(this.ucCodeSearch);
            this.pnlSub.Controls.Add(this.dtpFrom);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.label9);
            this.pnlSub.Size = new System.Drawing.Size(1651, 57);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Location = new System.Drawing.Point(0, 57);
            this.pnlTitle.Size = new System.Drawing.Size(1651, 41);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvData);
            this.pnlList.Location = new System.Drawing.Point(0, 98);
            this.pnlList.Size = new System.Drawing.Size(1651, 762);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(40, 9);
            this.lblTitle.Size = new System.Drawing.Size(78, 18);
            this.lblTitle.Text = "비가동 내역";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(565, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "비가동일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(783, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "~";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(40, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "비가동 대분류코드";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(655, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(122, 25);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(2023, 1, 25, 0, 0, 0, 0);
            // 
            // ucCodeSearch
            // 
            this.ucCodeSearch._Code = "";
            this.ucCodeSearch._Name = "";
            this.ucCodeSearch.BackColor = System.Drawing.Color.Transparent;
            this.ucCodeSearch.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCodeSearch.Location = new System.Drawing.Point(178, 14);
            this.ucCodeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ucCodeSearch.Name = "ucCodeSearch";
            this.ucCodeSearch.Size = new System.Drawing.Size(340, 26);
            this.ucCodeSearch.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(808, 15);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(122, 25);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Value = new System.DateTime(2023, 1, 30, 0, 0, 0, 0);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1651, 762);
            this.dgvData.TabIndex = 1;
            // 
            // frmNop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 860);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNop";
            this.Text = "비가동 내역";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private Controls.ucSearch ucCodeSearch;
        private System.Windows.Forms.DataGridView dgvData;
    }
}