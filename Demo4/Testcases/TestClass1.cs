using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo4.CustomizedLibs;

namespace Demo4.Testcases
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestMethod()
        {
            Dictionary<string, string> dict = BrowserSetUp.getFireFoxProfile();
            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
