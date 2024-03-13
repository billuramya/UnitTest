using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace BasicMathTest
{
    //[TestClass]
    //public class UnitTest1
    //{

    //    //[TestMethod]
    //    //public void TestMethod1()
    //    //{
    //    //    BankBalance b = new BankBalance("RAMYA",2);
    //    //    b.Debit(2);
    //    //    Assert.AreEqual(0, b.Balance);
    //    //}
    //    [TestMethod]
    //    public void TestMethod2()
    //    {
    //        var calculator =new GenericCalculation<int>();
    //       int result = calculator.Add(3, 7);
    //        Assert.AreEqual(10, result);
    //    }
    //    [TestMethod]
    //    public void TestMethod3()
    //    {
    //        var calculator = new GenericCalculation<int>();
    //        int result = calculator.sub(10, 7);
    //        Assert.AreEqual(3, result);
    //    }
    //    [TestMethod]
    //    public void TestMethod4()
    //    {
            
    //        var calculator = new GenericCalculation<int>();
    //        int result = calculator.mul(3, 7);
    //        Assert.AreEqual(21, result);
    //    }
    //    [TestMethod]
    //    public void TestMethod5()
    //    {
    //        var calculator = new GenericCalculation<int>();
    //        int result = calculator.div(5, 5);
    //        Assert.AreEqual(1, result);
    //    }
    //}

    [TestClass]
    public class UnitTest2
    {
        //empty strings,null inputs, and special characters.
        [TestMethod]
        public static void TestMethod1()
        {
            StringFormats str =new StringFormats();
            string result = str.stringManipulation(null);
            string expexted = "my name is Ramya";
            Assert.AreEqual(expexted,result);
        }
        [TestMethod]
        public static void TestMethod2() {
            StringFormats str =new StringFormats();
            string val = str.SubString("Ramya");
            Assert.AreEqual("Ramya",val);
        }
        [TestMethod]
        public static void TestMethod3()
        {
            StringFormats str =new StringFormats();
            string val = str.charecterReplacement("to");
            
        }
    }
}
