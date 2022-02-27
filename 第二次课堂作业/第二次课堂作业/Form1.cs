using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第二次课堂作业
{
    public partial class Form1 : Form
    {
        int Length;
        int[] a;
        private void lengthButton_Click(object sender, EventArgs e)
        {
            Length = int.Parse(arrayLength.Text);
            a = new int[Length];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void arrayLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void arrayList_TextChanged(object sender, EventArgs e)
        {

        }

        private void arraybutton_Click(object sender, EventArgs e)
        {
            string[] s = arrayList.Text.Split(' ');
            for (int i = 0; i < Length; i++) {
                a[i] = int.Parse(s[i]);
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void MAXvalue_Click(object sender, EventArgs e)
        {
            int j = a[0];
            for (int i = 1; i < Length; i++)
            {
                if (a[i] > j) j = a[i];
            }
            result.Text = j.ToString();
        }

        private void MINvalue_Click(object sender, EventArgs e)
        {
            int j = a[0];
            for (int i = 1; i < Length; i++)
            {
                if (a[i] < j) j = a[i];
            }
            result.Text = j.ToString();
        }

        private void averageValue_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < Length; i++)
            {
                sum += a[i];
            }
            result.Text = (sum/Length).ToString();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < Length; i++)
            {
                sum += a[i];
            }
            result.Text = sum .ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
