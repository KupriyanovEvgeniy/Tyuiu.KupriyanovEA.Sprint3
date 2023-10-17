using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.KupriyanovEA.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string value = "4n5nvf 56 bgy";
            char item = 'n';

            string res = ds.ReplaceNumOnChar(value, item);

            string wait = "nnnnvf nn bgy";

            Assert.AreEqual(wait, res);

        }
    }
}
