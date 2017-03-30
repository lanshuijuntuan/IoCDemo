using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoC.DISample
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        static void Main()
        {
            InputAccept mInputAccept = new InputAccept(new UpperDataProcesser());
            mInputAccept.Execute("sdfsfsfafasfd");
            Console.Read();
        }
    }

    public class InputAccept
    {
        private IDataProcesser _dataProcesser;


        public void Execute(string input)
        {
            if(_dataProcesser!=null)
            {
                Console.WriteLine("开始处理数据......");
                Console.WriteLine(string.Format("开始处理数据：{0}", input));
                var proccesserStr=_dataProcesser.ProcceserData(input);
                Console.WriteLine("获取处理完的数据：{0}", proccesserStr);

            }
        }


        public InputAccept(IDataProcesser dataProcesser)
        {
            _dataProcesser = dataProcesser;
        }
    }

    public interface IDataProcesser
    {
        string ProcceserData(string input);

    }


    public class UpperDataProcesser : IDataProcesser
    {
        public string ProcceserData(string input)
        {
            return input.ToUpper();
        }
    }


    public class LowerDataProcesser : IDataProcesser
    {
        public string ProcceserData(string input)
        {
            return input.ToLower();
        }
    }




}
