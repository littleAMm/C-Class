
namespace 第三次课堂作业
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
            this.start = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(524, 241);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 57);
            this.start.TabIndex = 0;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(96, 254);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(186, 35);
            this.textResult.TabIndex = 1;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "点击开始即可获得十个随机图形的面积之和";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label1;
    }
}

