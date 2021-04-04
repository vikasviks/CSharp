using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        public ICalculator c;
        private int num1;
        private int num2;
        private int addresult;
        private int subresult;

        [TestInitialize]
        public void TestSetup() {
            c = new Calculator();
            num1 = 0;
            num2 = 0;
            addresult = 0;
            subresult = 0;
        }

        [TestMethod]
        public void ShouldAddTwoPositiveNumbers()
        {
            num1 = 10; 
            num2 = 5; 
            addresult = 15;
            var result = c.Add(num1, num2);
            Assert.AreEqual(addresult, result);
        }
        [TestMethod]
        public void ShouldReturnFirstNumberIfSecondNumberIsZero()
        {
            num1 = 25;
            var result = c.Add(num1, 0);
            Assert.AreEqual(num1, result);
        }

        [TestMethod]
        public void ShouldReturnSecondNumberIfFirstNumberIsZero()
        {
            num2 = 20;
            var result = c.Add(0,num2);
            Assert.AreEqual(result,num2);
        }

        // for Sub
        [TestMethod]
        public void ShouldSubTwoPositiveNumbers() {
            num1 = 20; 
            num2 = 10; 
            subresult = 10;
            var result = c.Sub(num1, num2);
            Assert.AreEqual(subresult, result);
        }
        
        [TestMethod]
        public void ShouldSubNegativeNumbers()
        {
            num1 = -10;
            num2 = -10;
            subresult = -20;
            var result = c.Sub(num1, num2);
            Assert.AreEqual(subresult, result);
        }

        
    }
}
