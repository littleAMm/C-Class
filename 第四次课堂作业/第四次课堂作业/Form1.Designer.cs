
namespace 第四次课堂作业
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
            this.components = new System.ComponentModel.Container();
            this.nowTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alarkTime = new System.Windows.Forms.TextBox();
            this.AlarkButton = new System.Windows.Forms.Button();
            this.eventLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nowTime
            // 
            this.nowTime.Enabled = false;
            this.nowTime.Location = new System.Drawing.Point(200, 130);
            this.nowTime.Name = "nowTime";
            this.nowTime.ReadOnly = true;
            this.nowTime.Size = new System.Drawing.Size(169, 35);
            this.nowTime.TabIndex = 0;
            this.nowTime.TextChanged += new System.EventHandler(this.nowTime_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.shch);
            // 
            // alarkTime
            // 
            this.alarkTime.Location = new System.Drawing.Point(200, 263);
            this.alarkTime.Name = "alarkTime";
            this.alarkTime.Size = new System.Drawing.Size(169, 35);
            this.alarkTime.TabIndex = 1;
            this.alarkTime.TextChanged += new System.EventHandler(this.alarkTime_TextChanged);
            // 
            // AlarkButton
            // 
            this.AlarkButton.Location = new System.Drawing.Point(723, 253);
            this.AlarkButton.Name = "AlarkButton";
            this.AlarkButton.Size = new System.Drawing.Size(138, 50);
            this.AlarkButton.TabIndex = 2;
            this.AlarkButton.Text = "保存闹钟";
            this.AlarkButton.UseVisualStyleBackColor = true;
            this.AlarkButton.Click += new System.EventHandler(this.AlarkButton_Click);
            // 
            // eventLabel
            // 
            this.eventLabel.Enabled = false;
            this.eventLabel.HideSelection = false;
            this.eventLabel.Location = new System.Drawing.Point(200, 428);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(207, 35);
            this.eventLabel.TabIndex = 3;
            this.eventLabel.TextChanged += new System.EventHandler(this.eventLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "请输入闹钟时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "注意与当前时间格式相同哦";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(723, 420);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(138, 52);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "关闭闹钟";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1002, 621);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.AlarkButton);
            this.Controls.Add(this.alarkTime);
            this.Controls.Add(this.nowTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nowTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox alarkTime;
        private System.Windows.Forms.Button AlarkButton;
        private System.Windows.Forms.TextBox eventLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stopButton;
    }
}

