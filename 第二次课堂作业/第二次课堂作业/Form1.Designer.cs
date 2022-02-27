
namespace 第二次课堂作业
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
            this.arrayLength = new System.Windows.Forms.TextBox();
            this.lengthButton = new System.Windows.Forms.Button();
            this.arrayList = new System.Windows.Forms.TextBox();
            this.arraybutton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.MAXvalue = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.averageValue = new System.Windows.Forms.Button();
            this.MINvalue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arrayLength
            // 
            this.arrayLength.Location = new System.Drawing.Point(156, 104);
            this.arrayLength.Name = "arrayLength";
            this.arrayLength.Size = new System.Drawing.Size(155, 35);
            this.arrayLength.TabIndex = 0;
            this.arrayLength.TextChanged += new System.EventHandler(this.arrayLength_TextChanged);
            // 
            // lengthButton
            // 
            this.lengthButton.Location = new System.Drawing.Point(526, 102);
            this.lengthButton.Name = "lengthButton";
            this.lengthButton.Size = new System.Drawing.Size(92, 35);
            this.lengthButton.TabIndex = 1;
            this.lengthButton.Text = "确认";
            this.lengthButton.UseVisualStyleBackColor = true;
            this.lengthButton.Click += new System.EventHandler(this.lengthButton_Click);
            // 
            // arrayList
            // 
            this.arrayList.Location = new System.Drawing.Point(156, 233);
            this.arrayList.Name = "arrayList";
            this.arrayList.Size = new System.Drawing.Size(155, 35);
            this.arrayList.TabIndex = 2;
            this.arrayList.TextChanged += new System.EventHandler(this.arrayList_TextChanged);
            // 
            // arraybutton
            // 
            this.arraybutton.Location = new System.Drawing.Point(526, 233);
            this.arraybutton.Name = "arraybutton";
            this.arraybutton.Size = new System.Drawing.Size(92, 35);
            this.arraybutton.TabIndex = 3;
            this.arraybutton.Text = "确认";
            this.arraybutton.UseVisualStyleBackColor = true;
            this.arraybutton.Click += new System.EventHandler(this.arraybutton_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(156, 368);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(155, 35);
            this.result.TabIndex = 4;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // MAXvalue
            // 
            this.MAXvalue.Location = new System.Drawing.Point(78, 461);
            this.MAXvalue.Name = "MAXvalue";
            this.MAXvalue.Size = new System.Drawing.Size(119, 69);
            this.MAXvalue.TabIndex = 5;
            this.MAXvalue.Text = "最大值";
            this.MAXvalue.UseVisualStyleBackColor = true;
            this.MAXvalue.Click += new System.EventHandler(this.MAXvalue_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(672, 461);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(117, 69);
            this.sum.TabIndex = 6;
            this.sum.Text = "数组之和";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // averageValue
            // 
            this.averageValue.Location = new System.Drawing.Point(462, 461);
            this.averageValue.Name = "averageValue";
            this.averageValue.Size = new System.Drawing.Size(114, 69);
            this.averageValue.TabIndex = 7;
            this.averageValue.Text = "平均值";
            this.averageValue.UseVisualStyleBackColor = true;
            this.averageValue.Click += new System.EventHandler(this.averageValue_Click);
            // 
            // MINvalue
            // 
            this.MINvalue.Location = new System.Drawing.Point(267, 461);
            this.MINvalue.Name = "MINvalue";
            this.MINvalue.Size = new System.Drawing.Size(116, 69);
            this.MINvalue.TabIndex = 8;
            this.MINvalue.Text = "最小值";
            this.MINvalue.UseVisualStyleBackColor = true;
            this.MINvalue.Click += new System.EventHandler(this.MINvalue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "请输入数组长度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "请输入数组元素，中间用空格隔开";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "请选择结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MINvalue);
            this.Controls.Add(this.averageValue);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.MAXvalue);
            this.Controls.Add(this.result);
            this.Controls.Add(this.arraybutton);
            this.Controls.Add(this.arrayList);
            this.Controls.Add(this.lengthButton);
            this.Controls.Add(this.arrayLength);
            this.Name = "Form1";
            this.Text = "数组计算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayLength;
        private System.Windows.Forms.Button lengthButton;
        private System.Windows.Forms.TextBox arrayList;
        private System.Windows.Forms.Button arraybutton;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button MAXvalue;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button averageValue;
        private System.Windows.Forms.Button MINvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

