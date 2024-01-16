using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class ExponentFunctions : Baseclass
    {
        [TestMethod]

        public void LogExponentFunctions()
        {
            // Exponential positive Number
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 2 ^ 5 = 8

            // Exponent of Decimal
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 1.5 ^ 2 = 2.25

            // Exponent of Decimal
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: -1.5 ^ 2 = 2.25 

            // Exponent of large value
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 10 ^ 6 = 1,000,000 

            // Exponent of zero with negative power
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 0 ^ -6 = error

            // Exponent of zero with positive power
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 0 ^ 6 = 0

            // Exponent of 6 with zero 
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 6 ^ 0 = 1

            // Decimal to Negative Exponent Functionality
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 0.5^(-2)=4

            // Exponential (X^2)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/square").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: 5 ^ 2 = 25

            // Square Root (sqrt)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: sqrt(4) = 2

            // Square Root (sqrt) 0
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: sqrt(0) = 0

            // Square Root (sqrt)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: sqrt(-9) = error

            // Square Root (sqrt) decimal 
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: sqrt(25.0) = 5.0

            // Square Root (sqrt) negative decimal 
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
            // Test Data: sqrt(-25.0) = error
        }
            // <---------------------------->

            [TestCleanup]
        public void TestCleanup()
        {
            // Code for cleaning up resources, closing the app, etc.
            driver.Quit();
        }


    }
    }
