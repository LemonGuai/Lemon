using ExcelTools;
using ExcelTools.ExcelAttributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestExcelTool
{
    [TestClass]
    public class UnitTestConvertToCollection
    {
        private int data = 10;
        private string filePath = @"D:\Computers\develop\.NetCore\0.Lemon\ToolsTestFiles\alphabet.xlsx";
        string sheet = "sheet1";
        [TestMethod]
        public void TestImportPartSAX()
        {
            var excelHelper = new ExcelHelper() { FilePath = filePath };
            var datas2 = excelHelper.ImportExcelSAXAsync<TestModel>(sheet);
            Assert.AreEqual(data, datas2.Result.Count);
        }

        [TestMethod]
        public void TestImportPartDOM()
        {
            var excelHelper = new ExcelHelper() { FilePath = filePath };
            var datas2 = excelHelper.ImportExcelDOMAsync<TestModel>(sheet);
            Assert.AreEqual(data, datas2.Result.Count);
        }
    }

    public class TestModel
    {
        [ExcelHeader("a")]
        [BoolValueConvert(new string[] { "1" }, new string[] { "0" })]
        public bool A { get; set; }
        [ExcelHeader("b")]
        public int B { get; set; }
        [ExcelHeader("c")]
        public int C { get; set; }
        [ExcelHeader("d")]
        public int D { get; set; }
        [ExcelHeader("e")]
        public int E { get; set; }
        [ExcelHeader("f")]
        public int F { get; set; }
        [ExcelHeader("g")]
        public int G { get; set; }
        [ExcelHeader("h")]
        public int H { get; set; }
        [ExcelHeader("i")]
        public int I { get; set; }
        [ExcelHeader("j")]
        public int J { get; set; }
        [ExcelHeader("k")]
        public int K { get; set; }
        [ExcelHeader("l")]
        public int L { get; set; }
        [ExcelHeader("m")]
        public int M { get; set; }
        [ExcelHeader("n")]
        public int N { get; set; }
        [ExcelHeader("o")]
        public int O { get; set; }
        [ExcelHeader("p")]
        public int P { get; set; }
        [ExcelHeader("q")]
        public int Q { get; set; }
        [ExcelHeader("r")]
        public int R { get; set; }
        [ExcelHeader("s")]
        public int S { get; set; }
        [ExcelHeader("t")]
        public int T { get; set; }
        [ExcelHeader("u")]
        public int U { get; set; }
        [ExcelHeader("v")]
        public int V { get; set; }
        [ExcelHeader("w")]
        public int W { get; set; }
        [ExcelHeader("x")]
        public int X { get; set; }
        [ExcelHeader("y")]
        public int Y { get; set; }
        [ExcelHeader("z")]
        public int Z { get; set; }
    }
}
