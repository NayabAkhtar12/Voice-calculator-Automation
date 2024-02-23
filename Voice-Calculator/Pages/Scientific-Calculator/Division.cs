using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using ScientificCalculator.Core;

namespace ScientificCalculator.Pages
{
    class Division : Identifiers_SC
    {
        private AppiumDriver<IWebElement> driver;

        public Division(AppiumDriver<IWebElement> driver) : base(driver)
        {
            // No need to initialize 'driver' field here
            // It's already initialized by the base class constructor
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

        // Division
        public void BasicDivision()
        {
            //Expected Result: 100/5 = 20
            Assert.IsNotNull(this, "Identifiers instance is not initialized");
            GetButton1().Click();
            GetZero().Click();
            GetZero().Click();
            GetDivide().Click();
            GetButton5().Click();
            GetEqual().Click();
            var BasicDivResult = GetFinalResult().Text;
            Assert.AreEqual("20", BasicDivResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void DivisionOfZero()
        {
            // Division of Zero 
            //Expected Result: 8/0 = Syntax Error Or Infinity
            GetButton8().Click();
            GetDivide().Click();
            GetZero().Click();
            GetEqual().Click();
            var DivisionOfZeroResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", DivisionOfZeroResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        //Division of Decimals
        public void DecimalDivision()
        {
            //Expected Result: 1.5/2.5 = 0.6
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetDivide().Click();
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var DecimalDivisionResult = GetFinalResult().Text;
            Assert.AreEqual("0.6", DecimalDivisionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Positive-Negative Division
        public void PosNegDivision()
        {
            //Expected Result: 5/(-3) = -1.66666666667
            GetButton5().Click();
            GetDivide().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton3().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var PosNegDivResult = GetFinalResult().Text;
            Assert.AreEqual("-1.6666666666666667", PosNegDivResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NegativeIntegerDivision()
        {
            // Negative Integer Division
            //Expected Result: (-8)/(-4) = 2
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton8().Click();
            GetRightBracket().Click();
            GetDivide().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton4().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var NegativeIntegerDivision = GetFinalResult().Text;
            Assert.AreEqual("2", NegativeIntegerDivision, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Division of Negative Decimals
        public void DivisionOfNegativeDecimals()
        {
            //Expected Result: (-4.5)/(-2.5) = 1.8
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton4().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetDivide().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var NegDecDivisionResult = GetFinalResult().Text;
            Assert.AreEqual("1.8", NegDecDivisionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NegPosDecDivision()
        {
            //Division of Negative positive Decimals
            // Expected Result: (-7) / 3.5 = -2
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton7().Click();
            GetRightBracket().Click();
            GetDivide().Click();
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var NegPosDecDivisionResult = GetFinalResult().Text;
            Assert.AreEqual("-2", NegPosDecDivisionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) / 3.5) = Syntax Error Or Infinity
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton7().Click();
            GetRightBracket().Click();
            GetDivide().Click();
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var ErrorHandlingResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void LargeNumbersDiv()
        {
            // Scenario: Handling of large numbers
            // Expected Result: 999999999 / 888888888 = 1.125
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetDivide().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton9().Click();
            GetEqual().Click();
            var largeNumberDivisionResult = GetFinalResult().Text;
            Assert.AreEqual("1.125", largeNumberDivisionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }
    }
}