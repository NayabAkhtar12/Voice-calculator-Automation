using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class Division :TestInitialize
    {
        [TestMethod]
        public void DivisionOp()
        {
            // Division
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
           //Expected Result: 100/5 = 20
            string divisionResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("20", divisionResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Division by Zero
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            //Expected Result: 8/0 = Syntax Error Or Infinity
            string divisionByZeroResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("Syntax Error Or Infinity", divisionByZeroResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Division of Decimals
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            //Expected Result: 1.5/2.5 = 0.6
            string decimalMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("0.6", decimalMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Positive-Negative Division
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            //Expected Result: 5/(-3) = -1.66666666667
            string positiveNegativeMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("-1.6666666666666667", positiveNegativeMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Negative Integer Division
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            //Expected Result: (-8)/(-4) = 2
            string NegativeIntegerMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("2", NegativeIntegerMultiplicationResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Division of Negative Decimals
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            //Expected Result: (-4.5)/(-2.5) = 1.8
            string negativeDecimalMultiplicationResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("1.8", negativeDecimalMultiplicationResult);
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
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
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
            string largeNumberDivisionResult = driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult").Text;
            Assert.AreEqual("1.12612612626816", largeNumberDivisionResult);
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

        }


        // <---------------------------->

    }
    }
