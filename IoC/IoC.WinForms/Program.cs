using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoC.WinForms
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Trace.TraceInformation("控制权即将移交给操作系统");
            Trace.TraceError("测试错误日志");
            Trace.TraceWarning("测试警告日志");

            //程序控制权移交给OS
            Application.Run(new Form1());
        }
    }

    public class SLog : TraceListener
    {
        public override void Write(string message)
        {
            
        }

        public override void WriteLine(string message)
        {
            
        }

        public override void WriteLine(string message, string category)
        {
            base.WriteLine(message, category);
        }

       
    }

}
