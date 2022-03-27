
namespace 第六次课堂作业
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
            this.catalog = new System.Windows.Forms.TextBox();
            this.fileName1 = new System.Windows.Forms.TextBox();
            this.fileName2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileName3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // catalog
            // 
            this.catalog.Location = new System.Drawing.Point(108, 133);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(294, 35);
            this.catalog.TabIndex = 0;
            this.catalog.TextChanged += new System.EventHandler(this.catalog_TextChanged);
            // 
            // fileName1
            // 
            this.fileName1.Location = new System.Drawing.Point(108, 243);
            this.fileName1.Name = "fileName1";
            this.fileName1.Size = new System.Drawing.Size(100, 35);
            this.fileName1.TabIndex = 1;
            this.fileName1.TextChanged += new System.EventHandler(this.fileName1_TextChanged);
            // 
            // fileName2
            // 
            this.fileName2.Location = new System.Drawing.Point(108, 306);
            this.fileName2.Name = "fileName2";
            this.fileName2.Size = new System.Drawing.Size(100, 35);
            this.fileName2.TabIndex = 2;
            this.fileName2.TextChanged += new System.EventHandler(this.fileName2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileName3
            // 
            this.fileName3.Location = new System.Drawing.Point(108, 454);
            this.fileName3.Name = "fileName3";
            this.fileName3.Size = new System.Drawing.Size(100, 35);
            this.fileName3.TabIndex = 4;
            this.fileName3.TextChanged += new System.EventHandler(this.fileName3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "请输入目标文件所在的文件夹";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "请输入两个要合并的文件，格式为xxx.tst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "请输入合并后的文件名，格式为xxx.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 649);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileName2);
            this.Controls.Add(this.fileName1);
            this.Controls.Add(this.catalog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox catalog;
        private System.Windows.Forms.TextBox fileName1;
        private System.Windows.Forms.TextBox fileName2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fileName3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

