using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using System;

namespace ScientificCalculator.Pages
{
    class ExponentFunctions : Identifiers_SC
    {
        public ExponentFunctions(AppiumDriver<IWebElement> driver) : base(driver)
        {
            // No need to initialize 'I' separately
        }

        public void ClearScreen()
        {
            if (!string.IsNullOrEmpty(GetFinalResult().Text))
            {
                // If not clear, perform the clear operation
                GetClearScreen().Click();

                // You can add an assertion or print a message to verify the clear operation
                Assert.IsTrue(string.IsNullOrEmpty(GetFinalResult().Text), "Result screen is not cleared after clicking ClearScreen.");

                // Or print a message
                Console.WriteLine("Result screen has been cleared.");
            }
            else
            {
                // The result screen is already clear
                Console.WriteLine("Result screen is already clear.");
            }
        }

        // Exponent
        public void PowerFunction()
        {
            // Test Data: 2 ^ 5 = 32
            GetButton2().Click();
            GetPower().Click();
            GetButton5().Click();
            GetEqual().Click();
            var PowerResult = GetFinalResult().Text;
            Assert.AreEqual("32", PowerResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ExponentOfDecimal()
        {
            // Test Data: 1.5 ^ 2.25 = 
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetPower().Click();
            GetButton2().Click();
            GetPoint().Click();
            GetButton2().Click();
            GetButton5().Click();
            GetEqual().Click();

            var ExponentOfDecimalResult = GetFinalResult().Text;
            Assert.AreEqual("2.4900343193257237", ExponentOfDecimalResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ExponentOfNegativeDecimal()
        {
            // Test Data: -1.5 ^ 2.25 = 2.25 
            GetMinus().Click();
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetPower().Click();
            GetButton2().Click();
            GetPoint().Click();
            GetButton2().Click();
            GetButton5().Click();
            GetEqual().Click();

            var ExponentOfNegDecimalResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", ExponentOfNegDecimalResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ExponentOfLargeValue()
        {
            // Test Data: 10 ^ 6 = 1,000,000
            GetButton1().Click();
            GetZero().Click();
            GetPower().Click();
            GetButton6().Click();
            GetEqual().Click();

            var ExponentOfLargeValueResult = GetFinalResult().Text;
            Assert.AreEqual("1000000", ExponentOfLargeValueResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ExponentOfZeroWithNegativePower()
        {
            // Test Data: 0 ^ -6 = error
            GetZero().Click();
            GetPower().Click();
            GetMinus().Click();
            GetButton6().Click();
            GetEqual().Click();

            var ExponentOfZeroWithNegPowerResult = GetFinalResult().Text;
            Assert.AreEqual("Infinity", ExponentOfZeroWithNegPowerResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ExponentOfZeroWithPositivePower()
        {
            // Test Data: 0 ^ 6 = 0
            GetZero().Click();
            GetPower().Click();
            GetButton6().Click();
            GetEqual().Click();

            var ExponentOfZeroWithPositivePowerResult = GetFinalResult().Text;
            Assert.AreEqual("0", ExponentOfZeroWithPositivePowerResult);
            GetClearScreen().Click();
        }

        public void ExponentOfPosNumberWithZero()
        {
            // Test Data: 6 ^ 0 = 1
            GetButton6().Click();
            GetPower().Click();
            GetZero().Click();
            GetEqual().Click();

            var ExponentOfPosNumWithZeroResult = GetFinalResult().Text;
            Assert.AreEqual("1", ExponentOfPosNumWithZeroResult);
            GetClearScreen().Click();
        }

        [TestMethod]
        public void ExponentialDecimalToNegativeExponent()
        {
            // Test Data: 0.5^(-2) = 4
            GetZero().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetPower().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetEqual().Click();

            var exponentialDecimalToNegativeExponentResult = GetFinalResult().Text;
            Assert.AreEqual("4", exponentialDecimalToNegativeExponentResult);
            GetClearScreen().Click();
        }

        public void ExponentialXSquare()
        {
            // Test Data: 5 ^ 2 = 25
            GetButton5().Click();
            GetSquare().Click();
            GetEqual().Click();

            var exponentialXSquareResult = GetFinalResult().Text;
            Assert.AreEqual("25", exponentialXSquareResult);
            GetClearScreen().Click();
        }

        public void SquareRoot()
        {
            // Test Data: sqrt(4) = 2
            GetSquareRoot().Click();
            GetButton4().Click();
            GetEqual().Click();

            var squareRootResult = GetFinalResult().Text;
            Assert.AreEqual("2", squareRootResult);
            GetClearScreen().Click();
        }

        public void SquareRootZero()
        {
            // Test Data: sqrt(0) = 0
            GetSquareRoot().Click();
            GetZero().Click();
            GetEqual().Click();

            var squareRootZeroResult = GetFinalResult().Text;
            Assert.AreEqual("0", squareRootZeroResult);
            GetClearScreen().Click();
        }

        public void SquareRootNegativeNumber()
        {
            // Test Data: sqrt(-9) = error
            GetSquareRoot().Click();
            GetMinus().Click();
            GetButton9().Click();
            GetEqual().Click();

            var squareRootNegativeNumberResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", squareRootNegativeNumberResult);
            GetClearScreen().Click();
        }

        public void SquareRootDecimal()
        {
            // Test Data: sqrt(25.0) = 5
            GetSquareRoot().Click();
            GetButton2().Click();
            GetButton5().Click();
            GetPoint().Click();
            GetZero().Click();
            GetEqual().Click();

            var squareRootDecimalResult = GetFinalResult().Text;
            Assert.AreEqual("5", squareRootDecimalResult);
            GetClearScreen().Click();
        }

        [TestMethod]
        public void TestSquareRootNegativeDecimal()
        {
            // Test Data: sqrt(-25.0) = error
            GetSquareRoot().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetButton5().Click();
            GetPoint().Click();
            GetZero().Click();
            GetEqual().Click();

            var squareRootNegDecimalResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", squareRootNegDecimalResult);
            GetClearScreen().Click();
        }

    }
}
