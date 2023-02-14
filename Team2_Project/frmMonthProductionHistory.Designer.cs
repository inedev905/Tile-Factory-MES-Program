
namespace Team2_Project
{
    partial class frmMonthProductionHistory
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ucSearch1 = new Team2_Project.Controls.ucSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSub.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.label3);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Controls.Add(this.ucSearch1);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.dtpFrom);
            this.pnlSub.Size = new System.Drawing.Size(1834, 65);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Size = new System.Drawing.Size(1834, 43);
            // 
            // pnlList
            // 
            this.pnlList.Size = new System.Drawing.Size(1834, 803);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(60, 18);
            this.lblTitle.Text = "조회내역";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-mm";
            this.dtpFrom.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(110, 18);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(106, 25);
            this.dtpFrom.TabIndex = 73;
            this.dtpFrom.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(29, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "조회년월";
            // 
            // ucSearch1
            // 
            this.ucSearch1._Code = "";
            this.ucSearch1._Name = "";
            this.ucSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearch1.Location = new System.Drawing.Point(331, 18);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(340, 28);
            this.ucSearch1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "품목";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(1619, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 53);
            this.label3.TabIndex = 79;
            this.label3.Text = "(분석소재)\r\n- 월별 제품 생산 비율\r\n- 월별 불량 사유 비율\r\n";
            // 
            // frmMonthProductionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMonthProductionHistory";
            this.Text = "월별 생산현황";
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private Controls.ucSearch ucSearch1;
        private System.Windows.Forms.Label label3;
    }
}
