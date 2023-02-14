
namespace Team2_Project
{
    partial class frmProcessManagement
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProcessCode = new System.Windows.Forms.TextBox();
            this.txtProcessCodeName = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cboProcessGroupArea = new System.Windows.Forms.ComboBox();
            this.cboUseArea = new System.Windows.Forms.ComboBox();
            this.cboUseSub = new System.Windows.Forms.ComboBox();
            this.cboProcessGroupSub = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ucSearch1 = new Team2_Project.Controls.ucSearch();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.Transparent;
            this.pnlSub.Controls.Add(this.ucSearch1);
            this.pnlSub.Controls.Add(this.label12);
            this.pnlSub.Controls.Add(this.cboUseSub);
            this.pnlSub.Controls.Add(this.cboProcessGroupSub);
            this.pnlSub.Controls.Add(this.label8);
            this.pnlSub.Controls.Add(this.label9);
            this.pnlSub.Size = new System.Drawing.Size(1289, 60);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleU.Location = new System.Drawing.Point(39, 8);
            this.lblTitleU.Size = new System.Drawing.Size(65, 18);
            this.lblTitleU.Text = "조회 내역";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleD.Location = new System.Drawing.Point(39, 8);
            this.lblTitleD.Size = new System.Drawing.Size(65, 18);
            this.lblTitleD.Text = "공정 정보";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvProcess);
            this.pnlList.Size = new System.Drawing.Size(1289, 339);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.label15);
            this.pnlArea.Controls.Add(this.label14);
            this.pnlArea.Controls.Add(this.label13);
            this.pnlArea.Controls.Add(this.label11);
            this.pnlArea.Controls.Add(this.label10);
            this.pnlArea.Controls.Add(this.cboUseArea);
            this.pnlArea.Controls.Add(this.cboProcessGroupArea);
            this.pnlArea.Controls.Add(this.txtRemark);
            this.pnlArea.Controls.Add(this.txtProcessCodeName);
            this.pnlArea.Controls.Add(this.txtProcessCode);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.label5);
            this.pnlArea.Controls.Add(this.label4);
            this.pnlArea.Controls.Add(this.label1);
            this.pnlArea.Size = new System.Drawing.Size(1289, 165);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 594);
            this.splitContainer1.SplitterDistance = 382;
            // 
            // dgvProcess
            // 
            this.dgvProcess.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcess.Location = new System.Drawing.Point(0, 0);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.RowHeadersWidth = 51;
            this.dgvProcess.RowTemplate.Height = 23;
            this.dgvProcess.Size = new System.Drawing.Size(1289, 339);
            this.dgvProcess.TabIndex = 0;
            this.dgvProcess.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcess_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "공정코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "공정명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "공정그룹";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "사용유무";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "비고";
            // 
            // txtProcessCode
            // 
            this.txtProcessCode.Location = new System.Drawing.Point(115, 15);
            this.txtProcessCode.Name = "txtProcessCode";
            this.txtProcessCode.Size = new System.Drawing.Size(170, 24);
            this.txtProcessCode.TabIndex = 5;
            // 
            // txtProcessCodeName
            // 
            this.txtProcessCodeName.Location = new System.Drawing.Point(115, 75);
            this.txtProcessCodeName.Name = "txtProcessCodeName";
            this.txtProcessCodeName.Size = new System.Drawing.Size(170, 24);
            this.txtProcessCodeName.TabIndex = 6;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(694, 15);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(300, 86);
            this.txtRemark.TabIndex = 7;
            // 
            // cboProcessGroupArea
            // 
            this.cboProcessGroupArea.FormattingEnabled = true;
            this.cboProcessGroupArea.Location = new System.Drawing.Point(435, 15);
            this.cboProcessGroupArea.Name = "cboProcessGroupArea";
            this.cboProcessGroupArea.Size = new System.Drawing.Size(130, 26);
            this.cboProcessGroupArea.TabIndex = 8;
            // 
            // cboUseArea
            // 
            this.cboUseArea.FormattingEnabled = true;
            this.cboUseArea.Location = new System.Drawing.Point(435, 75);
            this.cboUseArea.Name = "cboUseArea";
            this.cboUseArea.Size = new System.Drawing.Size(130, 26);
            this.cboUseArea.TabIndex = 9;
            // 
            // cboUseSub
            // 
            this.cboUseSub.FormattingEnabled = true;
            this.cboUseSub.Location = new System.Drawing.Point(850, 15);
            this.cboUseSub.Name = "cboUseSub";
            this.cboUseSub.Size = new System.Drawing.Size(130, 26);
            this.cboUseSub.TabIndex = 17;
            // 
            // cboProcessGroupSub
            // 
            this.cboProcessGroupSub.FormattingEnabled = true;
            this.cboProcessGroupSub.Location = new System.Drawing.Point(585, 15);
            this.cboProcessGroupSub.Name = "cboProcessGroupSub";
            this.cboProcessGroupSub.Size = new System.Drawing.Size(130, 26);
            this.cboProcessGroupSub.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(775, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "사용유무";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(510, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "공정그룹";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(35, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "공정코드";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(20, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "*";
            // 
            // ucSearch1
            // 
            this.ucSearch1._Code = "";
            this.ucSearch1._Name = "";
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearch1.Location = new System.Drawing.Point(110, 15);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(340, 28);
            this.ucSearch1.TabIndex = 19;
            this.ucSearch1.BtnClick += new System.EventHandler(this.ucSearch1_BtnClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(20, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(345, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 18);
            this.label13.TabIndex = 40;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(345, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 18);
            this.label14.TabIndex = 41;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(625, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 18);
            this.label15.TabIndex = 42;
            this.label15.Text = "*";
            // 
            // frmProcessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1289, 654);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProcessManagement";
            this.Text = "공정정보";
            this.Load += new System.EventHandler(this.frmProcessManagement_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUseSub;
        private System.Windows.Forms.ComboBox cboProcessGroupSub;
        
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.ComboBox cboUseArea;
        private System.Windows.Forms.ComboBox cboProcessGroupArea;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtProcessCodeName;
        private System.Windows.Forms.TextBox txtProcessCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label10;
        private Controls.ucSearch ucSearch1;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label label11;
    }
}
