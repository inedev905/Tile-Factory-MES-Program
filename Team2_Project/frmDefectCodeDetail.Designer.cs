
namespace Team2_Project
{
    partial class frmDefectCodeDetail
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
            this.dgvMa = new System.Windows.Forms.DataGridView();
            this.dgvMi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.pnlListL.SuspendLayout();
            this.pnlListR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMi)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(583, 20);
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.Location = new System.Drawing.Point(662, 16);
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.Location = new System.Drawing.Point(30, 20);
            this.lblSearchCode.Size = new System.Drawing.Size(110, 17);
            this.lblSearchCode.Text = "불량현상 대분류";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(610, 66);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(642, 66);
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.Text = "불량현상 상세분류명";
            // 
            // lblInfoNameMa
            // 
            this.lblInfoNameMa.Size = new System.Drawing.Size(152, 17);
            this.lblInfoNameMa.Text = "불량현상 상세분류코드";
            // 
            // txtInfoNameMi
            // 
            this.txtInfoNameMi.Location = new System.Drawing.Point(210, 182);
            // 
            // txtInfoCodeMi
            // 
            this.txtInfoCodeMi.Location = new System.Drawing.Point(210, 122);
            // 
            // lblInfoCodeMa
            // 
            this.lblInfoCodeMa.Size = new System.Drawing.Size(110, 17);
            this.lblInfoCodeMa.Text = "불량현상 대분류";
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMi);
            this.splitContainer2.Size = new System.Drawing.Size(1156, 645);
            this.splitContainer2.SplitterDistance = 408;
            // 
            // ucMaCode
            // 
            this.ucMaCode.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMaCode.Location = new System.Drawing.Point(210, 62);
            this.ucMaCode.Size = new System.Drawing.Size(340, 30);
            // 
            // cboUseYN
            // 
            this.cboUseYN.Location = new System.Drawing.Point(721, 62);
            // 
            // ucMaCodeSC
            // 
            this.ucMaCodeSC.Location = new System.Drawing.Point(183, 17);
            this.ucMaCodeSC.BtnClick += new System.EventHandler(this.ucMaCodeSC_BtnClick);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(610, 126);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(721, 124);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(642, 126);
            // 
            // pnlSub
            // 
            this.pnlSub.Size = new System.Drawing.Size(1738, 60);
            // 
            // pnlListL
            // 
            this.pnlListL.Controls.Add(this.dgvMa);
            this.pnlListL.Size = new System.Drawing.Size(578, 645);
            // 
            // pnlListR
            // 
            this.pnlListR.Size = new System.Drawing.Size(1156, 645);
            // 
            // dgvMa
            // 
            this.dgvMa.BackgroundColor = System.Drawing.Color.White;
            this.dgvMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMa.Location = new System.Drawing.Point(0, 0);
            this.dgvMa.Name = "dgvMa";
            this.dgvMa.RowTemplate.Height = 23;
            this.dgvMa.Size = new System.Drawing.Size(578, 645);
            this.dgvMa.TabIndex = 0;
            this.dgvMa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMa_CellClick);
            // 
            // dgvMi
            // 
            this.dgvMi.BackgroundColor = System.Drawing.Color.White;
            this.dgvMi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMi.Location = new System.Drawing.Point(0, 0);
            this.dgvMi.Name = "dgvMi";
            this.dgvMi.RowTemplate.Height = 23;
            this.dgvMi.Size = new System.Drawing.Size(1156, 408);
            this.dgvMi.TabIndex = 0;
            this.dgvMi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMi_CellClick);
            // 
            // frmDefectCodeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1738, 748);
            this.Name = "frmDefectCodeDetail";
            this.Load += new System.EventHandler(this.frmDefectCodeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlListL.ResumeLayout(false);
            this.pnlListR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMi;
        private System.Windows.Forms.DataGridView dgvMa;
    }
}
