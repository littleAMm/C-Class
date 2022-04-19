
namespace 第九次课堂作业
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UrlText = new System.Windows.Forms.TextBox();
            this.getdataButton = new System.Windows.Forms.Button();
            this.findPhoneOrEmail = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UrlText
            // 
            this.UrlText.Location = new System.Drawing.Point(48, 34);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(893, 35);
            this.UrlText.TabIndex = 0;
            this.UrlText.Text = "请输入URL地址";
            // 
            // getdataButton
            // 
            this.getdataButton.Location = new System.Drawing.Point(48, 107);
            this.getdataButton.Name = "getdataButton";
            this.getdataButton.Size = new System.Drawing.Size(438, 54);
            this.getdataButton.TabIndex = 1;
            this.getdataButton.Text = "获取网页内容";
            this.getdataButton.UseVisualStyleBackColor = true;
            this.getdataButton.Click += new System.EventHandler(this.getdataButton_Click);
            // 
            // findPhoneOrEmail
            // 
            this.findPhoneOrEmail.Location = new System.Drawing.Point(505, 107);
            this.findPhoneOrEmail.Name = "findPhoneOrEmail";
            this.findPhoneOrEmail.Size = new System.Drawing.Size(436, 54);
            this.findPhoneOrEmail.TabIndex = 2;
            this.findPhoneOrEmail.Text = "查询电话或邮箱";
            this.findPhoneOrEmail.UseVisualStyleBackColor = true;
            this.findPhoneOrEmail.Click += new System.EventHandler(this.findPhoneOrEmail_Click);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(48, 196);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(893, 335);
            this.resultText.TabIndex = 3;
            this.resultText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 568);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.findPhoneOrEmail);
            this.Controls.Add(this.getdataButton);
            this.Controls.Add(this.UrlText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.Button getdataButton;
        private System.Windows.Forms.Button findPhoneOrEmail;
        private System.Windows.Forms.RichTextBox resultText;
    }
}

