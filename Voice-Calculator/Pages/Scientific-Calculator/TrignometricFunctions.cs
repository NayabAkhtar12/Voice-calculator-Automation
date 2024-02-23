using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;

namespace ScientificCalculator.Pages
{
    class TrignometricFunctions : Identifiers_SC
    {
        public TrignometricFunctions(AppiumDriver<IWebElement> driver) : base(driver)
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

        public void Sin30DegreeMode()
        {
            Assert.AreEqual("Degree", GetDegree().Text);
            // Test Data: sin(30) = 0.5
            GetSin().Click();
            GetButton3().Click();
            GetZero().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var sin30Result = GetFinalResult().Text;
               Assert.AreEqual("0.5", sin30Result, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void Sin60DegreeMode()
        {
            // Test Data: sin(60) = 0.8660254037844386
            GetSin().Click();
            GetButton6().Click();
            GetZero().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var sin60Result = GetFinalResult().Text;
                 Assert.AreEqual("0.8660254037844386", sin60Result, "Result is not as Expected");
            GetClearScreen().Click();
        }
        public void Cos()
        {
            // Cos
            // Test Data: cos(30) = 0.86602540378

            GetCos().Click();
            GetButton3().Click();
            GetZero().Click();
            GetRightBracket().Click();
            GetEqual().Click();
            var cosResult = GetFinalResult().Text;
            Assert.AreEqual("0.8660254037844386", cosResult, "Result is not as Expected");
            GetClearScreen().Click();
        }
        public void Tan45()
        {
            // Tan
            // Test Data: tan(45) = 1

            GetTan().Click();
            GetButton4().Click();
            GetButton5().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            var tanResult = GetFinalResult().Text;
            Assert.AreEqual("1", tanResult, "Result is not as Expected");
            GetClearScreen().Click();
        }

        public void Tan120()
        {
            // Tan
            GetTan().Click();
            GetButton1().Click();
            GetButton2().Click();
            GetZero().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            // Test Data: tan(120) = -1.73205080757
            var tanResult = GetFinalResult().Text;
            Assert.AreEqual("-1.7320508075688772", tanResult, "Result is not as Expected");
            GetClearScreen().Click();
        }
        public void Tan90()
        {
            // Tan
            GetTan().Click();
            GetButton9().Click();
            GetZero().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            // Test Data: tan(90) = error
            var tan90Result = GetFinalResult().Text;
            Assert.AreEqual("Syntax Error Or Infinity", tan90Result, "Result is not as Expected");
            GetClearScreen().Click();
        }
        public void SinRadian()
        {
            //For Radian Mode
            GetDegree().Click();
            // Validate if the mode is switched to Degrees
            Assert.AreEqual("Radian", GetDegree().Text);

            GetSin().Click();
            GetPI().Click();
            GetDivide().Click();
            GetButton6().Click();
            GetRightBracket().Click();
            GetEqual().Click();

            // Test Data: sin(pi/6) = 0.5
            var sinPiBy6Result = GetFinalResult().Text;
            Assert.AreEqual("0.5", sinPiBy6Result, "Result is not as Expected");
            GetClearScreen().Click();
        }


    }
}
