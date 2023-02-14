
namespace Team2_Project
{
    partial class frmPlan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.pnlTitleR = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblListTitleR = new System.Windows.Forms.Label();
            this.dgvWcPlan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboReqStat = new System.Windows.Forms.ComboBox();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.dtpReqTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpReqFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ucProd = new Team2_Project.Controls.ucSearch();
            this.ucWC = new Team2_Project.Controls.ucSearch();
            this.ucProd2 = new Team2_Project.Controls.ucSearch();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.pnlTitleR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWcPlan)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1314, 692);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.pnlSub);
            this.tabPage1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1306, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "생산요청";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 124);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvReq);
            this.splitContainer1.Panel1.Controls.Add(this.pnlTitleR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvWcPlan);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1298, 534);
            this.splitContainer1.SplitterDistance = 971;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgvReq
            // 
            this.dgvReq.BackgroundColor = System.Drawing.Color.White;
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReq.Location = new System.Drawing.Point(0, 43);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.RowTemplate.Height = 23;
            this.dgvReq.Size = new System.Drawing.Size(971, 491);
            this.dgvReq.TabIndex = 4;
            this.dgvReq.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReq_CellDoubleClick);
            this.dgvReq.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReq_CellEndEdit);
            this.dgvReq.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvReq_EditingControlShowing);
            // 
            // pnlTitleR
            // 
            this.pnlTitleR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.pnlTitleR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitleR.Controls.Add(this.label2);
            this.pnlTitleR.Controls.Add(this.lblListTitleR);
            this.pnlTitleR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleR.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleR.Name = "pnlTitleR";
            this.pnlTitleR.Size = new System.Drawing.Size(971, 43);
            this.pnlTitleR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "▷";
            // 
            // lblListTitleR
            // 
            this.lblListTitleR.AutoSize = true;
            this.lblListTitleR.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblListTitleR.ForeColor = System.Drawing.Color.White;
            this.lblListTitleR.Location = new System.Drawing.Point(40, 10);
            this.lblListTitleR.Name = "lblListTitleR";
            this.lblListTitleR.Size = new System.Drawing.Size(64, 17);
            this.lblListTitleR.TabIndex = 0;
            this.lblListTitleR.Text = "조회내역";
            // 
            // dgvWcPlan
            // 
            this.dgvWcPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvWcPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWcPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWcPlan.Location = new System.Drawing.Point(0, 43);
            this.dgvWcPlan.Name = "dgvWcPlan";
            this.dgvWcPlan.RowTemplate.Height = 23;
            this.dgvWcPlan.Size = new System.Drawing.Size(323, 491);
            this.dgvWcPlan.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 43);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "▷";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "라인별 계획수량";
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.White;
            this.pnlSub.BackgroundImage = global::Team2_Project.Properties.Resources.pnl1;
            this.pnlSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSub.Controls.Add(this.btnAdd);
            this.pnlSub.Controls.Add(this.cboReqStat);
            this.pnlSub.Controls.Add(this.dtpDue);
            this.pnlSub.Controls.Add(this.dtpReqTo);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.dtpReqFrom);
            this.pnlSub.Controls.Add(this.ucProd);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label3);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSub.Location = new System.Drawing.Point(4, 4);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(1298, 120);
            this.pnlSub.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1108, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 71);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "생산계획 생성";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboReqStat
            // 
            this.cboReqStat.FormattingEnabled = true;
            this.cboReqStat.Location = new System.Drawing.Point(542, 69);
            this.cboReqStat.Name = "cboReqStat";
            this.cboReqStat.Size = new System.Drawing.Size(130, 25);
            this.cboReqStat.TabIndex = 9;
            // 
            // dtpDue
            // 
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(123, 69);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(125, 25);
            this.dtpDue.TabIndex = 8;
            this.dtpDue.ValueChanged += new System.EventHandler(this.dtpDue_ValueChanged);
            // 
            // dtpReqTo
            // 
            this.dtpReqTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqTo.Location = new System.Drawing.Point(278, 23);
            this.dtpReqTo.Name = "dtpReqTo";
            this.dtpReqTo.Size = new System.Drawing.Size(125, 25);
            this.dtpReqTo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(254, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "~";
            // 
            // dtpReqFrom
            // 
            this.dtpReqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqFrom.Location = new System.Drawing.Point(123, 23);
            this.dtpReqFrom.Name = "dtpReqFrom";
            this.dtpReqFrom.Size = new System.Drawing.Size(125, 25);
            this.dtpReqFrom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(463, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "품목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(463, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "반영완료";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "납기일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "생산요청일";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPlan);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1306, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "생산계획";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPlan
            // 
            this.dgvPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(4, 167);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.Size = new System.Drawing.Size(1298, 495);
            this.dgvPlan.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1298, 43);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "▷";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "조회내역";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::Team2_Project.Properties.Resources.pnl1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSplit);
            this.panel2.Controls.Add(this.ucWC);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.ucProd2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtpMonth);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 120);
            this.panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1116, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 40);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "생산계획 마감취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(962, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "생산계획 마감";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSplit
            // 
            this.btnSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSplit.BackColor = System.Drawing.Color.White;
            this.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplit.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSplit.ForeColor = System.Drawing.Color.Black;
            this.btnSplit.Location = new System.Drawing.Point(1116, 64);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(148, 40);
            this.btnSplit.TabIndex = 12;
            this.btnSplit.Text = "생산계획 분할";
            this.btnSplit.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(523, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "작업장";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(30, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "품목";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "yyyy-MM";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(123, 23);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(125, 25);
            this.dtpMonth.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(30, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "생산계획월";
            // 
            // ucProd
            // 
            this.ucProd._Code = "";
            this.ucProd._Name = "";
            this.ucProd.BackColor = System.Drawing.Color.Transparent;
            this.ucProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProd.Location = new System.Drawing.Point(542, 23);
            this.ucProd.Margin = new System.Windows.Forms.Padding(4);
            this.ucProd.Name = "ucProd";
            this.ucProd.Size = new System.Drawing.Size(340, 28);
            this.ucProd.TabIndex = 4;
            this.ucProd.BtnClick += new System.EventHandler(this.ucProd_BtnClick);
            // 
            // ucWC
            // 
            this.ucWC._Code = "";
            this.ucWC._Name = "";
            this.ucWC.BackColor = System.Drawing.Color.Transparent;
            this.ucWC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucWC.Location = new System.Drawing.Point(588, 69);
            this.ucWC.Margin = new System.Windows.Forms.Padding(4);
            this.ucWC.Name = "ucWC";
            this.ucWC.Size = new System.Drawing.Size(340, 28);
            this.ucWC.TabIndex = 11;
            // 
            // ucProd2
            // 
            this.ucProd2._Code = "";
            this.ucProd2._Name = "";
            this.ucProd2.BackColor = System.Drawing.Color.Transparent;
            this.ucProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucProd2.Location = new System.Drawing.Point(123, 69);
            this.ucProd2.Margin = new System.Windows.Forms.Padding(4);
            this.ucProd2.Name = "ucProd2";
            this.ucProd2.Size = new System.Drawing.Size(340, 28);
            this.ucProd2.TabIndex = 9;
            // 
            // frmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 692);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlan";
            this.Text = "생산계획";
            this.Load += new System.EventHandler(this.frmPlan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            this.pnlTitleR.ResumeLayout(false);
            this.pnlTitleR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWcPlan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        protected System.Windows.Forms.Panel pnlSub;
        private Controls.ucSearch ucProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboReqStat;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.DateTimePicker dtpReqTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpReqFrom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlTitleR;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lblListTitleR;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.DataGridView dgvWcPlan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSplit;
        private Controls.ucSearch ucWC;
        private System.Windows.Forms.Label label13;
        private Controls.ucSearch ucProd2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvPlan;
    }
}