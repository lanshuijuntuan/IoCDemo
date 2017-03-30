using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.console
{
    /// <summary>
    /// 整个主程序都是在自身的代码控制下，控制权没有发生转移
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入文字......");
            string inputs = Console.ReadLine();
            Console.WriteLine(string.Format("你输入的文字是：{0}", inputs));
            Console.Read();

        }
    }
}
