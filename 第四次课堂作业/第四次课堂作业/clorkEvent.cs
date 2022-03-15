using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四次课堂作业
{
    public class ClorkEventArgs : EventArgs 
    {
        public string time;
        public ClorkEventArgs(string a) 
        {
            this.time=a;
        }
    }
    
    public class clorkEvent
    {
        public delegate void ClorkEventHandler(object sender, ClorkEventArgs e);
        public event ClorkEventHandler Tick;
        public void doTick(ClorkEventArgs e) { Tick(this,e); }
    }
}
