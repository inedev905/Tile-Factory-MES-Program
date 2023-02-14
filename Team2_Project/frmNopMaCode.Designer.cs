
namespace Team2_Project
{
    partial class frmNopMaCode
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
            this.cboUseYNSC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ucCodeSearch = new Team2_Project.Controls.ucSearch();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.ucCodeSearch);
            this.pnlSub.Controls.Add(this.cboUseYNSC);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Size = new System.Drawing.Size(1834, 59);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Location = new System.Drawing.Point(45, 10);
            this.lblTitleU.Size = new System.Drawing.Size(60, 18);
            this.lblTitleU.Text = "조회내역";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Location = new System.Drawing.Point(45, 10);
            this.lblTitleD.Size = new System.Drawing.Size(60, 18);
            this.lblTitleD.Text = "입력정보";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvData);
            this.pnlList.Size = new System.Drawing.Size(1834, 707);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.label11);
            this.pnlArea.Controls.Add(this.cboUseYN);
            this.pnlArea.Controls.Add(this.label10);
            this.pnlArea.Controls.Add(this.label8);
            this.pnlArea.Controls.Add(this.label9);
            this.pnlArea.Controls.Add(this.txtName);
            this.pnlArea.Controls.Add(this.txtCode);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Size = new System.Drawing.Size(1834, 55);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Size = new System.Drawing.Size(1834, 852);
            this.splitContainer1.SplitterDistance = 750;
            // 
            // cboUseYNSC
            // 
            this.cboUseYNSC.FormattingEnabled = true;
            this.cboUseYNSC.Location = new System.Drawing.Point(729, 18);
            this.cboUseYNSC.Name = "cboUseYNSC";
            this.cboUseYNSC.Size = new System.Drawing.Size(136, 25);
            this.cboUseYNSC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(650, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "사용유무";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "비가동 대분류코드";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtName.Location = new System.Drawing.Point(665, 14);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 25);
            this.txtName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(529, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "비가동 대분류명";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(192, 14);
            this.txtCode.MaxLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(222, 25);
            this.txtCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(56, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "비가동 대분류코드";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(496, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(25, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "*";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1834, 707);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // cboUseYN
            // 
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(1081, 14);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(136, 25);
            this.cboUseYN.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1002, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "사용유무";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(973, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "*";
            // 
            // ucCodeSearch
            // 
            this.ucCodeSearch._Code = "";
            this.ucCodeSearch._Name = "";
            this.ucCodeSearch.BackColor = System.Drawing.Color.Transparent;
            this.ucCodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucCodeSearch.Location = new System.Drawing.Point(171, 16);
            this.ucCodeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ucCodeSearch.Name = "ucCodeSearch";
            this.ucCodeSearch.Size = new System.Drawing.Size(340, 28);
            this.ucCodeSearch.TabIndex = 1;
            this.ucCodeSearch.BtnClick += new System.EventHandler(this.ucCodeSearch_BtnClick);
            // 
            // frmNopMaCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNopMaCode";
            this.Text = "비가동 대분류코드";
            this.Load += new System.EventHandler(this.frmDownCode_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUseYNSC;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.TextBox txtCode;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        protected System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboUseYN;
        protected System.Windows.Forms.Label label10;
        private Controls.ucSearch ucCodeSearch;
    }
}
