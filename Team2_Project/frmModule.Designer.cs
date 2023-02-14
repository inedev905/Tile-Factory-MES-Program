
namespace Team2_Project
{
    partial class frmModule
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
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInfoNameMa = new System.Windows.Forms.Label();
            this.txtInfoCodeMa = new System.Windows.Forms.TextBox();
            this.lblInfoCodeMa = new System.Windows.Forms.Label();
            this.ucSearch1 = new Team2_Project.Controls.ucSearch();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlSub.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.comboBox1);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Controls.Add(this.textBox1);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.txtSearchCode);
            this.pnlSub.Controls.Add(this.lblSearchCode);
            this.pnlSub.Size = new System.Drawing.Size(1924, 65);
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
            this.pnlList.Controls.Add(this.dataGridView1);
            this.pnlList.Size = new System.Drawing.Size(1924, 579);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.comboBox2);
            this.pnlArea.Controls.Add(this.label8);
            this.pnlArea.Controls.Add(this.label9);
            this.pnlArea.Controls.Add(this.ucSearch1);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.lblInfoNameMa);
            this.pnlArea.Controls.Add(this.txtInfoCodeMa);
            this.pnlArea.Controls.Add(this.lblInfoCodeMa);
            this.pnlArea.Size = new System.Drawing.Size(1924, 177);
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(115, 19);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(180, 25);
            this.txtSearchCode.TabIndex = 3;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchCode.Location = new System.Drawing.Point(45, 22);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(64, 17);
            this.lblSearchCode.TabIndex = 2;
            this.lblSearchCode.Text = "모듈코드";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(393, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "모듈명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(727, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "사용유무";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(797, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "전체";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(41, 80);
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
            this.label7.Location = new System.Drawing.Point(41, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "*";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.AutoSize = true;
            this.lblInfoNameMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoNameMa.Location = new System.Drawing.Point(64, 80);
            this.lblInfoNameMa.Name = "lblInfoNameMa";
            this.lblInfoNameMa.Size = new System.Drawing.Size(50, 17);
            this.lblInfoNameMa.TabIndex = 25;
            this.lblInfoNameMa.Text = "모듈명";
            // 
            // txtInfoCodeMa
            // 
            this.txtInfoCodeMa.Location = new System.Drawing.Point(236, 22);
            this.txtInfoCodeMa.Name = "txtInfoCodeMa";
            this.txtInfoCodeMa.Size = new System.Drawing.Size(200, 25);
            this.txtInfoCodeMa.TabIndex = 24;
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.AutoSize = true;
            this.lblInfoCodeMa.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCodeMa.Location = new System.Drawing.Point(64, 28);
            this.lblInfoCodeMa.Name = "lblInfoCodeMa";
            this.lblInfoCodeMa.Size = new System.Drawing.Size(64, 17);
            this.lblInfoCodeMa.TabIndex = 23;
            this.lblInfoCodeMa.Text = "모듈코드";
            // 
            // ucSearch1
            // 
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearch1.Location = new System.Drawing.Point(236, 74);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(292, 28);
            this.ucSearch1.TabIndex = 43;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(746, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 25);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.Text = "예";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(565, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(588, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "사용유무";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 579);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 911);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmModule";
            this.Text = "frmModule";
            this.Load += new System.EventHandler(this.frmModule_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox txtSearchCode;
        protected System.Windows.Forms.Label lblSearchCode;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label lblInfoNameMa;
        protected System.Windows.Forms.TextBox txtInfoCodeMa;
        protected System.Windows.Forms.Label lblInfoCodeMa;
        private Controls.ucSearch ucSearch1;
        private System.Windows.Forms.ComboBox comboBox2;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}