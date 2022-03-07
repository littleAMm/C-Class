using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第三次课堂作业
{
    public partial class Form1 : Form
    {
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void start_Click(object sender, EventArgs e)
        {
            result = 0;
            Random ra = new Random();
            for (int i = 0; i < 10; i++)
            { 
                int b = ra.Next(1, 4);
                if (b == 1) { shape a = new triangle(); result += a.area; }
                else if (b == 2) { shape a = new rectangle(); result += a.area; }
                else if (b == 3) { shape a = new circle(); result += a.area; }
                else { shape a = new square(); result += a.area; }
            }
            textResult.Text  = result.ToString();
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
