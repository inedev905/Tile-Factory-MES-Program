
namespace Team2_Project
{
    partial class frmDefectCode
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
            this.txtNameSC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboUseSC = new System.Windows.Forms.ComboBox();
            this.txtCodeSC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMa = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.txtNameSC);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Controls.Add(this.cboUseSC);
            this.pnlSub.Controls.Add(this.txtCodeSC);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Size = new System.Drawing.Size(1100, 60);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleU.Location = new System.Drawing.Point(39, 10);
            this.lblTitleU.Size = new System.Drawing.Size(64, 17);
            this.lblTitleU.Text = "조회내역";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleD.Location = new System.Drawing.Point(39, 10);
            this.lblTitleD.Size = new System.Drawing.Size(64, 17);
            this.lblTitleD.Text = "입력정보";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvMa);
            this.pnlList.Size = new System.Drawing.Size(1100, 359);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.cboUseYN);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.label8);
            this.pnlArea.Controls.Add(this.label9);
            this.pnlArea.Controls.Add(this.txtName);
            this.pnlArea.Controls.Add(this.txtCode);
            this.pnlArea.Controls.Add(this.label12);
            this.pnlArea.Controls.Add(this.label13);
            this.pnlArea.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlArea.Size = new System.Drawing.Size(1100, 121);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1100, 570);
            this.splitContainer1.SplitterDistance = 402;
            // 
            // txtNameSC
            // 
            this.txtNameSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameSC.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSC.Location = new System.Drawing.Point(552, 16);
            this.txtNameSC.Name = "txtNameSC";
            this.txtNameSC.Size = new System.Drawing.Size(170, 25);
            this.txtNameSC.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "불랑현상 대분류명";
            // 
            // cboUseSC
            // 
            this.cboUseSC.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUseSC.FormattingEnabled = true;
            this.cboUseSC.Location = new System.Drawing.Point(861, 16);
            this.cboUseSC.Name = "cboUseSC";
            this.cboUseSC.Size = new System.Drawing.Size(130, 25);
            this.cboUseSC.TabIndex = 20;
            // 
            // txtCodeSC
            // 
            this.txtCodeSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodeSC.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeSC.Location = new System.Drawing.Point(183, 16);
            this.txtCodeSC.Name = "txtCodeSC";
            this.txtCodeSC.Size = new System.Drawing.Size(170, 25);
            this.txtCodeSC.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "사용유무";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "불량현상 대분류코드";
            // 
            // dgvMa
            // 
            this.dgvMa.BackgroundColor = System.Drawing.Color.White;
            this.dgvMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMa.Location = new System.Drawing.Point(0, 0);
            this.dgvMa.Name = "dgvMa";
            this.dgvMa.RowTemplate.Height = 23;
            this.dgvMa.Size = new System.Drawing.Size(1100, 359);
            this.dgvMa.TabIndex = 0;
            this.dgvMa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMa_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(423, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "*";
            // 
            // cboUseYN
            // 
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(525, 17);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(130, 25);
            this.cboUseYN.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "사용유무";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(20, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(20, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "*";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(193, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 25);
            this.txtName.TabIndex = 76;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(193, 17);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(170, 25);
            this.txtCode.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 75;
            this.label12.Text = "불량현상 대분류명";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 17);
            this.label13.TabIndex = 72;
            this.label13.Text = "불량현상 대분류코드";
            // 
            // frmDefectCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Name = "frmDefectCode";
            this.Text = "frmDefectCode";
            this.Load += new System.EventHandler(this.frmDefectCode_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox txtNameSC;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboUseSC;
        protected System.Windows.Forms.TextBox txtCodeSC;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMa;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUseYN;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.TextBox txtCode;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label13;
    }
}
