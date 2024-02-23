using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using System;

namespace ScientificCalculator.Pages
{
    // By default Its access modifier is Internal
    class Addition : Identifiers_SC
    {
        private Identifiers_SC I;
        private AppiumDriver<IWebElement> driver;

        public Addition(AppiumDriver<IWebElement> driver) : base(driver)
        {

        }

        // Methods for performing addition operations
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


            // Method for basic addition
            public void BasicAddition()
        {
            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            GetButton5().Click();
            GetPlus().Click();
            GetButton3().Click();
            GetEqual().Click();
            var AdditionResult = GetFinalResult().Text;
            Assert.AreEqual("8", AdditionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for decimal addition
        public void DecimalAddition()
        {
            // Test Data: 2.5 + 1.5 = 4
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetPlus().Click();
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var DecimalAdditionResult = GetFinalResult().Text;
            Assert.AreEqual("4", DecimalAdditionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for adding integer and decimals
        public void DecimalIntegerAdd()
        {
            // Expected Result: 8 + 4.2 = 12.2
            GetButton8().Click();
            GetPlus().Click();
            GetButton4().Click();
            GetPoint().Click();
            GetButton2().Click();
            GetEqual().Click();
            var DecimalIntegerAdd = GetFinalResult().Text;
            Assert.AreEqual("12.2", DecimalIntegerAdd, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for adding zero
        public void ZeroAddition()
        {
            // Addition of Zero
            // Expected Result: 0 + 10 = 10
            GetZero().Click();
            GetPlus().Click();
            GetButton1().Click();
            GetZero().Click();
            GetEqual().Click();
            var ZeroAdditionResult = GetFinalResult().Text;
            Assert.AreEqual("10", ZeroAdditionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for positive-negative addition
        public void PositiveNegativeAddition()
        {
            // Expected Result: 5 + (-3) = 2
            GetButton5().Click();
            GetPlus().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton3().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var PositiveNegativeAdditionResult = GetFinalResult().Text;
            Assert.AreEqual("2", PositiveNegativeAdditionResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for negative integer addition
        public void NegativeIntegerAddition()
        {
            // Negative Integer Addition
            // Expected Result: (-4) + (-2) = -6
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton4().Click();
            GetRightBracket().Click();
            GetPlus().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var NegativeIntegerAddition = GetFinalResult().Text;
            Assert.AreEqual("-6", NegativeIntegerAddition, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for addition of negative decimals
        public void AdditionOfNegativeDecimals()
        {
            // Expected Result: (-2.5) + (-1.5) = -4
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetPlus().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var NegativeIntegerAddition = GetFinalResult().Text;
            Assert.AreEqual("-4", NegativeIntegerAddition, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for addition of negative and positive decimals
        public void AdditionOfNegativePositiveDecimals()
        {
            // Expected Result: (-7) + 3.5 = -3.5
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton7().Click();
            GetRightBracket().Click();
            GetPlus().Click();
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var AdditionOfNegativePositiveDecimals = GetFinalResult().Text;
            Assert.AreEqual("-3.5", AdditionOfNegativePositiveDecimals, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Method for error handling
        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) + 3.5) = Syntax Error Or Infinity
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

        // Method for handling large numbers addition
        public void LargeNumbersAddition()
        {
            // Scenario: Handling of large numbers
            // Expected Result: 999999999 + 9999999999 = 10999999998
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetPlus().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetButton9().Click();
            GetEqual().Click();
            var LargeNumbersAddition = GetFinalResult().Text;
            Assert.AreEqual("10999999998", LargeNumbersAddition, "Result is not as Expected");
            GetClearScreen().Click();
        }
    }
}
