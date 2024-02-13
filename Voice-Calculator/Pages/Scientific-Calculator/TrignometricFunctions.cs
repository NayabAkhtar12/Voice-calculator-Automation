﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using System;

namespace ScientificCalculator.Pages
{
     class TrignometricFunctions : TestInitialize
    {
        private Identifiers_SC I;

        public TrignometricFunctions(AppiumDriver<IWebElement> driver)
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
        // Assert.IsNotNull(I, "Identifiers instance is not initialized");

        public void Sin30DegreeMode()
        {
           Assert.AreEqual("Degree",I.Degree.Text);
            // Test Data: sin(30) = 0.5
            I.Sin.Click();
            I.Button3.Click();
            I.zero.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var sin30Result = I.FinalResult.Text;
       //     Assert.AreEqual("0.5", sin30Result, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void Sin60DegreeMode()
        {
            // Test Data: sin(60) = 0.8660254037844386
            I.Sin.Click();
            I.Button6.Click();
            I.zero.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var sin60Result = I.FinalResult.Text;
//            Assert.AreEqual("0.8660254037844386", sin60Result, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void Cos()
        {
            // Cos
            // Test Data: cos(30) = 0.86602540378

            I.Cos.Click();
            I.Button3.Click();
            I.zero.Click();
            I.Rightbracket.Click();
            I.Equal.Click();
            var cosResult = I.FinalResult.Text;
            Assert.AreEqual("0.8660254037844386", cosResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void Tan45()
        {
            // Tan
            // Test Data: tan(45) = 1

            I.Tan.Click();
            I.Button4.Click();
            I.Button5.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            var tanResult = I.FinalResult.Text;
            Assert.AreEqual("1", tanResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void Tan120()
        {
            // Tan
            I.Tan.Click();
            I.Button1.Click();
            I.Button2.Click();
            I.zero.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            // Test Data: tan(120) = -1.73205080757
            var tanResult = I.FinalResult.Text;
            Assert.AreEqual("-1.7320508075688772", tanResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void Tan90()
        {
            // Tan
            I.Tan.Click();
            I.Button9.Click();
            I.zero.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            // Test Data: tan(90) = error
            var tan90Result = I.FinalResult.Text;
           Assert.AreEqual("Syntax Error Or Infinity", tan90Result, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void SinRadian()
        {
            //For Radian Mode
            I.Degree.Click();
            // Validate if the mode is switched to Degrees
            Assert.AreEqual("Radian", I.Degree.Text);

            I.Sin.Click();
            I.PI.Click();
            I.Divide.Click();
            I.Button6.Click();
            I.Rightbracket.Click();
            I.Equal.Click();

            // Test Data: sin(pi/6) = 0.5
            var sinPiBy6Result = I.FinalResult.Text;
            Assert.AreEqual("0.5", sinPiBy6Result, "Result is not as Expected");
            I.ClearScreen.Click();
        }


    }
}