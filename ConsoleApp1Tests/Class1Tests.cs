using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void Minus_Input_First_3_Second_2_Return_1()
        {
            int a = 0;

            Console.WriteLine("123");
            Calculator target = new Calculator();
            int firstNum = 3;
            int secondNum = 2;
            int expected = 1;
            int actual;
            actual = target.Minus(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("驗證這個方法的正確性。");
        }
    }
}