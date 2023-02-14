
namespace Team2_Project.BaseForms
{
    partial class frmCodeControlBase
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ucMaCode = new Team2_Project.Controls.ucSearch();
            this.cboUseYN = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSort = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInfoNameMa = new System.Windows.Forms.Label();
            this.txtInfoNameMi = new System.Windows.Forms.TextBox();
            this.txtInfoCodeMi = new System.Windows.Forms.TextBox();
            this.lblInfoCodeMa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListTitleR = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboSearchUse = new System.Windows.Forms.ComboBox();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.ucMaCodeSC = new Team2_Project.Controls.ucSearch();
            this.pnlSub.SuspendLayout();
            this.pnlListR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.ucMaCodeSC);
            this.pnlSub.Controls.Add(this.label16);
            this.pnlSub.Controls.Add(this.cboSearchUse);
            this.pnlSub.Controls.Add(this.lblSearchCode);
            this.pnlSub.Size = new System.Drawing.Size(1738, 64);
            // 
            // pnlListL
            // 
            this.pnlListL.Size = new System.Drawing.Size(578, 641);
            // 
            // lblTitleL
            // 
            this.lblTitleL.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleL.Location = new System.Drawing.Point(44, 10);
            this.lblTitleL.Text = "대분류";
            // 
            // pnlListR
            // 
            this.pnlListR.Controls.Add(this.splitContainer2);
            this.pnlListR.Size = new System.Drawing.Size(1156, 641);
            // 
            // lblTitleR
            // 
            this.lblTitleR.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleR.Location = new System.Drawing.Point(44, 10);
            this.lblTitleR.Size = new System.Drawing.Size(64, 17);
            this.lblTitleR.Text = "상세분류";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.splitContainer2.Panel2.Controls.Add(this.ucMaCode);
            this.splitContainer2.Panel2.Controls.Add(this.cboUseYN);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.nudSort);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.txtRemark);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.lblInfoNameMa);
            this.splitContainer2.Panel2.Controls.Add(this.txtInfoNameMi);
            this.splitContainer2.Panel2.Controls.Add(this.txtInfoCodeMi);
            this.splitContainer2.Panel2.Controls.Add(this.lblInfoCodeMa);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(1156, 641);
            this.splitContainer2.SplitterDistance = 345;
            this.splitContainer2.TabIndex = 0;
            // 
            // ucMaCode
            // 
            this.ucMaCode._Code = "";
            this.ucMaCode._Name = "";
            this.ucMaCode.BackColor = System.Drawing.Color.Transparent;
            this.ucMaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucMaCode.Location = new System.Drawing.Point(260, 62);
            this.ucMaCode.Margin = new System.Windows.Forms.Padding(4);
            this.ucMaCode.Name = "ucMaCode";
            this.ucMaCode.Size = new System.Drawing.Size(382, 30);
            this.ucMaCode.TabIndex = 34;
            // 
            // cboUseYN
            // 
            this.cboUseYN.FormattingEnabled = true;
            this.cboUseYN.Location = new System.Drawing.Point(802, 62);
            this.cboUseYN.Name = "cboUseYN";
            this.cboUseYN.Size = new System.Drawing.Size(130, 25);
            this.cboUseYN.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(700, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(723, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "사용유무";
            // 
            // nudSort
            // 
            this.nudSort.Location = new System.Drawing.Point(260, 242);
            this.nudSort.Name = "nudSort";
            this.nudSort.Size = new System.Drawing.Size(130, 25);
            this.nudSort.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(700, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "*";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(802, 124);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(300, 84);
            this.txtRemark.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(723, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "비고";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(43, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "정렬 순서";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(20, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "상세분류명";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.AutoSize = true;
            this.lblInfoNameMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoNameMa.Location = new System.Drawing.Point(43, 126);
            this.lblInfoNameMa.Name = "lblInfoNameMa";
            this.lblInfoNameMa.Size = new System.Drawing.Size(92, 17);
            this.lblInfoNameMa.TabIndex = 20;
            this.lblInfoNameMa.Text = "상세분류코드";
            // 
            // txtInfoNameMi
            // 
            this.txtInfoNameMi.Location = new System.Drawing.Point(260, 182);
            this.txtInfoNameMi.Name = "txtInfoNameMi";
            this.txtInfoNameMi.Size = new System.Drawing.Size(170, 25);
            this.txtInfoNameMi.TabIndex = 19;
            // 
            // txtInfoCodeMi
            // 
            this.txtInfoCodeMi.Location = new System.Drawing.Point(260, 122);
            this.txtInfoCodeMi.Name = "txtInfoCodeMi";
            this.txtInfoCodeMi.Size = new System.Drawing.Size(170, 25);
            this.txtInfoCodeMi.TabIndex = 19;
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.AutoSize = true;
            this.lblInfoCodeMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCodeMa.Location = new System.Drawing.Point(43, 66);
            this.lblInfoCodeMa.Name = "lblInfoCodeMa";
            this.lblInfoCodeMa.Size = new System.Drawing.Size(50, 17);
            this.lblInfoCodeMa.TabIndex = 18;
            this.lblInfoCodeMa.Text = "대분류";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListTitleR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 45);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "▷";
            // 
            // lblListTitleR
            // 
            this.lblListTitleR.AutoSize = true;
            this.lblListTitleR.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblListTitleR.ForeColor = System.Drawing.Color.White;
            this.lblListTitleR.Location = new System.Drawing.Point(44, 10);
            this.lblListTitleR.Name = "lblListTitleR";
            this.lblListTitleR.Size = new System.Drawing.Size(64, 17);
            this.lblListTitleR.TabIndex = 0;
            this.lblListTitleR.Text = "입력정보";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(662, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "사용유무";
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.FormattingEnabled = true;
            this.cboSearchUse.Location = new System.Drawing.Point(741, 19);
            this.cboSearchUse.Name = "cboSearchUse";
            this.cboSearchUse.Size = new System.Drawing.Size(130, 25);
            this.cboSearchUse.TabIndex = 12;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchCode.Location = new System.Drawing.Point(30, 23);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(78, 17);
            this.lblSearchCode.TabIndex = 8;
            this.lblSearchCode.Text = "대분류코드";
            // 
            // ucMaCodeSC
            // 
            this.ucMaCodeSC._Code = "";
            this.ucMaCodeSC._Name = "";
            this.ucMaCodeSC.BackColor = System.Drawing.Color.Transparent;
            this.ucMaCodeSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucMaCodeSC.Location = new System.Drawing.Point(123, 17);
            this.ucMaCodeSC.Margin = new System.Windows.Forms.Padding(4);
            this.ucMaCodeSC.Name = "ucMaCodeSC";
            this.ucMaCodeSC.Size = new System.Drawing.Size(340, 28);
            this.ucMaCodeSC.TabIndex = 14;
            // 
            // frmCodeControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1738, 748);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmCodeControlBase";
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlListR.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lblListTitleR;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.ComboBox cboSearchUse;
        protected System.Windows.Forms.Label lblSearchCode;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label lblInfoNameMa;
        protected System.Windows.Forms.TextBox txtInfoNameMi;
        protected System.Windows.Forms.TextBox txtInfoCodeMi;
        protected System.Windows.Forms.Label lblInfoCodeMa;
        protected System.Windows.Forms.NumericUpDown nudSort;
        protected System.Windows.Forms.SplitContainer splitContainer2;
        protected Controls.ucSearch ucMaCode;
        protected System.Windows.Forms.ComboBox cboUseYN;
        protected Controls.ucSearch ucMaCodeSC;
        protected System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtRemark;
        public System.Windows.Forms.Label label8;
    }
}