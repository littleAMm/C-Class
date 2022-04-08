namespace CayleyTree
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
            this.button1 = new System.Windows.Forms.Button();
            this.nNumber = new System.Windows.Forms.NumericUpDown();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.nTabControl = new System.Windows.Forms.TabPage();
            this.lengTabControl = new System.Windows.Forms.TabPage();
            this.per1TabControl = new System.Windows.Forms.TabPage();
            this.per2TabControl = new System.Windows.Forms.TabPage();
            this.th1TabControl = new System.Windows.Forms.TabPage();
            this.th2TabControl = new System.Windows.Forms.TabPage();
            this.penTabControl = new System.Windows.Forms.TabPage();
            this.lengNumber = new System.Windows.Forms.NumericUpDown();
            this.per1Number = new System.Windows.Forms.NumericUpDown();
            this.per2Number = new System.Windows.Forms.NumericUpDown();
            this.th1Number = new System.Windows.Forms.NumericUpDown();
            this.th2Number = new System.Windows.Forms.NumericUpDown();
            this.penCheck = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber)).BeginInit();
            this.TabControl.SuspendLayout();
            this.nTabControl.SuspendLayout();
            this.lengTabControl.SuspendLayout();
            this.per1TabControl.SuspendLayout();
            this.per2TabControl.SuspendLayout();
            this.th1TabControl.SuspendLayout();
            this.th2TabControl.SuspendLayout();
            this.penTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2Number)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nNumber
            // 
            this.nNumber.Location = new System.Drawing.Point(15, 71);
            this.nNumber.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nNumber.Name = "nNumber";
            this.nNumber.Size = new System.Drawing.Size(120, 35);
            this.nNumber.TabIndex = 1;
            this.nNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nNumber.ValueChanged += new System.EventHandler(this.nNumber_ValueChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.nTabControl);
            this.TabControl.Controls.Add(this.lengTabControl);
            this.TabControl.Controls.Add(this.per1TabControl);
            this.TabControl.Controls.Add(this.per2TabControl);
            this.TabControl.Controls.Add(this.th1TabControl);
            this.TabControl.Controls.Add(this.th2TabControl);
            this.TabControl.Controls.Add(this.penTabControl);
            this.TabControl.Location = new System.Drawing.Point(47, 470);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(324, 207);
            this.TabControl.TabIndex = 2;
            // 
            // nTabControl
            // 
            this.nTabControl.Controls.Add(this.nNumber);
            this.nTabControl.Location = new System.Drawing.Point(8, 39);
            this.nTabControl.Name = "nTabControl";
            this.nTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.nTabControl.Size = new System.Drawing.Size(308, 160);
            this.nTabControl.TabIndex = 0;
            this.nTabControl.Text = "递归深度";
            this.nTabControl.UseVisualStyleBackColor = true;
            this.nTabControl.Click += new System.EventHandler(this.nTabControl_Click);
            // 
            // lengTabControl
            // 
            this.lengTabControl.Controls.Add(this.lengNumber);
            this.lengTabControl.Location = new System.Drawing.Point(8, 39);
            this.lengTabControl.Name = "lengTabControl";
            this.lengTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.lengTabControl.Size = new System.Drawing.Size(308, 160);
            this.lengTabControl.TabIndex = 1;
            this.lengTabControl.Text = "主干长度";
            this.lengTabControl.UseVisualStyleBackColor = true;
            // 
            // per1TabControl
            // 
            this.per1TabControl.Controls.Add(this.label2);
            this.per1TabControl.Controls.Add(this.per1Number);
            this.per1TabControl.Location = new System.Drawing.Point(8, 39);
            this.per1TabControl.Name = "per1TabControl";
            this.per1TabControl.Padding = new System.Windows.Forms.Padding(3);
            this.per1TabControl.Size = new System.Drawing.Size(308, 160);
            this.per1TabControl.TabIndex = 2;
            this.per1TabControl.Text = "右分支长度比";
            this.per1TabControl.UseVisualStyleBackColor = true;
            // 
            // per2TabControl
            // 
            this.per2TabControl.Controls.Add(this.label1);
            this.per2TabControl.Controls.Add(this.per2Number);
            this.per2TabControl.Location = new System.Drawing.Point(8, 39);
            this.per2TabControl.Name = "per2TabControl";
            this.per2TabControl.Padding = new System.Windows.Forms.Padding(3);
            this.per2TabControl.Size = new System.Drawing.Size(308, 160);
            this.per2TabControl.TabIndex = 3;
            this.per2TabControl.Text = "左分支长度比";
            this.per2TabControl.UseVisualStyleBackColor = true;
            // 
            // th1TabControl
            // 
            this.th1TabControl.Controls.Add(this.th1Number);
            this.th1TabControl.Location = new System.Drawing.Point(8, 39);
            this.th1TabControl.Name = "th1TabControl";
            this.th1TabControl.Padding = new System.Windows.Forms.Padding(3);
            this.th1TabControl.Size = new System.Drawing.Size(308, 160);
            this.th1TabControl.TabIndex = 4;
            this.th1TabControl.Text = "右分支角度";
            this.th1TabControl.UseVisualStyleBackColor = true;
            // 
            // th2TabControl
            // 
            this.th2TabControl.Controls.Add(this.th2Number);
            this.th2TabControl.Location = new System.Drawing.Point(8, 39);
            this.th2TabControl.Name = "th2TabControl";
            this.th2TabControl.Size = new System.Drawing.Size(308, 160);
            this.th2TabControl.TabIndex = 5;
            this.th2TabControl.Text = "左分支角度";
            this.th2TabControl.UseVisualStyleBackColor = true;
            // 
            // penTabControl
            // 
            this.penTabControl.Controls.Add(this.penCheck);
            this.penTabControl.Location = new System.Drawing.Point(8, 39);
            this.penTabControl.Name = "penTabControl";
            this.penTabControl.Size = new System.Drawing.Size(308, 160);
            this.penTabControl.TabIndex = 6;
            this.penTabControl.Text = "画笔颜色";
            this.penTabControl.UseVisualStyleBackColor = true;
            // 
            // lengNumber
            // 
            this.lengNumber.Location = new System.Drawing.Point(6, 56);
            this.lengNumber.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.lengNumber.Name = "lengNumber";
            this.lengNumber.Size = new System.Drawing.Size(120, 35);
            this.lengNumber.TabIndex = 0;
            this.lengNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.lengNumber.ValueChanged += new System.EventHandler(this.lengNumber_ValueChanged);
            // 
            // per1Number
            // 
            this.per1Number.Location = new System.Drawing.Point(6, 55);
            this.per1Number.Name = "per1Number";
            this.per1Number.Size = new System.Drawing.Size(120, 35);
            this.per1Number.TabIndex = 0;
            this.per1Number.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.per1Number.ValueChanged += new System.EventHandler(this.per1Number_ValueChanged);
            // 
            // per2Number
            // 
            this.per2Number.Location = new System.Drawing.Point(6, 48);
            this.per2Number.Name = "per2Number";
            this.per2Number.Size = new System.Drawing.Size(120, 35);
            this.per2Number.TabIndex = 0;
            this.per2Number.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.per2Number.ValueChanged += new System.EventHandler(this.per2Number_ValueChanged);
            // 
            // th1Number
            // 
            this.th1Number.Location = new System.Drawing.Point(23, 41);
            this.th1Number.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.th1Number.Name = "th1Number";
            this.th1Number.Size = new System.Drawing.Size(120, 35);
            this.th1Number.TabIndex = 0;
            this.th1Number.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.th1Number.ValueChanged += new System.EventHandler(this.th1Number_ValueChanged);
            // 
            // th2Number
            // 
            this.th2Number.Location = new System.Drawing.Point(18, 48);
            this.th2Number.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.th2Number.Name = "th2Number";
            this.th2Number.Size = new System.Drawing.Size(120, 35);
            this.th2Number.TabIndex = 0;
            this.th2Number.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.th2Number.ValueChanged += new System.EventHandler(this.th2Number_ValueChanged);
            // 
            // penCheck
            // 
            this.penCheck.FormattingEnabled = true;
            this.penCheck.Items.AddRange(new object[] {
            "红色",
            "蓝色",
            "绿色"});
            this.penCheck.Location = new System.Drawing.Point(15, 42);
            this.penCheck.Name = "penCheck";
            this.penCheck.Size = new System.Drawing.Size(211, 100);
            this.penCheck.TabIndex = 0;
            this.penCheck.SelectedIndexChanged += new System.EventHandler(this.penCheck_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "/100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "/100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 680);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nNumber)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.nTabControl.ResumeLayout(false);
            this.lengTabControl.ResumeLayout(false);
            this.per1TabControl.ResumeLayout(false);
            this.per1TabControl.PerformLayout();
            this.per2TabControl.ResumeLayout(false);
            this.per2TabControl.PerformLayout();
            this.th1TabControl.ResumeLayout(false);
            this.th2TabControl.ResumeLayout(false);
            this.penTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lengNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2Number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nNumber;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage nTabControl;
        private System.Windows.Forms.TabPage lengTabControl;
        private System.Windows.Forms.TabPage per1TabControl;
        private System.Windows.Forms.TabPage per2TabControl;
        private System.Windows.Forms.TabPage th1TabControl;
        private System.Windows.Forms.TabPage th2TabControl;
        private System.Windows.Forms.TabPage penTabControl;
        private System.Windows.Forms.NumericUpDown lengNumber;
        private System.Windows.Forms.NumericUpDown per1Number;
        private System.Windows.Forms.NumericUpDown per2Number;
        private System.Windows.Forms.NumericUpDown th1Number;
        private System.Windows.Forms.NumericUpDown th2Number;
        private System.Windows.Forms.CheckedListBox penCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

