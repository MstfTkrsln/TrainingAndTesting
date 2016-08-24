using System;
using ExcelTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ExcelTool.ExcelCreator Excel=new ExcelCreator();


            Excel.CreateExcelFile();
        }
    }
}
