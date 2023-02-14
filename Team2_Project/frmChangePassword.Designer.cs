
namespace Team2_Project
{
    partial class frmChangePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheckPwd = new System.Windows.Forms.TextBox();
            this.txtNewPW = new System.Windows.Forms.TextBox();
            this.txtCheckNewPW = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "비밀번호 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "신규 비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "신규 비밀번호 확인";
            // 
            // txtCheckPwd
            // 
            this.txtCheckPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckPwd.Location = new System.Drawing.Point(193, 59);
            this.txtCheckPwd.Name = "txtCheckPwd";
            this.txtCheckPwd.Size = new System.Drawing.Size(331, 25);
            this.txtCheckPwd.TabIndex = 3;
            // 
            // txtNewPW
            // 
            this.txtNewPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPW.Location = new System.Drawing.Point(193, 116);
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.Size = new System.Drawing.Size(331, 25);
            this.txtNewPW.TabIndex = 4;
            // 
            // txtCheckNewPW
            // 
            this.txtCheckNewPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckNewPW.Location = new System.Drawing.Point(193, 173);
            this.txtCheckNewPW.Name = "txtCheckNewPW";
            this.txtCheckNewPW.Size = new System.Drawing.Size(331, 25);
            this.txtCheckNewPW.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheck.ImageIndex = 0;
            this.btnCheck.ImageList = this.imageList1;
            this.btnCheck.Location = new System.Drawing.Point(530, 59);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(28, 25);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check (1).png");
            this.imageList1.Images.SetKeyName(1, "check (2).png");
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 421);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtCheckNewPW);
            this.Controls.Add(this.txtNewPW);
            this.Controls.Add(this.txtCheckPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheckPwd;
        private System.Windows.Forms.TextBox txtNewPW;
        private System.Windows.Forms.TextBox txtCheckNewPW;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ImageList imageList1;
    }
}