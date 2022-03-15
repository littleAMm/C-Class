using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第四次课堂作业
{
    public partial class Form1 : Form
    {
        bool flag = false;
        int a = 0;
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  void nowTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void shch(object sender, EventArgs e)
        {
            nowTime.Text= DateTime.Now.ToLongTimeString().ToString();
            if (flag)
            {
                eventLabel.Text = "响铃";
                a += 1;
                if (a >= 10) flag = false;
            }
            else 
            {
                a = 0;
                eventLabel.Text = "闹钟正在走时";
            }
        }

        private void alarkTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlarkButton_Click(object sender, EventArgs e)
        {
            timer.Elapsed += new System.Timers.ElapsedEventHandler(whetherAlark);
            timer.Start();
        }
        private void whetherAlark(object sender, EventArgs e) 
        {
            ClorkEventArgs cea = new ClorkEventArgs(alarkTime.Text);
            clorkEvent ce = new clorkEvent();
            ce.Tick += new clorkEvent.ClorkEventHandler(alarkStart);
            if (nowTime.Text == alarkTime.Text) 
            {
                ce.doTick(cea);
                timer.Stop();
            }
        
        }
        private void alarkStart(object sender,ClorkEventArgs e) 
        {
            //eventLabel.Text = "闹钟正在响铃";
            flag = true;
        }

        private void eventLabel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            flag = false;
            a = 0;
            eventLabel.Text = "闹钟正在走时";
            alarkTime.Text = " ";

        }
    }
}
