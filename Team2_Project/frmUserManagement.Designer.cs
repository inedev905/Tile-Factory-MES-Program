
namespace Team2_Project
{
    partial class frmUserManagement
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
            this.dgvUserGroup = new System.Windows.Forms.DataGridView();
            this.dgvUserAuthority = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ucSearch1 = new Team2_Project.Controls.ucSearch();
            this.pnlSub.SuspendLayout();
            this.pnlListL.SuspendLayout();
            this.pnlArea.SuspendLayout();
            this.pnlListR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAuthority)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.ucSearch1);
            this.pnlSub.Controls.Add(this.comboBox3);
            this.pnlSub.Controls.Add(this.label10);
            this.pnlSub.Controls.Add(this.label8);
            this.pnlSub.Size = new System.Drawing.Size(1382, 65);
            // 
            // pnlListL
            // 
            this.pnlListL.Controls.Add(this.dgvUserGroup);
            this.pnlListL.Size = new System.Drawing.Size(459, 346);
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.comboBox2);
            this.pnlArea.Controls.Add(this.comboBox1);
            this.pnlArea.Controls.Add(this.textBox2);
            this.pnlArea.Controls.Add(this.textBox1);
            this.pnlArea.Controls.Add(this.label7);
            this.pnlArea.Controls.Add(this.label6);
            this.pnlArea.Controls.Add(this.label4);
            this.pnlArea.Controls.Add(this.label1);
            this.pnlArea.Size = new System.Drawing.Size(459, 182);
            // 
            // lblAreaTitle
            // 
            this.lblAreaTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTitle.Location = new System.Drawing.Point(45, 10);
            this.lblAreaTitle.Size = new System.Drawing.Size(114, 17);
            this.lblAreaTitle.Text = "사용자 그룹 정보";
            // 
            // lblListTitleL
            // 
            this.lblListTitleL.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblListTitleL.Location = new System.Drawing.Point(45, 10);
            this.lblListTitleL.Size = new System.Drawing.Size(114, 17);
            this.lblListTitleL.Text = "사용자 그룹 관리";
            // 
            // pnlListR
            // 
            this.pnlListR.Controls.Add(this.dgvUserAuthority);
            this.pnlListR.Size = new System.Drawing.Size(919, 575);
            // 
            // lblListTitleR
            // 
            this.lblListTitleR.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitleR.Location = new System.Drawing.Point(45, 10);
            this.lblListTitleR.Size = new System.Drawing.Size(68, 17);
            this.lblListTitleR.Text = "권한 설정";
            // 
            // dgvUserGroup
            // 
            this.dgvUserGroup.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserGroup.Location = new System.Drawing.Point(0, 0);
            this.dgvUserGroup.Name = "dgvUserGroup";
            this.dgvUserGroup.RowTemplate.Height = 23;
            this.dgvUserGroup.Size = new System.Drawing.Size(459, 346);
            this.dgvUserGroup.TabIndex = 0;
            // 
            // dgvUserAuthority
            // 
            this.dgvUserAuthority.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserAuthority.Location = new System.Drawing.Point(0, 0);
            this.dgvUserAuthority.Name = "dgvUserAuthority";
            this.dgvUserAuthority.RowTemplate.Height = 23;
            this.dgvUserAuthority.Size = new System.Drawing.Size(919, 575);
            this.dgvUserAuthority.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 그룹코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "사용자 그룹명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "사용 여부";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Admin 여부";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 25);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 25);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 25);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(268, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 25);
            this.comboBox2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(32, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "사용자 그룹코드";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(534, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(105, 25);
            this.comboBox3.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(460, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "사용 여부";
            // 
            // ucSearch1
            // 
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearch1.Location = new System.Drawing.Point(149, 17);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(292, 28);
            this.ucSearch1.TabIndex = 11;
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1382, 683);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmUserManagement";
            this.Text = "사용자 관리";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlListL.ResumeLayout(false);
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.pnlListR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAuthority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserGroup;
        private System.Windows.Forms.DataGridView dgvUserAuthority;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucSearch1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
    }
}
