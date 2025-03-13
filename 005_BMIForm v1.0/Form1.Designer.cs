namespace _005_BMIForm_v1._0
{
    partial class Form1
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
            this.picC = new System.Windows.Forms.PictureBox();
            this.btnBMI = new System.Windows.Forms.Button();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).BeginInit();
            this.SuspendLayout();
            // 
            // picC
            // 
            this.picC.Location = new System.Drawing.Point(238, 278);
            this.picC.Name = "picC";
            this.picC.Size = new System.Drawing.Size(63, 70);
            this.picC.TabIndex = 15;
            this.picC.TabStop = false;
            // 
            // btnBMI
            // 
            this.btnBMI.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBMI.Location = new System.Drawing.Point(181, 206);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(120, 27);
            this.btnBMI.TabIndex = 14;
            this.btnBMI.Text = "BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtW.Location = new System.Drawing.Point(181, 161);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(120, 27);
            this.txtW.TabIndex = 13;
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtH.Location = new System.Drawing.Point(181, 118);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(120, 27);
            this.txtH.TabIndex = 12;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(79, 328);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 11;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBMI.Location = new System.Drawing.Point(79, 278);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 20);
            this.lblBMI.TabIndex = 10;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblW.Location = new System.Drawing.Point(79, 161);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(66, 20);
            this.lblW.TabIndex = 9;
            this.lblW.Text = "체중(kg)";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblH.Location = new System.Drawing.Point(77, 118);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(54, 20);
            this.lblH.TabIndex = 8;
            this.lblH.Text = "키(cm)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 482);
            this.Controls.Add(this.picC);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblH);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picC;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblH;
    }
}

