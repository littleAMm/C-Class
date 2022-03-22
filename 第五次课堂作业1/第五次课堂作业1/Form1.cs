using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace 第五次课堂作业1
{
    public partial class Form1 : Form
    {
        int[] prim = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 ,100};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showNum_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Hashtable ht = new Hashtable();
            for (int i = 0; prim[i] <100; i++)
            {
                ht.Add(prim[i], i);
            }
            int num;
            for (int i = 6; i < 101; i += 2) 
            {
                for (int j = 0; prim[j] < 100; j++)
                {
                    if (ht.Contains(i - prim[j])) 
                    {
                        num = i-prim[j];
                        richTextBox1.Text += i + "=" + prim[j] + "+" + num;
                        richTextBox1.Text += "\r\n";
                        break;
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
