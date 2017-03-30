using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.SampleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("开始处理数据......");
            InputAccept mInputAccept = new InputAccept(UpperDataProcessFactory.Create());
            mInputAccept.Execute("ertetetretrert");
            Console.Read();
        }
    }


    public class InputAccept
    {
        private IDataProcess _dataProcess;

        public void Execute(string input)
        {
            Console.WriteLine(string.Format("开始处理数据：{0}", input));
            var str = _dataProcess.DataProcess(input);
            Console.WriteLine(string.Format("处理后的数据为：{0}", str));
        }

        public InputAccept(IDataProcess dataprocess)
        {
            _dataProcess = dataprocess;
        }
    }



    public interface IDataProcess
    {
        string DataProcess(string input);
    }

    public class UpperDataProcess : IDataProcess
    {
        public string DataProcess(string input)
        {
            return input.ToUpper();
        }
    }

    public class LowerDataProcess : IDataProcess
    {
        public string DataProcess(string input)
        {
            return input.ToLower();
        }
    }



    public static class UpperDataProcessFactory
    {
        public static UpperDataProcess Create()
        {
            return new UpperDataProcess();
        }
    }


    public static class LowerDataProcessFactory
    {
        public static LowerDataProcess Create()
        {
            return new LowerDataProcess();
        }
    }


    public static class GenericFactory
    {
        public static Dictionary<Type, Type> factoryDic = new Dictionary<Type, Type>();

        public static void RegisterTypeFactory(Type objtype, Type factorytype)
        {
            factoryDic.Add(objtype, factorytype);
        }


        public static void Create(Type objType)
        {
            Type facType = factoryDic[objType];
            Object obj = Activator.CreateInstance(facType);

        }
    }







}
