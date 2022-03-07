using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第三次课堂作业
{
    public interface shape 
    { 
        int length { get; }
        int wide { get; }
        double area { get; }
        double getArea();
        void ifRight();
    }
    public class square : shape 
    {
        public int length { get; }
        public int wide { get; }
        public double area { get; }
        public double getArea() 
        {
            return length * wide;
        }
        public void ifRight() 
        {
            
        }
        public square() 
        {
            Random ra = new Random() ;
            this.wide =this.length= ra.Next(1, 10);
            this.area = getArea();
        }
    }
    public class circle : shape
    {
        public int length { get; }
        public int wide { get; }
        public double area { get; }
        public double getArea()
        {
            return length * length *3.14;
        }
        public void ifRight()
        {

        }
        public circle()
        {
            Random ra = new Random();
            this.wide = 0;
            this.length = ra.Next(1, 10);
            this.area = getArea();
        }
    }
    public class rectangle : shape
    {
        public int length { get; }
        public int wide { get; }
        public double area { get; }
        public double getArea()
        {
            return length * wide;
        }
        public void ifRight()
        {

        }
        public rectangle ()
        {
            Random ra = new Random();
            this.wide = ra.Next(1, 10);
            this.length = ra.Next(1, 10);
            this.area = getArea();
        }
    }
    public class triangle : shape
    {
        public int length { get; }
        public int wide { get; }
        public double area { get; }
        public double getArea()
        {
            return length * wide*0.5;
        }
        public void ifRight()
        {

        }
        public triangle()
        {
            Random ra = new Random();
            this.wide = ra.Next(1, 10);
            this.length = ra.Next(1, 10);
            this.area = getArea();
        }
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
