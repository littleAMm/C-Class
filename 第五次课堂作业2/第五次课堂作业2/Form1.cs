using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第五次课堂作业2
{
    public partial class Form1 : Form
    {
        Random ra = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            List < int > li= new List<int>();
            for (int i = 0; i < 100; i++) 
            {
                li.Add(ra.Next(1000));
            }
            var query = from i in li orderby i descending select i;
            foreach (var i in query) 
            {
                richTextBox1.Text += i+" ";
            }
            int sum = query.Sum();
            double ave = query.Average();
            richTextBox1.Text += "\r\n" + "求和：" + sum + " " + "平均：" + ave;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
