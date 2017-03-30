using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoC.SampleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.SampleFactory.Tests
{
    [TestClass()]
    public class LowerDataProcessFactoryTests
    {
        [TestMethod()]
        public void CreateTest()
        {
           var mLowerDataProcess =IoC.SampleFactory.LowerDataProcessFactory.Create();
            Assert.IsNotNull(mLowerDataProcess);
           var str= mLowerDataProcess.DataProcess("ABC");
            Assert.AreEqual<string>("abc", str);


        }
    }
}