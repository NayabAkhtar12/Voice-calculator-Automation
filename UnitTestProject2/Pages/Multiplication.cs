using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class Multiplication :TestInitialize
    {
        //Multiplication
        [TestMethod]
        public void MultiplicationOp()
        {
            //Multiplication
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Expected Result: 20 * 5 = 100
            string BasicMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("100", BasicMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            //Multiplication of Decimals
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Expected Result: 2.5 * 1.5 = 3.75
            string DecimalMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("3.75", DecimalMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            //Positive-Negative Multiplication
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Expected Result: 5 * (-3) = -15
            string PositiveNegativeMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("-15", PositiveNegativeMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            //Negative Integer Multiplication
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Expected Result: (-8) * (-4) = 32
            string NegativeIntegerMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("32", NegativeIntegerMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();


            //Multiply of Negative Decimals
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Expected Result: (-2.5) * (-1.5) = 3.75
            string MultiplyNegativeDecimalsResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("3.75", MultiplyNegativeDecimalsResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            //Subtration of Negative positive Decimals
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Expected Result: (-7) * 3.5 = -24.5
            string NegPosDecMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("-24.5", NegPosDecMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Scenario: Handling of large numbers
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            //ER= 8.879
            string largeNumberDivisionResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
         //   Assert.AreEqual("8.88e+17", largeNumberDivisionResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

        }

    }
    }
