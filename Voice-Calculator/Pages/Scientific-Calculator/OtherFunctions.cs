using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using System;

namespace ScientificCalculator.Pages
{
    class OtherFunctions : Identifiers_SC
    {
        public OtherFunctions(AppiumDriver<IWebElement> driver) : base(driver)
        {
            // Constructor of base class is called implicitly
        }

        public void ClearScreen()
        {
            if (!string.IsNullOrEmpty(GetFinalResult().Text))
            {
                GetClearScreen().Click();
                Assert.IsTrue(string.IsNullOrEmpty(GetFinalResult().Text), "Result screen is not cleared after clicking ClearScreen.");
                Console.WriteLine("Result screen has been cleared.");
            }
            else
            {
                Console.WriteLine("Result screen is already clear.");
            }
        }

        public void ConstantPi()
        {
            Assert.IsNotNull(this, "Identifiers instance is not initialized");

            // Constants pi
            GetPI().Click();
            GetEqual().Click();

            // Test Data: π= 3.14159
            var piResult = GetFinalResult().Text;
            Assert.AreEqual("3.141592653589793", piResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ConstantPiDivide()
        {
            // Constants pi/3
            GetPI().Click();
            GetDivide().Click();
            GetButton3().Click();
            GetEqual().Click();

            // Test Data: π/3 = 1.04719755
            var piDivThreeResult = GetFinalResult().Text;
            Assert.AreEqual("1.0471975511965976", piDivThreeResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void Factorial()
        {
            // Factorial (!)
            // Test Data: 5! = 120

            GetButton5().Click();
            GetFactorial().Click();
            GetEqual().Click();
            var factorialResult = GetFinalResult().Text;
            Assert.AreEqual("120", factorialResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void FactorialZero()
        {
            // Factorial (zero!)
            // Test Data: 0! = 1

            GetZero().Click();
            GetFactorial().Click();
            GetEqual().Click();

            var factorialZeroResult = GetFinalResult().Text;
            Assert.AreEqual("1", factorialZeroResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void FactorialNegativeNum()
        {
            // Factorial (-50!)
            // Test Data: -50! = error
            GetMinus().Click();
            GetButton5().Click();
            GetZero().Click();
            GetFactorial().Click();
            GetEqual().Click();

            var FactorialNegResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", FactorialNegResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void FactorialDecimal()
        {
            // Factorial (20.0!)
            GetButton2().Click();
            GetZero().Click();
            GetPoint().Click();
            GetZero().Click();
            GetFactorial().Click();
            GetEqual().Click();

            // Test Data: 20.0! = 2.432902e+18
            var FactorialDecimal = GetFinalResult().Text;
            Assert.AreEqual("2.432902e+18", FactorialDecimal, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void FactorialDec()
        {
            // Factorial (3.5!)
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetFactorial().Click();
            GetEqual().Click();

            // Test Data: 3.5! = 11.6317283966
            var FactorialDec = GetFinalResult().Text;
            Assert.AreEqual("11.6317283966", FactorialDec, "Result is not as Expected");
            GetClearScreen().Click();
        }
    }
}
