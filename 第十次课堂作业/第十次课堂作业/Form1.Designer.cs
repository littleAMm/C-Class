namespace 第十次课堂作业
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
            this.getStringButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchForBing = new System.Windows.Forms.RichTextBox();
            this.searchForBaidu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getStringButton
            // 
            this.getStringButton.Location = new System.Drawing.Point(557, 38);
            this.getStringButton.Name = "getStringButton";
            this.getStringButton.Size = new System.Drawing.Size(97, 73);
            this.getStringButton.TabIndex = 0;
            this.getStringButton.Text = "搜索";
            this.getStringButton.UseVisualStyleBackColor = true;
            this.getStringButton.Click += new System.EventHandler(this.getStringButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 35);
            this.textBox1.TabIndex = 1;
            // 
            // searchForBing
            // 
            this.searchForBing.Location = new System.Drawing.Point(384, 208);
            this.searchForBing.Name = "searchForBing";
            this.searchForBing.Size = new System.Drawing.Size(291, 601);
            this.searchForBing.TabIndex = 2;
            this.searchForBing.Text = "";
            // 
            // searchForBaidu
            // 
            this.searchForBaidu.Location = new System.Drawing.Point(36, 208);
            this.searchForBaidu.Name = "searchForBaidu";
            this.searchForBaidu.Size = new System.Drawing.Size(304, 581);
            this.searchForBaidu.TabIndex = 3;
            this.searchForBaidu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "baidu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "bing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 801);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchForBaidu);
            this.Controls.Add(this.searchForBing);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getStringButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getStringButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox searchForBing;
        private System.Windows.Forms.RichTextBox searchForBaidu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

