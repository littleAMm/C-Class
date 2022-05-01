namespace 第十一次课堂作业
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
            this.startButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.ChineseText = new System.Windows.Forms.TextBox();
            this.EnglishText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(196, 284);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 69);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "确定";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(441, 285);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(130, 68);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "下一个";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ChineseText
            // 
            this.ChineseText.BackColor = System.Drawing.SystemColors.Desktop;
            this.ChineseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChineseText.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChineseText.Location = new System.Drawing.Point(308, 93);
            this.ChineseText.Name = "ChineseText";
            this.ChineseText.Size = new System.Drawing.Size(226, 50);
            this.ChineseText.TabIndex = 2;
            // 
            // EnglishText
            // 
            this.EnglishText.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnglishText.Location = new System.Drawing.Point(308, 184);
            this.EnglishText.Name = "EnglishText";
            this.EnglishText.Size = new System.Drawing.Size(226, 57);
            this.EnglishText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(540, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 59);
            this.label1.TabIndex = 4
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(188, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "英文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(188, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "中文";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnglishText);
            this.Controls.Add(this.ChineseText);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "背单词神器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox ChineseText;
        private System.Windows.Forms.TextBox EnglishText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

