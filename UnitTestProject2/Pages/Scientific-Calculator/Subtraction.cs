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
     class Subtraction : TestInitialize
    {
        private Identifiers_SC I;
        public Subtraction(AppiumDriver<IWebElement> driver)
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
      

        //Methods for Identifiers like click
        public void BasicSubtration()
        {
            Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Button5.Click();
            I.Minus.Click();
            I.Button3.Click();
            I.Equal.Click();
            var SimpleSubtractionResult = I.FinalResult.Text;
            Assert.AreEqual("2", SimpleSubtractionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Subtraction of Decimals
        public void SubtractionOfDecimals()
        {
            // Expected Result: 2.5 - 1.5 = 1
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Minus.Click();
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Equal.Click();
            var SubtractionOfDecimalsResult = I.FinalResult.Text;
            Assert.AreEqual("1", SubtractionOfDecimalsResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Subtraction of Integer and Decimals
        public void DecimalIntegerSub()
        {
            // Expected Result: 8 - 4.2 = 3.8
            I.Button8.Click();
            I.Minus.Click();
            I.Button4.Click();
            I.point.Click();
            I.Button2.Click();
            I.Equal.Click();
            var DecimalIntegersub = I.FinalResult.Text;
            Assert.AreEqual("3.8", DecimalIntegersub, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void SubtractionOfZero()
        {
            // Subtraction of Zero 
            // Expected Result: 0 - 10 = -10
            I.zero.Click();
            I.Minus.Click();
            I.Button1.Click();
            I.zero.Click();
            I.Equal.Click();
            var SubtractionOfZeroResult = I.FinalResult.Text;
            Assert.AreEqual("-10", SubtractionOfZeroResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Positive-Negative Addition
        public void PositiveNegativeSubtraction()
        {
            // Expected Result: 5 - (-3) = 8
            I.Button5.Click();
            I.Minus.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button3.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var PositiveNegativesubResult = I.FinalResult.Text;
            Assert.AreEqual("8", PositiveNegativesubResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void NegIntSubtraction()
        {
            // Negative Integer Subtraction
            // Expected Result: (-8) - (-4) = -4
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button8.Click();
            I.Rightbracket.Click();
            I.Minus.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button4.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var NegativeIntegerSubtractionResult = I.FinalResult.Text;
            Assert.AreEqual("-4", NegativeIntegerSubtractionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void SubtractionOfNegPosDec()
        {
            // Subtraction of Negative Positive Decimals
            // Expected Result: (-7) - 3.5 = -10.5
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Minus.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
          //  I.Rightbracket.Click();
            I.Equal.Click();
            var SubtractionOfNegPosDecResult = I.FinalResult.Text;
            Assert.AreEqual("-10.5", SubtractionOfNegPosDecResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Subtraction of Negative Decimals
        public void SubtractionOfNegativeDecimals()
        {
            // Expected Result: (-2.5) - (-1.5) = -1
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Minus.Click();
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var SubtractionOfNegativeDecimalsResult = I.FinalResult.Text;
            Assert.AreEqual("-1", SubtractionOfNegativeDecimalsResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        [TestMethod]
        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) - 3.5) = Syntax Error Or Infinity
            I.LeftBracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Plus.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var ErrorHandlingResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void LargeNumbersSubtraction()
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
            I.Minus.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Button8.Click();
            I.Equal.Click();
            var LargeNumbersSubtractionResult = I.FinalResult.Text;
            Assert.AreEqual("111111111", LargeNumbersSubtractionResult, "Result is not as Expected");
            I.ClearScreen.Click();

        }
    }
    }
