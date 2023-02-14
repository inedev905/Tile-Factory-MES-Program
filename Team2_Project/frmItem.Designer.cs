
namespace Team2_Project
{
    partial class frmItem
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
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTypeSC = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblInfoNameMa = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblInfoCodeMa = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cboUseYNSC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSpec = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
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
            this.pnlSub.Controls.Add(this.cboTypeSC);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Controls.Add(this.lblSearchCode);
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
            this.pnlList.Size = new System.Drawing.Size(1834, 669);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.label17);
            this.pnlArea.Controls.Add(this.txtRemark);
            this.pnlArea.Controls.Add(this.label18);
            this.pnlArea.Controls.Add(this.txtName);
            this.pnlArea.Controls.Add(this.cboUseYN);
            this.pnlArea.Controls.Add(this.label14);
            this.pnlArea.Controls.Add(this.label15);
            this.pnlArea.Controls.Add(this.label16);
            this.pnlArea.Controls.Add(this.cboSpec);
            this.pnlArea.Controls.Add(this.label11);
            this.pnlArea.Controls.Add(this.label13);
            this.pnlArea.Controls.Add(this.cboType);
            this.pnlArea.Controls.Add(this.label12);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.label8);
            this.pnlArea.Controls.Add(this.label10);
            this.pnlArea.Controls.Add(this.lblInfoNameMa);
            this.pnlArea.Controls.Add(this.txtCode);
            this.pnlArea.Controls.Add(this.lblInfoCodeMa);
            this.pnlArea.Size = new System.Drawing.Size(1834, 93);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Size = new System.Drawing.Size(1834, 852);
            this.splitContainer1.SplitterDistance = 712;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchCode.Location = new System.Drawing.Point(45, 20);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(64, 17);
            this.lblSearchCode.TabIndex = 2;
            this.lblSearchCode.Text = "품목코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(670, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "품목유형";
            // 
            // cboTypeSC
            // 
            this.cboTypeSC.FormattingEnabled = true;
            this.cboTypeSC.Location = new System.Drawing.Point(740, 16);
            this.cboTypeSC.Name = "cboTypeSC";
            this.cboTypeSC.Size = new System.Drawing.Size(121, 25);
            this.cboTypeSC.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(440, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(33, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(33, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(463, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(463, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "품목유형";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.AutoSize = true;
            this.lblInfoNameMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoNameMa.Location = new System.Drawing.Point(56, 56);
            this.lblInfoNameMa.Name = "lblInfoNameMa";
            this.lblInfoNameMa.Size = new System.Drawing.Size(50, 17);
            this.lblInfoNameMa.TabIndex = 25;
            this.lblInfoNameMa.Text = "품목명";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(140, 13);
            this.txtCode.MaxLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(250, 25);
            this.txtCode.TabIndex = 4;
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.AutoSize = true;
            this.lblInfoCodeMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCodeMa.Location = new System.Drawing.Point(56, 17);
            this.lblInfoCodeMa.Name = "lblInfoCodeMa";
            this.lblInfoCodeMa.Size = new System.Drawing.Size(64, 17);
            this.lblInfoCodeMa.TabIndex = 23;
            this.lblInfoCodeMa.Text = "품목코드";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(545, 13);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(128, 25);
            this.cboType.TabIndex = 6;
            this.cboType.SelectedValueChanged += new System.EventHandler(this.cboType_SelectedValueChanged);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(1834, 669);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // cboUseYNSC
            // 
            this.cboUseYNSC.FormattingEnabled = true;
            this.cboUseYNSC.Location = new System.Drawing.Point(995, 16);
            this.cboUseYNSC.Name = "cboUseYNSC";
            this.cboUseYNSC.Size = new System.Drawing.Size(121, 25);
            this.cboUseYNSC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(925, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "사용유무";
            // 
            // cboSpec
            // 
            this.cboSpec.FormattingEnabled = true;
            this.cboSpec.Location = new System.Drawing.Point(545, 52);
            this.cboSpec.Name = "cboSpec";
            this.cboSpec.Size = new System.Drawing.Size(128, 25);
            this.cboSpec.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(440, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(463, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "규격";
            // 
            // cboUseYN
            // 
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(828, 13);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(128, 25);
            this.cboUseYN.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(723, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(746, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "사용유무";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(746, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 48;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(140, 52);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 25);
            this.txtName.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(1006, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 55;
            this.label17.Text = "*";
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(1074, 13);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRemark.Size = new System.Drawing.Size(394, 64);
            this.txtRemark.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(1029, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 17);
            this.label18.TabIndex = 53;
            this.label18.Text = "비고";
            // 
            // ucCodeSearch
            // 
            this.ucCodeSearch._Code = "";
            this.ucCodeSearch._Name = "";
            this.ucCodeSearch.BackColor = System.Drawing.Color.Transparent;
            this.ucCodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucCodeSearch.Location = new System.Drawing.Point(115, 16);
            this.ucCodeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ucCodeSearch.Name = "ucCodeSearch";
            this.ucCodeSearch.Size = new System.Drawing.Size(340, 28);
            this.ucCodeSearch.TabIndex = 1;
            this.ucCodeSearch.BtnClick += new System.EventHandler(this.ucCodeSearch_BtnClick);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmItem";
            this.Text = "품목정보";
            this.Load += new System.EventHandler(this.frmMenu_Load);
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
        protected System.Windows.Forms.Label lblSearchCode;
        private System.Windows.Forms.ComboBox cboTypeSC;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label lblInfoNameMa;
        protected System.Windows.Forms.TextBox txtCode;
        protected System.Windows.Forms.Label lblInfoCodeMa;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cboUseYNSC;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUseYN;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboSpec;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.TextBox txtRemark;
        protected System.Windows.Forms.Label label18;
        private Controls.ucSearch ucCodeSearch;
    }
}