using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Support.PageObjects;
using ScientificCalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.Pages
{
     class Multiplication : TestInitialize
    {
        private Identifiers_SC I;

        public Multiplication(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            I = new Identifiers_SC(driver);
        }
        public void ClearScreen()
        {
            if (!string.IsNullOrEmpty(I.FinalResult.Text))
            {
                // If not clear, perform the clear operation
                I.ClearScreen.Click();

                // You can add an assertion or print a message to verify the clear operation
                Assert.IsTrue(string.IsNullOrEmpty(I.FinalResult.Text), "Result screen is not cleared after clicking ClearScreen.");

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
            Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Button2.Click();
            I.zero.Click();
            I.Multiply.Click();
            I.Button5.Click();
            I.Equal.Click();
            var BasicMultiplicationResult = I.FinalResult.Text;
            Assert.AreEqual("100", BasicMultiplicationResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

            //Multiplication of Decimals
        public void DecimalMultiplication()
        {
            // Expected Result: 2.5 * 1.5 = 3.75
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Multiply.Click();
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Equal.Click();
            var DecimalMultiplicationResult = I.FinalResult.Text;
            Assert.AreEqual("3.75", DecimalMultiplicationResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Multiplication of Integer and Decimals
        public void PosNegMultiplication()
        {
            // Expected Result: 5 * (-3) = -15
            I.Button5.Click();
            I.Multiply.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button3.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var PosNegMultiplicationResult = I.FinalResult.Text;
            Assert.AreEqual("-15", PosNegMultiplicationResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void MultiplicationOfZero()
        {
            // Subtraction of Zero 
            // Expected Result: 0 * 10 = 0
            I.zero.Click();
            I.Multiply.Click();
            I.Button1.Click();
            I.zero.Click();
            I.Equal.Click();
            var MultiplicationOfZeroResult = I.FinalResult.Text;
            Assert.AreEqual("0", MultiplicationOfZeroResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }


        public void NegativeIntegerMultiplication()
        {
            //Negative Integer Multiplication
            // Expected Result: (-8) * (-4) = 32
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button8.Click();
            I.Rightbracket.Click();
            I.Multiply.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button4.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var NegativeIntegerMultiplicationResult = I.FinalResult.Text;
            Assert.AreEqual("32", NegativeIntegerMultiplicationResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Multiplication of Negative Decimals
        public void MultiplicationOfNegativeDecimals()
        {
            // Expected Result: (-2.5) * (-1.5) = 3.75
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Multiply.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var MultiplyNegativeDecimalsResult = I.FinalResult.Text;
            Assert.AreEqual("3.75", MultiplyNegativeDecimalsResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }


        public void NegPosDecMultiplication()
        {
            //Multiplication of Negative positive Decimals
            // Expected Result: (-7) * 3.5 = -24.5
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Multiply.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Equal.Click();
            var NegPosDecMultiplicationResult = I.FinalResult.Text;
            Assert.AreEqual("-24.5", NegPosDecMultiplicationResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }



        [TestMethod]
        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) * 3.5) = Syntax Error Or Infinity
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Multiply.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var ErrorHandlingResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void LargeNumbersMultiplication()
        {
            // Scenario: Handling of large numbers
            // Expected Result: 999999999 - 888888888 = 111111111
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Multiply.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button9.Click();
            I.Equal.Click();
            var largeNumberMulResult = I.FinalResult.Text;
            //Assert.AreEqual("111111111", largeNumberMulResult, "Result is not as Expected");
            I.ClearScreen.Click();

        }
    }
    }
