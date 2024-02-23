using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;

namespace ScientificCalculator.Pages
{
    class LogarithmicFunctions : Identifiers_SC
    {
        public LogarithmicFunctions(AppiumDriver<IWebElement> driver) : base(driver)
        {
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
        public void CommonLog()
        {

            // Test Data: log(10) = 1
            GetLog().Click();
            GetButton1().Click();
            GetZero().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var commonLogResult = GetFinalResult().Text;
            Assert.AreEqual("1", commonLogResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void CommonLogNeg()
        {
            // Test Data: log(-8) = Error
            GetLog().Click();
            GetMinus().Click();
            GetButton8().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var commonLogNegResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", commonLogNegResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void CommonLogPos()
        {
            // Test Data: log(10.5) = 1.02118929907
            GetLog().Click();
            GetButton1().Click();
            GetZero().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var commonLogPosValue = GetFinalResult().Text;
            Assert.AreEqual("1.021189299069938", commonLogPosValue, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void CommonLogDecimal()
        {
            // Test Data: log(-20.5) = error
            GetLog().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetZero().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var commonLogDecimalValue = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", commonLogDecimalValue, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NaturalLogarithm()
        {
            // Test Data: ln(8) = 2.079
            GetLn().Click();
            GetButton8().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var naturalLogarithmResult = GetFinalResult().Text;
            Assert.AreEqual("2.0794415416798357", naturalLogarithmResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NaturalLogarithmNegative()
        {
            // Test Data: ln(-8) = Error
            GetLn().Click();
            GetMinus().Click();
            GetButton8().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var NaturalLogarithmNeg = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", NaturalLogarithmNeg, "Result is not as Expected");
            GetClearScreen().Click();
        }
        public void NaturalLogarithmPositiveDecimal()
        {
            // Test Data: ln(10.5) = 2.35137..
            GetLn().Click();
            GetButton1().Click();
            GetZero().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var NaturalLogPosResult = GetFinalResult().Text;
            Assert.AreEqual("2.3513752571634776", NaturalLogPosResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NaturalLogarithmNegativeDecimal()
        {
            // Test Data: ln(-20.5) = error
            GetLn().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetZero().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var NaturalLogNegDecResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", NaturalLogNegDecResult, "Result is not as Expected");
            GetClearScreen().Click();
        }
    }
}
