using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第二次课堂作业2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int up, down;
        private void top_TextChanged(object sender, EventArgs e)
        {

        }

        private void rear_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            result.Text = "";
            up = int.Parse(top.Text);
            down= int.Parse(rear.Text);
            if (up > down)
            {
                bool flag;
                int b = 0;
                for (int i = down; i <= up; i++)
                {
                    flag = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        if (b % 10 == 0 && b != 0) result.Text += "\r\n";
                        result.Text += i.ToString() + ' ';
                        b++;
                    }
                }
            }
            else {
                result.Text = "输入错误";
            }
            
        }
    }
}
