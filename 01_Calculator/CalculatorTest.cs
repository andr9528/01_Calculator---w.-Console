using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[] { };
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers = new int[1];
            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers = new int[2];
            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            int[] numbers = new int[] { };
            Assert.AreEqual(1, Calculator.Multiply(numbers));

            numbers = new int[1];
            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Multiply(numbers));

            numbers = new int[2];
            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(77, Calculator.Multiply(numbers));
            
            //It multiplies two numbers
            //It multiplies several numbers
         
        }
        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(1, Calculator.Power(2, 0));
            Assert.AreEqual(64, Calculator.Power(2, 6));
            
            //It raises one number to the power of another number

        }
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
            Assert.AreEqual(1, Calculator.Factorial(1));
            Assert.AreEqual(2, Calculator.Factorial(2));
            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(3628800, Calculator.Factorial(10));

            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
        }
    }
}
