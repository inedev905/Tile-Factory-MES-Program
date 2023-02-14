
namespace Team2_Project
{
    partial class frmNopMiCode
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
            this.dgvMaData = new System.Windows.Forms.DataGridView();
            this.dgvMiData = new System.Windows.Forms.DataGridView();
            this.cboNoptype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.pnlListL.SuspendLayout();
            this.pnlListR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiData)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(662, 17);
            // 
            // cboSearchUse
            // 
            this.cboSearchUse.Location = new System.Drawing.Point(741, 13);
            this.cboSearchUse.Size = new System.Drawing.Size(136, 25);
            this.cboSearchUse.TabIndex = 2;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.Location = new System.Drawing.Point(33, 17);
            this.lblSearchCode.Size = new System.Drawing.Size(124, 17);
            this.lblSearchCode.Text = "비가동 대분류코드";
            // 
            // label9
            // 
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.Text = "비가동 유형";
            // 
            // txtInfoNameMi
            // 
            this.txtInfoNameMi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoNameMi.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtInfoNameMi.MaxLength = 20;
            this.txtInfoNameMi.TabIndex = 5;
            // 
            // txtInfoCodeMi
            // 
            this.txtInfoCodeMi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoCodeMi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtInfoCodeMi.MaxLength = 20;
            this.txtInfoCodeMi.TabIndex = 4;
            // 
            // nudSort
            // 
            this.nudSort.Location = new System.Drawing.Point(802, 219);
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMiData);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cboNoptype);
            this.splitContainer2.Size = new System.Drawing.Size(1177, 702);
            this.splitContainer2.SplitterDistance = 423;
            // 
            // ucMaCode
            // 
            this.ucMaCode.TabIndex = 3;
            this.ucMaCode.BtnClick += new System.EventHandler(this.ucMaCode_BtnClick);
            // 
            // cboUseYN
            // 
            this.cboUseYN.ItemHeight = 17;
            this.cboUseYN.Location = new System.Drawing.Point(793, 62);
            this.cboUseYN.Size = new System.Drawing.Size(136, 25);
            // 
            // ucMaCodeSC
            // 
            this.ucMaCodeSC.Location = new System.Drawing.Point(178, 11);
            this.ucMaCodeSC.TabIndex = 1;
            this.ucMaCodeSC.BtnClick += new System.EventHandler(this.ucCodeSearch_BtnClick);
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Red;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Size = new System.Drawing.Size(300, 89);
            // 
            // pnlSub
            // 
            this.pnlSub.Size = new System.Drawing.Size(1769, 50);
            // 
            // pnlListL
            // 
            this.pnlListL.Controls.Add(this.dgvMaData);
            this.pnlListL.Size = new System.Drawing.Size(588, 702);
            // 
            // pnlListR
            // 
            this.pnlListR.Size = new System.Drawing.Size(1177, 702);
            // 
            // dgvMaData
            // 
            this.dgvMaData.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaData.Location = new System.Drawing.Point(0, 0);
            this.dgvMaData.Name = "dgvMaData";
            this.dgvMaData.RowTemplate.Height = 23;
            this.dgvMaData.Size = new System.Drawing.Size(588, 702);
            this.dgvMaData.TabIndex = 0;
            this.dgvMaData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaData_CellClick);
            // 
            // dgvMiData
            // 
            this.dgvMiData.BackgroundColor = System.Drawing.Color.White;
            this.dgvMiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMiData.Location = new System.Drawing.Point(0, 0);
            this.dgvMiData.Name = "dgvMiData";
            this.dgvMiData.RowTemplate.Height = 23;
            this.dgvMiData.Size = new System.Drawing.Size(1177, 423);
            this.dgvMiData.TabIndex = 1;
            this.dgvMiData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiData_CellClick);
            // 
            // cboNoptype
            // 
            this.cboNoptype.FormattingEnabled = true;
            this.cboNoptype.ItemHeight = 17;
            this.cboNoptype.Location = new System.Drawing.Point(260, 232);
            this.cboNoptype.Name = "cboNoptype";
            this.cboNoptype.Size = new System.Drawing.Size(121, 25);
            this.cboNoptype.TabIndex = 35;
            // 
            // frmNopMiCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1769, 795);
            this.Name = "frmNopMiCode";
            this.Text = "비가동 상세분류코드";
            this.Load += new System.EventHandler(this.frmNopMiCode_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiData;
        private System.Windows.Forms.DataGridView dgvMaData;
        private System.Windows.Forms.ComboBox cboNoptype;
    }
}
