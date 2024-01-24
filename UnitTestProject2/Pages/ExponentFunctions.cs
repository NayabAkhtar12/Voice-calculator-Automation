using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScientificCalculator.Core;

namespace ScientificCalculator.Pages
{
     class ExponentFunctions : TestInitialize
    {
        private Identifiers I;

        public ExponentFunctions(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            I = new Identifiers(driver);
        }

        // Assert.IsNotNull(I, "Identifiers instance is not initialized");

        // Exponent
        public void PowerFunction()
        {
            // Test Data: 2 ^ 5 = 32
            I.Button2.Click();
            I.Power.Click();
            I.Button5.Click();
            I.Equal.Click();
            var PowerResult = I.FinalResult.Text;
            Assert.AreEqual("32", PowerResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ExponentOfDecimal()
        {
            // Test Data: 1.5 ^ 2.25 = 
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Power.Click();
            I.Button2.Click();
            I.point.Click();
            I.Button2.Click();
            I.Button5.Click();
            I.Equal.Click();

            var ExponentOfDecimalResult = I.FinalResult.Text;
            Assert.AreEqual("2.4900343193257237", ExponentOfDecimalResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ExponentOfNegativeDecimal()
        {
            // Test Data: -1.5 ^ 2.25 = 2.25 
            I.Minus.Click();
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Power.Click();
            I.Button2.Click();
            I.point.Click();
            I.Button2.Click();
            I.Button5.Click();
            I.Equal.Click();

            var ExponentOfNegDecimalResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", ExponentOfNegDecimalResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void ExponentOfLargeValue()
        {
            // Test Data: 10 ^ 6 = 1,000,000
            I.Button1.Click();
            I.Zero.Click();
            I.Power.Click();
            I.Button6.Click();
            I.Equal.Click();

            var ExponentOfLargeValueResult = I.FinalResult.Text;
            Assert.AreEqual("1000000", ExponentOfLargeValueResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ExponentOfZeroWithNegativePower()
        {
            // Test Data: 0 ^ -6 = error
            I.Zero.Click();
            I.Power.Click();
            I.Minus.Click();
            I.Button6.Click();
            I.Equal.Click();

            var ExponentOfZeroWithNegPowerResult = I.FinalResult.Text;
            Assert.AreEqual("Infinity", ExponentOfZeroWithNegPowerResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ExponentOfZeroWithPositivePower()
        {
            // Test Data: 0 ^ 6 = 0
            I.Zero.Click();
            I.Power.Click();
            I.Button6.Click();
            I.Equal.Click();

            var ExponentOfZeroWithPositivePowerResult = I.FinalResult.Text;
            Assert.AreEqual("0", ExponentOfZeroWithPositivePowerResult);
            I.ClearScreen.Click();
        }
        public void ExponentOfPosNumberWithZero()
        {
            // Test Data: 6 ^ 0 = 1
            I.Button6.Click();
            I.Power.Click();
            I.Zero.Click();
            I.Equal.Click();

            var ExponentOfPosNumWithZeroResult = I.FinalResult.Text;
            Assert.AreEqual("1", ExponentOfPosNumWithZeroResult);
            I.ClearScreen.Click();
        }
        [TestMethod]
        public void ExponentialDecimalToNegativeExponent()
        {
            // Test Data: 0.5^(-2) = 4
            I.Zero.Click();
            I.point.Click();
            I.Button5.Click();
            I.Power.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.Equal.Click();

            var exponentialDecimalToNegativeExponentResult = I.FinalResult.Text;
            Assert.AreEqual("4", exponentialDecimalToNegativeExponentResult);
            I.ClearScreen.Click();
        }

        public void ExponentialXSquare()
        {
            // Test Data: 5 ^ 2 = 25
            I.Button5.Click();
            I.Square.Click();
            I.Equal.Click();

            var exponentialXSquareResult = I.FinalResult.Text;
            Assert.AreEqual("25", exponentialXSquareResult);
            I.ClearScreen.Click();
        }

        public void SquareRoot()
        {
            // Test Data: sqrt(4) = 2
            I.SquareRoot.Click();
            I.Button4.Click();
            I.Equal.Click();

            var squareRootResult = I.FinalResult.Text;
            Assert.AreEqual("2", squareRootResult);
            I.ClearScreen.Click();
        }

        public void SquareRootZero()
        {
            // Test Data: sqrt(0) = 0
            I.SquareRoot.Click();
            I.Zero.Click();
            I.Equal.Click();

            var squareRootZeroResult = I.FinalResult.Text;
            Assert.AreEqual("0", squareRootZeroResult);
            I.ClearScreen.Click();
        }

        public void SquareRootNegativeNumber()
        {
            // Test Data: sqrt(-9) = error
            I.SquareRoot.Click();
            I.Minus.Click();
            I.Button9.Click();
            I.Equal.Click();

            var squareRootNegativeNumberResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", squareRootNegativeNumberResult);
            I.ClearScreen.Click();
        }


        public void SquareRootDecimal()
        {
            // Test Data: sqrt(25.0) = 5
            I.SquareRoot.Click();
            I.Button2.Click();
            I.Button5.Click();
            I.point.Click();
            I.Zero.Click();
            I.Equal.Click();

            var squareRootDecimalResult = I.FinalResult.Text;
            Assert.AreEqual("5", squareRootDecimalResult);
            I.ClearScreen.Click();
        }
        [TestMethod]
        public void TestSquareRootNegativeDecimal()
        {
            // Test Data: sqrt(-25.0) = error
            I.SquareRoot.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.Button5.Click();
            I.point.Click();
            I.Zero.Click();
            I.Equal.Click();

            var squareRootNegDecimalResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", squareRootNegDecimalResult);
            I.ClearScreen.Click();
        }

    }
}