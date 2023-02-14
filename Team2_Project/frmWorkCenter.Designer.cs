
namespace Team2_Project
{
    partial class frmWorkCenter
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
            this.dgvWorkShop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCenterCode = new System.Windows.Forms.TextBox();
            this.txtCenterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPalletYN = new System.Windows.Forms.ComboBox();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboSearchUseYN = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ucProcCode = new Team2_Project.Controls.ucSearch();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.ucSrchProcCode = new Team2_Project.Controls.ucSearch();
            this.cboWCGroup = new System.Windows.Forms.ComboBox();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.ucSrchProcCode);
            this.pnlSub.Controls.Add(this.cboSearchUseYN);
            this.pnlSub.Controls.Add(this.label14);
            this.pnlSub.Controls.Add(this.label13);
            this.pnlSub.Controls.Add(this.txtSearchName);
            this.pnlSub.Controls.Add(this.txtSearchCode);
            this.pnlSub.Controls.Add(this.label11);
            this.pnlSub.Controls.Add(this.label12);
            this.pnlSub.Size = new System.Drawing.Size(1351, 120);
            // 
            // lblTitleU
            // 
            this.lblTitleU.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleU.Location = new System.Drawing.Point(39, 8);
            this.lblTitleU.Size = new System.Drawing.Size(68, 17);
            this.lblTitleU.Text = "조회 결과";
            // 
            // lblTitleD
            // 
            this.lblTitleD.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleD.Location = new System.Drawing.Point(39, 8);
            this.lblTitleD.Size = new System.Drawing.Size(82, 17);
            this.lblTitleD.Text = "작업장 정보";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvWorkShop);
            this.pnlList.Size = new System.Drawing.Size(1351, 495);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.cboWCGroup);
            this.pnlArea.Controls.Add(this.label20);
            this.pnlArea.Controls.Add(this.label19);
            this.pnlArea.Controls.Add(this.label18);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.ucProcCode);
            this.pnlArea.Controls.Add(this.label17);
            this.pnlArea.Controls.Add(this.label16);
            this.pnlArea.Controls.Add(this.label15);
            this.pnlArea.Controls.Add(this.txtRemark);
            this.pnlArea.Controls.Add(this.label10);
            this.pnlArea.Controls.Add(this.label9);
            this.pnlArea.Controls.Add(this.cboUseYN);
            this.pnlArea.Controls.Add(this.cboPalletYN);
            this.pnlArea.Controls.Add(this.label8);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.txtCenterName);
            this.pnlArea.Controls.Add(this.txtCenterCode);
            this.pnlArea.Controls.Add(this.label5);
            this.pnlArea.Controls.Add(this.label4);
            this.pnlArea.Controls.Add(this.label1);
            this.pnlArea.Size = new System.Drawing.Size(1351, 180);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 120);
            this.splitContainer1.Size = new System.Drawing.Size(1351, 765);
            this.splitContainer1.SplitterDistance = 538;
            // 
            // dgvWorkShop
            // 
            this.dgvWorkShop.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkShop.Location = new System.Drawing.Point(0, 0);
            this.dgvWorkShop.Name = "dgvWorkShop";
            this.dgvWorkShop.RowTemplate.Height = 23;
            this.dgvWorkShop.Size = new System.Drawing.Size(1351, 495);
            this.dgvWorkShop.TabIndex = 0;
            this.dgvWorkShop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkShop_CellClick);
            this.dgvWorkShop.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWorkShop_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업장 코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "작업장 명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "작업장 그룹";
            // 
            // txtCenterCode
            // 
            this.txtCenterCode.Location = new System.Drawing.Point(155, 19);
            this.txtCenterCode.Name = "txtCenterCode";
            this.txtCenterCode.Size = new System.Drawing.Size(170, 25);
            this.txtCenterCode.TabIndex = 3;
            // 
            // txtCenterName
            // 
            this.txtCenterName.Location = new System.Drawing.Point(155, 76);
            this.txtCenterName.Name = "txtCenterName";
            this.txtCenterName.Size = new System.Drawing.Size(170, 25);
            this.txtCenterName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "팔렛생성 여부";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "사용유무";
            // 
            // cboPalletYN
            // 
            this.cboPalletYN.FormattingEnabled = true;
            this.cboPalletYN.Location = new System.Drawing.Point(155, 133);
            this.cboPalletYN.Name = "cboPalletYN";
            this.cboPalletYN.Size = new System.Drawing.Size(130, 25);
            this.cboPalletYN.TabIndex = 10;
            // 
            // cboUseYN
            // 
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(505, 133);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(130, 25);
            this.cboUseYN.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "공정 코드";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(925, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "비고";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(979, 19);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(289, 134);
            this.txtRemark.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(30, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "작업장 명";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(30, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "작업장 코드";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(367, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "공정코드";
            // 
            // cboSearchUseYN
            // 
            this.cboSearchUseYN.FormattingEnabled = true;
            this.cboSearchUseYN.Location = new System.Drawing.Point(452, 67);
            this.cboSearchUseYN.Name = "cboSearchUseYN";
            this.cboSearchUseYN.Size = new System.Drawing.Size(130, 25);
            this.cboSearchUseYN.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(367, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "사용여부";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(20, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(20, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(381, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "*";
            // 
            // ucProcCode
            // 
            this.ucProcCode._Code = "";
            this.ucProcCode._Name = "";
            this.ucProcCode.BackColor = System.Drawing.Color.Transparent;
            this.ucProcCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProcCode.Location = new System.Drawing.Point(505, 16);
            this.ucProcCode.Margin = new System.Windows.Forms.Padding(4);
            this.ucProcCode.Name = "ucProcCode";
            this.ucProcCode.Size = new System.Drawing.Size(340, 28);
            this.ucProcCode.TabIndex = 22;
            this.ucProcCode.BtnClick += new System.EventHandler(this.ucProcCode_BtnClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(20, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(381, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(381, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(902, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 17);
            this.label20.TabIndex = 27;
            this.label20.Text = "*";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(137, 23);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(170, 25);
            this.txtSearchCode.TabIndex = 7;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(137, 67);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(170, 25);
            this.txtSearchName.TabIndex = 8;
            // 
            // ucSrchProcCode
            // 
            this.ucSrchProcCode._Code = "";
            this.ucSrchProcCode._Name = "";
            this.ucSrchProcCode.BackColor = System.Drawing.Color.Transparent;
            this.ucSrchProcCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSrchProcCode.Location = new System.Drawing.Point(452, 20);
            this.ucSrchProcCode.Margin = new System.Windows.Forms.Padding(4);
            this.ucSrchProcCode.Name = "ucSrchProcCode";
            this.ucSrchProcCode.Size = new System.Drawing.Size(340, 28);
            this.ucSrchProcCode.TabIndex = 18;
            this.ucSrchProcCode.BtnClick += new System.EventHandler(this.ucSrchProcCode_BtnClick);
            // 
            // cboWCGroup
            // 
            this.cboWCGroup.FormattingEnabled = true;
            this.cboWCGroup.Location = new System.Drawing.Point(505, 76);
            this.cboWCGroup.Name = "cboWCGroup";
            this.cboWCGroup.Size = new System.Drawing.Size(130, 25);
            this.cboWCGroup.TabIndex = 28;
            // 
            // frmWorkCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1351, 885);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmWorkCenter";
            this.Text = "작업장정보";
            this.Load += new System.EventHandler(this.frmWorkShopInfo_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSearchUseYN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvWorkShop;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboUseYN;
        private System.Windows.Forms.ComboBox cboPalletYN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCenterName;
        private System.Windows.Forms.TextBox txtCenterCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucProcCode;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label20;
        protected System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Label label18;
        protected System.Windows.Forms.Label label6;
        private Controls.ucSearch ucSrchProcCode;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.ComboBox cboWCGroup;
    }
}
