using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第十次课堂作业
{
    public partial class Form1 : Form
    {
        string search_Baidu = "https://www.baidu.com/baidu?wd=";
        string search_Bing = "https://cn.bing.com/search?form=MOZTSB&pc=MOZI&q=";
        private delegate void myDelegate();
        public Form1()
        {
            InitializeComponent();
        }

        async private void getStringButton_Click(object sender, EventArgs e)
        {
            Task task1 = new Task(() => { search_String(search_Baidu + textBox1, 0); });
            Task task2 = new Task(() => { search_String(search_Bing + textBox1, 1); });
            task1.Start();
            task2.Start();
        }

        private void search_String(String url,int n) { 
            
                WebClient webclient = new WebClient();
                byte[] data = webclient.DownloadData(url);
                string str= Encoding.UTF8.GetString(data);
                if (n == 0) { this.BeginInvoke(new myDelegate(() => { searchForBaidu.Text = str.Substring(0,200); })); }
                else { this.BeginInvoke(new myDelegate(() => { searchForBing.Text = str.Substring(0,200); }));  };
        } 
    }
}
