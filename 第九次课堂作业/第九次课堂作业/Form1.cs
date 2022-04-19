using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第九次课堂作业
{
    public partial class Form1 : Form
    {
        string data = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void getdataButton_Click(object sender, EventArgs e)
        {
            resultText.Text = GetHtml.getHtml(UrlText.Text);
            data = resultText.Text;
        }

        private void findPhoneOrEmail_Click(object sender, EventArgs e)
        {
            resultText.Text = GetHtml.getEmail(data);
        }
    }
}
