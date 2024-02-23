using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;

namespace ScientificCalculator.Pages
{
    class Subtraction : Identifiers_SC
    {
        public Subtraction(AppiumDriver<IWebElement> driver) : base(driver)
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

        // Methods for Identifiers like click
        public void BasicSubtration()
        {
            Assert.IsNotNull(this, "Identifiers instance is not initialized");
            GetButton5().Click();
            GetMinus().Click();
            GetButton3().Click();
            GetEqual().Click();
            var SimpleSubtractionResult = GetFinalResult().Text;
            Assert.AreEqual("2", SimpleSubtractionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Subtraction of Decimals
        public void SubtractionOfDecimals()
        {
            // Expected Result: 2.5 - 1.5 = 1
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetMinus().Click();
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var SubtractionOfDecimalsResult = GetFinalResult().Text;
            Assert.AreEqual("1", SubtractionOfDecimalsResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Subtraction of Integer and Decimals
        public void DecimalIntegerSub()
        {
            // Expected Result: 8 - 4.2 = 3.8
            GetButton8().Click();
            GetMinus().Click();
            GetButton4().Click();
            GetPoint().Click();
            GetButton2().Click();
            GetEqual().Click();
            var DecimalIntegersub = GetFinalResult().Text;
            Assert.AreEqual("3.8", DecimalIntegersub, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void SubtractionOfZero()
        {
            // Subtraction of Zero 
            // Expected Result: 0 - 10 = -10
            GetZero().Click();
            GetMinus().Click();
            GetButton1().Click();
            GetZero().Click();
            GetEqual().Click();
            var SubtractionOfZeroResult = GetFinalResult().Text;
            Assert.AreEqual("-10", SubtractionOfZeroResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Positive-Negative Addition
        public void PositiveNegativeSubtraction()
        {
            // Expected Result: 5 - (-3) = 8
            GetButton5().Click();
            GetMinus().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton3().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var PositiveNegativesubResult = GetFinalResult().Text;
            Assert.AreEqual("8", PositiveNegativesubResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NegIntSubtraction()
        {
            // Negative Integer Subtraction
            // Expected Result: (-8) - (-4) = -4
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton8().Click();
            GetRightBracket().Click();
            GetMinus().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton4().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var NegativeIntegerSubtractionResult = GetFinalResult().Text;
            Assert.AreEqual("-4", NegativeIntegerSubtractionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void SubtractionOfNegPosDec()
        {
            // Subtraction of Negative Positive Decimals
            // Expected Result: (-7) - 3.5 = -10.5
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton7().Click();
            GetRightBracket().Click();
            GetMinus().Click();
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var SubtractionOfNegPosDecResult = GetFinalResult().Text;
            Assert.AreEqual("-10.5", SubtractionOfNegPosDecResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Subtraction of Negative Decimals
        public void SubtractionOfNegativeDecimals()
        {
            // Expected Result: (-2.5) - (-1.5) = -1
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetMinus().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var SubtractionOfNegativeDecimalsResult = GetFinalResult().Text;
            Assert.AreEqual("-1", SubtractionOfNegativeDecimalsResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        [TestMethod]
        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) - 3.5) = Syntax Error Or Infinity
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton7().Click();
            GetRightBracket().Click();
            GetPlus().Click();
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var ErrorHandlingResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void LargeNumbersSubtraction()
        {
            // Scenario: Handling of large numbers
            // Expected Result: 999999999 - 888888888 = 111111111
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetMinus().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetButton8().Click();
            GetEqual().Click();
            var LargeNumbersSubtractionResult = GetFinalResult().Text;
            Assert.AreEqual("111111111", LargeNumbersSubtractionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }
    }
}
