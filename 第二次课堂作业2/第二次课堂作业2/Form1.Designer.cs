
namespace 第二次课堂作业2
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
            this.button = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.TextBox();
            this.rear = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(661, 144);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(142, 84);
            this.button.TabIndex = 0;
            this.button.Text = "确认";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(135, 114);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(100, 35);
            this.top.TabIndex = 2;
            this.top.TextChanged += new System.EventHandler(this.top_TextChanged);
            // 
            // rear
            // 
            this.rear.Location = new System.Drawing.Point(135, 235);
            this.rear.Name = "rear";
            this.rear.Size = new System.Drawing.Size(100, 35);
            this.rear.TabIndex = 3;
            this.rear.TextChanged += new System.EventHandler(this.rear_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(135, 380);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(641, 173);
            this.result.TabIndex = 4;
            this.result.Text = "";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "请输入数值的上限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "请输入数值的下限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "以下为上下限间所有素数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 621);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.rear);
            this.Controls.Add(this.top);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox top;
        private System.Windows.Forms.TextBox rear;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

