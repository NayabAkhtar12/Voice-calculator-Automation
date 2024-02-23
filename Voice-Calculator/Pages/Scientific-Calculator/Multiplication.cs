using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using System;

namespace ScientificCalculator.Pages
{
    class Multiplication : Identifiers_SC
    {
        public Multiplication(AppiumDriver<IWebElement> driver) : base(driver)
        {
            // No need to initialize I in the constructor anymore
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

        public void MultiplicationOp()
        {
            // Expected Result: 20 * 5 = 100
            Assert.IsNotNull(this, "Identifiers instance is not initialized");
            GetButton2().Click();
            GetZero().Click();
            GetMultiply().Click();
            GetButton5().Click();
            GetEqual().Click();
            var BasicMultiplicationResult = GetFinalResult().Text;
            Assert.AreEqual("100", BasicMultiplicationResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        //Multiplication of Decimals
        public void DecimalMultiplication()
        {
            // Expected Result: 2.5 * 1.5 = 3.75
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetMultiply().Click();
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var DecimalMultiplicationResult = GetFinalResult().Text;
            Assert.AreEqual("3.75", DecimalMultiplicationResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Multiplication of Integer and Decimals
        public void PosNegMultiplication()
        {
            // Expected Result: 5 * (-3) = -15
            GetButton5().Click();
            GetMultiply().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton3().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var PosNegMultiplicationResult = GetFinalResult().Text;
            Assert.AreEqual("-15", PosNegMultiplicationResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void MultiplicationOfZero()
        {
            // Subtraction of Zero 
            // Expected Result: 0 * 10 = 0
            GetZero().Click();
            GetMultiply().Click();
            GetButton1().Click();
            GetZero().Click();
            GetEqual().Click();
            var MultiplicationOfZeroResult = GetFinalResult().Text;
            Assert.AreEqual("0", MultiplicationOfZeroResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NegativeIntegerMultiplication()
        {
            //Negative Integer Multiplication
            // Expected Result: (-8) * (-4) = 32
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton8().Click();
            GetRightBracket().Click();
            GetMultiply().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton4().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var NegativeIntegerMultiplicationResult = GetFinalResult().Text;
            Assert.AreEqual("32", NegativeIntegerMultiplicationResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        // Multiplication of Negative Decimals
        public void MultiplicationOfNegativeDecimals()
        {
            // Expected Result: (-2.5) * (-1.5) = 3.75
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton2().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetMultiply().Click();
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton1().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var MultiplyNegativeDecimalsResult = GetFinalResult().Text;
            Assert.AreEqual("3.75", MultiplyNegativeDecimalsResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void NegPosDecMultiplication()
        {
            //Multiplication of Negative positive Decimals
            // Expected Result: (-7) * 3.5 = -24.5
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton7().Click();
            GetRightBracket().Click();
            GetMultiply().Click();
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetEqual().Click();
            var NegPosDecMultiplicationResult = GetFinalResult().Text;
            Assert.AreEqual("-24.5", NegPosDecMultiplicationResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) * 3.5) = Syntax Error Or Infinity
            GetLeftBracket().Click();
            GetMinus().Click();
            GetButton7().Click();
            GetRightBracket().Click();
            GetMultiply().Click();
            GetButton3().Click();
            GetPoint().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var ErrorHandlingResult = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void LargeNumbersMultiplication()
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
            GetMultiply().Click();
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
            var largeNumberMulResult = GetFinalResult().Text;
            //Assert.AreEqual("111111111", largeNumberMulResult, "Result is not as Expected");
            GetClearScreen().Click();
        }
    }
}
