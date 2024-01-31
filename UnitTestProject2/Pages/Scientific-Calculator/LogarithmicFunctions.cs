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
     class LogarithmicFunctions : TestInitialize
    {
        private Identifiers_SC I;

        public LogarithmicFunctions(AppiumDriver<IWebElement> driver)
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
        public void CommonLog()
        {
           Assert.IsNotNull(I, "Identifiers instance is not initialized");

            // Test Data: log(10) = 1
            I.Log.Click();
            I.Button1.Click();
            I.zero.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var commonLogResult = I.FinalResult.Text;
            Assert.AreEqual("1", commonLogResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void CommonLogNeg()
        {
            // Test Data: log(-8) = Error
            I.Log.Click();
            I.Minus.Click();
            I.Button8.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var commonLogNegResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", commonLogNegResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void CommonLogPos()
        {
            // Test Data: log(10.5) = 1.02118929907
            I.Log.Click();
            I.Button1.Click();
            I.zero.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var commonLogPosValue = I.FinalResult.Text;
            Assert.AreEqual("1.021189299069938", commonLogPosValue, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void CommonLogDecimal()
        {
            // Test Data: log(-20.5) = error
            I.Log.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.zero.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var commonLogDecimalValue = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", commonLogDecimalValue, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void NaturalLogarithm()
        {
            // Test Data: ln(8) = 2.079
            I.Ln.Click();
            I.Button8.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var naturalLogarithmResult = I.FinalResult.Text;
            Assert.AreEqual("2.0794415416798357", naturalLogarithmResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void NaturalLogarithmNegative()
        {
            // Test Data: ln(-8) = Error
            I.Ln.Click();
            I.Minus.Click();
            I.Button8.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var NaturalLogarithmNeg = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", NaturalLogarithmNeg, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void NaturalLogarithmPositiveDecimal()
        {
            // Test Data: ln(10.5) = 2.35137..
            I.Ln.Click();
            I.Button1.Click();
            I.zero.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var NaturalLogPosResult = I.FinalResult.Text;
            Assert.AreEqual("2.3513752571634776", NaturalLogPosResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void NaturalLogarithmNegativeDecimal()
        {
            // Test Data: ln(-20.5) = error
            I.Ln.Click();
            I.Minus.Click();
            I.Button2.Click();
            I.zero.Click();
            I.point.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var NaturalLogNegDecResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", NaturalLogNegDecResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }


    }
}