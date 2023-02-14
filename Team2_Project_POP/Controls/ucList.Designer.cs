
namespace Team2_Project_POP.Controls
{
    partial class ucList
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
            this.lblState = new System.Windows.Forms.Label();
            this.lblPlanDate = new System.Windows.Forms.Label();
            this.lblProductDate = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblWorkNum = new System.Windows.Forms.Label();
            this.lblPerformanceCnt = new System.Windows.Forms.Label();
            this.lblPlanCnt = new System.Windows.Forms.Label();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.White;
            this.lblState.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblState.Location = new System.Drawing.Point(22, 16);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(158, 176);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "상태";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanDate
            // 
            this.lblPlanDate.BackColor = System.Drawing.Color.White;
            this.lblPlanDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlanDate.Location = new System.Drawing.Point(186, 16);
            this.lblPlanDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanDate.Name = "lblPlanDate";
            this.lblPlanDate.Size = new System.Drawing.Size(158, 85);
            this.lblPlanDate.TabIndex = 1;
            this.lblPlanDate.Text = "계획일자";
            this.lblPlanDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductDate
            // 
            this.lblProductDate.BackColor = System.Drawing.Color.White;
            this.lblProductDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProductDate.Location = new System.Drawing.Point(186, 106);
            this.lblProductDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDate.Name = "lblProductDate";
            this.lblProductDate.Size = new System.Drawing.Size(158, 85);
            this.lblProductDate.TabIndex = 2;
            this.lblProductDate.Text = "생산일자";
            this.lblProductDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.White;
            this.lblProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProduct.Location = new System.Drawing.Point(351, 106);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(158, 85);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "품목명";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkNum
            // 
            this.lblWorkNum.BackColor = System.Drawing.Color.White;
            this.lblWorkNum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWorkNum.Location = new System.Drawing.Point(351, 16);
            this.lblWorkNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkNum.Name = "lblWorkNum";
            this.lblWorkNum.Size = new System.Drawing.Size(158, 85);
            this.lblWorkNum.TabIndex = 3;
            this.lblWorkNum.Text = "작업지시번호";
            this.lblWorkNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerformanceCnt
            // 
            this.lblPerformanceCnt.BackColor = System.Drawing.Color.White;
            this.lblPerformanceCnt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPerformanceCnt.Location = new System.Drawing.Point(517, 106);
            this.lblPerformanceCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerformanceCnt.Name = "lblPerformanceCnt";
            this.lblPerformanceCnt.Size = new System.Drawing.Size(158, 85);
            this.lblPerformanceCnt.TabIndex = 6;
            this.lblPerformanceCnt.Text = "실적 수량";
            this.lblPerformanceCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanCnt
            // 
            this.lblPlanCnt.BackColor = System.Drawing.Color.White;
            this.lblPlanCnt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlanCnt.Location = new System.Drawing.Point(517, 16);
            this.lblPlanCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanCnt.Name = "lblPlanCnt";
            this.lblPlanCnt.Size = new System.Drawing.Size(158, 85);
            this.lblPlanCnt.TabIndex = 5;
            this.lblPlanCnt.Text = "계획 수량";
            this.lblPlanCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.BackColor = System.Drawing.Color.White;
            this.lblFinishTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFinishTime.Location = new System.Drawing.Point(683, 106);
            this.lblFinishTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(158, 85);
            this.lblFinishTime.TabIndex = 8;
            this.lblFinishTime.Text = "생산종료 시간";
            this.lblFinishTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.White;
            this.lblStartTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStartTime.Location = new System.Drawing.Point(683, 16);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(158, 85);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "생산 시작 시간";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemark
            // 
            this.lblRemark.BackColor = System.Drawing.Color.White;
            this.lblRemark.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRemark.Location = new System.Drawing.Point(849, 16);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(419, 176);
            this.lblRemark.TabIndex = 9;
            this.lblRemark.Text = "label10";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblFinishTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblPerformanceCnt);
            this.Controls.Add(this.lblPlanCnt);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblWorkNum);
            this.Controls.Add(this.lblProductDate);
            this.Controls.Add(this.lblPlanDate);
            this.Controls.Add(this.lblState);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucList";
            this.Size = new System.Drawing.Size(1335, 212);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPlanDate;
        private System.Windows.Forms.Label lblProductDate;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblWorkNum;
        private System.Windows.Forms.Label lblPerformanceCnt;
        private System.Windows.Forms.Label lblPlanCnt;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblRemark;
    }
}
