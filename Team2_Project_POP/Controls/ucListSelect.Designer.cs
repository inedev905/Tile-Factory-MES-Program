
namespace Team2_Project_POP.Controls
{
    partial class ucListSelect
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(1217, 10);
            this.lbl3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 80);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "그   룹";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(377, 10);
            this.lbl2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 80);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "작 업 장";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(24, 10);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 80);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "상  태";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucListSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ucListSelect";
            this.Size = new System.Drawing.Size(1800, 100);
            this.Load += new System.EventHandler(this.ucListSelect_Load);
            this.Click += new System.EventHandler(this.ucListSelect_Click);
            this.MouseEnter += new System.EventHandler(this.pnl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucListSelect_MouseLeave);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}
