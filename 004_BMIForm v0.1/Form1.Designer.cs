﻿namespace _004_BMIForm_v0._1
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
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.lblW = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBMI
            // 
            this.btnBMI.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBMI.Location = new System.Drawing.Point(168, 258);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(100, 30);
            this.btnBMI.TabIndex = 17;
            this.btnBMI.Text = "BMI 계산";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBMI.Location = new System.Drawing.Point(77, 355);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 19);
            this.lblBMI.TabIndex = 16;
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtW.Location = new System.Drawing.Point(168, 180);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 27);
            this.txtW.TabIndex = 15;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblW.Location = new System.Drawing.Point(77, 180);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(65, 19);
            this.lblW.TabIndex = 14;
            this.lblW.Text = "체중(kg)";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtH.Location = new System.Drawing.Point(168, 102);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 27);
            this.txtH.TabIndex = 13;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblH.Location = new System.Drawing.Point(77, 111);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(56, 19);
            this.lblH.TabIndex = 12;
            this.lblH.Text = "키(cm)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(390, 477);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
    }
}

