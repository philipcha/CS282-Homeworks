namespace GuessNumber
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ImputBox = new System.Windows.Forms.TextBox();
            this.AnsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConfirmButton.Location = new System.Drawing.Point(304, 90);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(128, 72);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RestartButton.Location = new System.Drawing.Point(304, 220);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(128, 72);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            // 
            // ImputBox
            // 
            this.ImputBox.Location = new System.Drawing.Point(80, 60);
            this.ImputBox.Name = "ImputBox";
            this.ImputBox.Size = new System.Drawing.Size(159, 25);
            this.ImputBox.TabIndex = 2;
            // 
            // AnsBox
            // 
            this.AnsBox.Location = new System.Drawing.Point(80, 120);
            this.AnsBox.Multiline = true;
            this.AnsBox.Name = "AnsBox";
            this.AnsBox.Size = new System.Drawing.Size(159, 233);
            this.AnsBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 380);
            this.Controls.Add(this.AnsBox);
            this.Controls.Add(this.ImputBox);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ConfirmButton);
            this.Name = "MainForm";
            this.Text = "GuessNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.TextBox ImputBox;
        private System.Windows.Forms.TextBox AnsBox;
    }
}

