using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using ScientificCalculator.Core;
using System;


namespace ScientificCalculator.Pages
{
     class OtherFunctions : TestInitialize
    {
        private Identifiers_SC I;
        public OtherFunctions(AppiumDriver<IWebElement> driver)
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
        public void ConstantPi()
        {
            //For Degree Mode
            //I.Degree.Click();
            //// Validate if the mode is switched to Degrees
            //Assert.AreEqual("Degree", I.Degree.Text);
            Assert.IsNotNull(I, "Identifiers instance is not initialized");

            // Constants pi
            I.PI.Click();
            I.Equal.Click();

            // Test Data: π= 3.14159
            var piResult = I.FinalResult.Text;
            Assert.AreEqual("3.141592653589793", piResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void ConstantPiDivide()
        {
            // Constants pi/3
            I.PI.Click();
            I.Divide.Click();
            I.Button3.Click();
            I.Equal.Click();

            // Test Data: π/3 = 1.04719755
            var piDivThreeResult = I.FinalResult.Text;
            Assert.AreEqual("1.0471975511965976", piDivThreeResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void Factorial()
        {
            // Factorial (!)
            // Test Data: 5! = 120

            I.Button5.Click();
            I.Factorial.Click();
            I.Equal.Click();
            var factorialResult = I.FinalResult.Text;
            Assert.AreEqual("120", factorialResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void FactorialZero()
        {
            // Factorial (zero!)
            // Test Data: 0! = 1

            I.zero.Click();
            I.Factorial.Click();
            I.Equal.Click();

            var factorialZeroResult = I.FinalResult.Text;
            Assert.AreEqual("1", factorialZeroResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void FactorialNegativeNum()
        {
            // Factorial (-50!)
            // Test Data: -50! = error
            I.Minus.Click();
            I.Button5.Click();
            I.zero.Click();
            I.Factorial.Click();
            I.Equal.Click();

            var FactorialNegResult = I.FinalResult.Text;
            Assert.AreEqual("Syntax Error Or Infinity", FactorialNegResult, "Result is not as Expected");
            I.ClearScreen.Click();
        }

        public void FactorialDecimal()
        {
            // Factorial (20.0!)
            I.Button2.Click();
            I.zero.Click();
            I.point.Click();
            I.zero.Click();
            I.Factorial.Click();
            I.Equal.Click();

            // Test Data: 20.0! = 2.432902e+18
            var FactorialDecimal = I.FinalResult.Text;
            Assert.AreEqual("2.432902e+18", FactorialDecimal, "Result is not as Expected");
            I.ClearScreen.Click();
        }
        public void FactorialDec()
        {
            // Factorial (3.5!)
            I.Button3.Click();
            I.point.Click();
            I.Button5.Click();
            I.Factorial.Click();
            I.Equal.Click();

            // Test Data: 3.5! = 11.6317283966
            var FactorialDec = I.FinalResult.Text;
             Assert.AreEqual("11.6317283966", FactorialDec, "Result is not as Expected");
            I.ClearScreen.Click();
        }


    }
}