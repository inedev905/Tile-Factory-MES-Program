
namespace Team2_Project
{
    partial class frmUserGroupCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboUseYN1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.txtGroupCode2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.cboAdUseYN2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGroupNM2 = new System.Windows.Forms.TextBox();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.cboUseYN2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGroupNM1 = new System.Windows.Forms.TextBox();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.txtGroupNM1);
            this.pnlSub.Controls.Add(this.cboUseYN1);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSub.Size = new System.Drawing.Size(1326, 60);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleU.Location = new System.Drawing.Point(39, 8);
            this.lblTitleU.Size = new System.Drawing.Size(68, 17);
            this.lblTitleU.Text = "조회 내역";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleD.Location = new System.Drawing.Point(39, 8);
            this.lblTitleD.Size = new System.Drawing.Size(64, 17);
            this.lblTitleD.Text = "입력정보";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvGroup);
            this.pnlList.Size = new System.Drawing.Size(1326, 397);
            // 
            // pnlArea
            // 
            this.pnlArea.AutoSize = true;
            this.pnlArea.Controls.Add(this.cboUseYN2);
            this.pnlArea.Controls.Add(this.label11);
            this.pnlArea.Controls.Add(this.label12);
            this.pnlArea.Controls.Add(this.txtGroupNM2);
            this.pnlArea.Controls.Add(this.cboAdUseYN2);
            this.pnlArea.Controls.Add(this.label9);
            this.pnlArea.Controls.Add(this.label10);
            this.pnlArea.Controls.Add(this.lblGroupName);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.txtGroupCode2);
            this.pnlArea.Controls.Add(this.lblGroupCode);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Size = new System.Drawing.Size(1326, 60);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Size = new System.Drawing.Size(1326, 547);
            this.splitContainer1.SplitterDistance = 440;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 그룹명";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(383, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "사용유무";
            // 
            // cboUseYN1
            // 
            this.cboUseYN1.BackColor = System.Drawing.Color.White;
            this.cboUseYN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUseYN1.FormattingEnabled = true;
            this.cboUseYN1.Location = new System.Drawing.Point(457, 16);
            this.cboUseYN1.Name = "cboUseYN1";
            this.cboUseYN1.Size = new System.Drawing.Size(130, 25);
            this.cboUseYN1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "*";
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGroupCode.AutoSize = true;
            this.lblGroupCode.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupCode.Location = new System.Drawing.Point(40, 18);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(114, 17);
            this.lblGroupCode.TabIndex = 19;
            this.lblGroupCode.Text = "사용자 그룹 코드";
            // 
            // txtGroupCode2
            // 
            this.txtGroupCode2.Location = new System.Drawing.Point(160, 15);
            this.txtGroupCode2.Name = "txtGroupCode2";
            this.txtGroupCode2.Size = new System.Drawing.Size(170, 25);
            this.txtGroupCode2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(392, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "*";
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.Location = new System.Drawing.Point(415, 18);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(96, 17);
            this.lblGroupName.TabIndex = 22;
            this.lblGroupName.Text = "사용자 그룹명";
            // 
            // cboAdUseYN2
            // 
            this.cboAdUseYN2.BackColor = System.Drawing.Color.White;
            this.cboAdUseYN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdUseYN2.FormattingEnabled = true;
            this.cboAdUseYN2.Location = new System.Drawing.Point(838, 15);
            this.cboAdUseYN2.Name = "cboAdUseYN2";
            this.cboAdUseYN2.Size = new System.Drawing.Size(130, 25);
            this.cboAdUseYN2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(777, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Admin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(754, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "*";
            // 
            // txtGroupNM2
            // 
            this.txtGroupNM2.Location = new System.Drawing.Point(517, 15);
            this.txtGroupNM2.Name = "txtGroupNM2";
            this.txtGroupNM2.Size = new System.Drawing.Size(170, 25);
            this.txtGroupNM2.TabIndex = 27;
            // 
            // dgvGroup
            // 
            this.dgvGroup.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroup.Location = new System.Drawing.Point(0, 0);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(1326, 397);
            this.dgvGroup.TabIndex = 1;
            this.dgvGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellClick);
            // 
            // cboUseYN2
            // 
            this.cboUseYN2.BackColor = System.Drawing.Color.White;
            this.cboUseYN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUseYN2.FormattingEnabled = true;
            this.cboUseYN2.Location = new System.Drawing.Point(1132, 15);
            this.cboUseYN2.Name = "cboUseYN2";
            this.cboUseYN2.Size = new System.Drawing.Size(130, 25);
            this.cboUseYN2.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(1062, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "사용유무";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1039, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "*";
            // 
            // txtGroupNM1
            // 
            this.txtGroupNM1.Location = new System.Drawing.Point(135, 16);
            this.txtGroupNM1.Name = "txtGroupNM1";
            this.txtGroupNM1.Size = new System.Drawing.Size(170, 25);
            this.txtGroupNM1.TabIndex = 28;
            // 
            // frmUserGroupCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1326, 607);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmUserGroupCode";
            this.Text = "사용자 그룹관리";
            this.Load += new System.EventHandler(this.frmUserGroupCode_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUseYN1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroupNM2;
        private System.Windows.Forms.ComboBox cboAdUseYN2;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGroupName;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGroupCode2;
        private System.Windows.Forms.Label lblGroupCode;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.TextBox txtGroupNM1;
        private System.Windows.Forms.ComboBox cboUseYN2;
        private System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label12;
    }
}
