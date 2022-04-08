using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 10;
        int leng1 = 100;
        int a = 1;
        
        void drawCayleyTree(int n,
                double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (a) {
                case 0:
                    graphics.DrawLine(
                Pens.Red,
                (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 1:
                    graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 2:
                    graphics.DrawLine(
                Pens.Green,
                (int)x0, (int)y0, (int)x1, (int)y1);
                    break;

            }
            graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nTabControl_Click(object sender, EventArgs e)
        {

        }
        //为了每一次改变值都会让图形发生变化
        private void nNumber_ValueChanged(object sender, EventArgs e)
        {
            n = (int)nNumber.Value;
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }

        private void lengNumber_ValueChanged(object sender, EventArgs e)
        {
            leng1= (int)lengNumber.Value;
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }

        private void per1Number_ValueChanged(object sender, EventArgs e)
        {
            per1= (double)(per1Number.Value/100);
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }

        private void per2Number_ValueChanged(object sender, EventArgs e)
        {
            per2 = (double)(per2Number.Value / 100);
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }

        private void th1Number_ValueChanged(object sender, EventArgs e)
        {
            th1 = (double)(th1Number.Value) * Math.PI / 180;
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }

        private void th2Number_ValueChanged(object sender, EventArgs e)
        {
            th2 = (double)(th2Number.Value) * Math.PI / 180;
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }

        private void penCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = penCheck.CheckedItems.Count;
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng1, -Math.PI / 2);
        }
    }
}
