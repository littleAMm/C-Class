using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第七次课堂作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resultStr = "";
        //记录输入的第一和第二个数字
        int result1 = 0;
        //第一个数字
        int result2 = 0;
        //第二个数字
        double result = 0;
        //结果
        int symbol = 0;
        //符号
        bool ifis = false;
        //是否已经计算过
        private void button8_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "8";
            resultStr += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "4";
            resultStr += "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "1";
            resultStr += "1";
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "2";
            resultStr += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "3";
            resultStr += "3";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "5";
            resultStr += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "6";
            resultStr += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "7";
            resultStr += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "9";
            resultStr += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            resultBox.Text += "0";
            resultStr += "0";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            else {
                resultBox.Text += "+";
                symbol = 1;
                result1 = int.Parse(resultStr);
                resultStr = "";
            }
            
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            else {
                resultBox.Text += "-";
                symbol = 2;
                result1 = int.Parse(resultStr);
                resultStr = "";
            }
            
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            else
            {
                resultBox.Text += "x";
                symbol = 3;
                result1 = int.Parse(resultStr);
                resultStr = "";
            }
           
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (ifis) { zeroButton_Click(sender, e); }
            else {
                resultBox.Text += "/";
                symbol = 4;
                result1 = int.Parse(resultStr);
                resultStr = "";
            }
            
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (!ifis) {
                resultBox.Text += "=";
                result2 = int.Parse(resultStr);
                resultStr = "";
                switch (symbol)
                {
                    case 1:
                        result = result1 + result2;
                        break;
                    case 2:
                        result = result1 - result2;
                        break;
                    case 3:
                        result = result1 * result2;
                        break;
                    case 4:
                        result = result1 / result2;
                        break;
                    case 0:
                        break;
                }
                symbol = 0;
                resultBox.Text += result.ToString();
                ifis = true;
            }
            
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            resultStr = "";
            result2 = 0;
            result1 = 0;
            result = 0;
            symbol = 0;
            ifis = false;
        }
    }
}
