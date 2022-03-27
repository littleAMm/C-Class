using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 第六次课堂作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void catalog_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file1 = new FileStream(catalog.Text + "\\" + fileName1.Text, FileMode.OpenOrCreate, FileAccess.Read);
            FileStream file2 = new FileStream(catalog.Text + "\\" + fileName2.Text, FileMode.OpenOrCreate, FileAccess.Read);
            FileStream file3 = new FileStream(catalog.Text + "\\data\\" + fileName3.Text, FileMode.Create, FileAccess.Write);
            StreamReader File1 = new StreamReader(file1, System.Text.Encoding.Default);
            StreamReader File2 = new StreamReader(file2, System.Text.Encoding.Default);
            StreamWriter File3 = new StreamWriter(file3, System.Text.Encoding.Default);
            for (string s = File1.ReadLine(); s != null; s = File1.ReadLine())
            {
                File3.WriteLine(s);
            }
            for (string s = File2.ReadLine(); s != null; s = File2.ReadLine())
            {
                File3.WriteLine(s);
            }
            File1.Close();
            File2.Close();
            File3.Close();
        }

        private void fileName3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
