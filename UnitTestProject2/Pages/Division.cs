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
     class Division : TestInitialize
    {
        private Extra I;

        public Division(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            I = new Extra(driver);
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
        // Division
        public void BasicDivision()
        {
            //Expected Result: 100/5 = 20
            Assert.IsNotNull(I, "Identifiers instance is not initialized");
            I.Button1.Click();
            I.Zero.Click();
            I.Zero.Click();
            I.Divide.Click();
            I.Button5.Click();
            I.Equal.Click();
            var BasicDivResult = I.FinalResult.Text;
            Assert.AreEqual("20", BasicDivResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void DivisionOfZero()
        {
            // Division of Zero 
            //Expected Result: 8/0 = Syntax Error Or Infinity
            I.Button8.Click();
            I.Divide.Click();
            I.Zero.Click();
            I.Equal.Click();
            var DivisionOfZeroResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", DivisionOfZeroResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        //Division of Decimals
        public void DecimalDivision()
        {
            //Expected Result: 1.5/2.5 = 0.6
            I.Button1.Click();
            I.point.Click();
            I.Button5.Click();
            I.Divide.Click();
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Equal.Click();
            var DecimalDivisionResult = I.FinalResult.Text;
            Assert.AreEqual("0.6", DecimalDivisionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Positive-Negative Division
        public void PosNegDivision()
        {
            //Expected Result: 5/(-3) = -1.66666666667
            I.Button5.Click();
            I.Divide.Click();
            I.Leftbracket.Click();
            I.Minus.Click();
            I.Button3.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var PosNegDivResult = I.FinalResult.Text;
            Assert.AreEqual("-1.6666666666666667", PosNegDivResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void NegativeIntegerDivision()
        {
            // Negative Integer Division
            //Expected Result: (-8)/(-4) = 2
            I.Leftbracket.Click();
            I.Minus.Click();
            I.Button8.Click();
            I.Rightbracket.Click();
            I.Divide.Click();
            I.Leftbracket.Click();
            I.Minus.Click();
            I.Button4.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var NegativeIntegerDivision = I.FinalResult.Text;
            Assert.AreEqual("2", NegativeIntegerDivision, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        // Division of Negative Decimals
        public void DivisionOfNegativeDecimals()
        {
            //Expected Result: (-4.5)/(-2.5) = 1.8
            I.Leftbracket.Click();
            I.Minus.Click();
            I.Button4.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Divide.Click();
            I.Leftbracket.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var NegDecDivisionResult = I.FinalResult.Text;
            Assert.AreEqual("1.8", NegDecDivisionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }


        public void NegPosDecDivision()
        {
            //Division of Negative positive Decimals
            // Expected Result: (-7) / 3.5 = -2
            I.Leftbracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Divide.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Equal.Click();
            var NegPosDecDivisionResult = I.FinalResult.Text;
            Assert.AreEqual("-2", NegPosDecDivisionResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ErrorHandling()
        {
            // Error Handling
            // Expected Result: (-7) / 3.5) = Syntax Error Or Infinity
            I.Leftbracket.Click();
            I.Minus.Click();
            I.Button7.Click();
            I.Rightbracket.Click();
            I.Divide.Click();
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var ErrorHandlingResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void LargeNumbersDiv()
        {
            // Scenario: Handling of large numbers
            // Expected Result: 999999999 / 888888888 = 1.125
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Button9.Click();
            I.Divide.Click();
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
            var largeNumberDivisionResult = I.FinalResult.Text;
            Assert.AreEqual("1.125", largeNumberDivisionResult, "Result is not as Expected");
            I.ClearScreen.Click();

        }
    }
    }
