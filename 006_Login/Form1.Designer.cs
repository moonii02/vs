namespace _006_Login
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.btnL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(33, 69);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "아이디";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPW.Location = new System.Drawing.Point(35, 117);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(60, 17);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "패스워드";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(114, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 25);
            this.txtID.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPW.Location = new System.Drawing.Point(114, 109);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(149, 25);
            this.txtPW.TabIndex = 3;
            // 
            // txtRe
            // 
            this.txtRe.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRe.Location = new System.Drawing.Point(114, 214);
            this.txtRe.Name = "txtRe";
            this.txtRe.ReadOnly = true;
            this.txtRe.Size = new System.Drawing.Size(149, 25);
            this.txtRe.TabIndex = 4;
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnL.Location = new System.Drawing.Point(191, 159);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(72, 30);
            this.btnL.TabIndex = 5;
            this.btnL.Text = "로그인";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 313);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.txtRe);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtRe;
        private System.Windows.Forms.Button btnL;
    }
}

