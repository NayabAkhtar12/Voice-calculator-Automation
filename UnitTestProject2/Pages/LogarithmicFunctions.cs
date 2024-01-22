using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class LogarithmicFunctions : TestInitialize
    {


        [TestMethod]
        public void LogFunctions()
        {
            // Common Logarithm (log)
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: log(10) = 1
            var Commonlog = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("1", Commonlog, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Common Logarithm (log)
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: log(-8) = Error
            var CommonlogNegvalue = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("Syntax Error Or Infinity", CommonlogNegvalue, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Common Logarithm (log)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: log(10.5) = 1.02118929907
            var Commonlogposvalue = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("1.021189299069938", Commonlogposvalue, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Common Logarithm (log)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: log(-20.5) = error
            var CommonlogDecimalvalue = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("Syntax Error Or Infinity", CommonlogDecimalvalue, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Natural Logarithm (ln)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: ln(8) = 2.079
            var NaturalLogarithmResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("2.0794415416798357", NaturalLogarithmResult, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Common Logarithm (ln)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: ln(-8) = Error
            var CommonLogNegResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("Syntax Error Or Infinity", CommonLogNegResult, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();


            // Common Logarithm (ln)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: ln(10.5) = 2.35137..
            var CommonLogarithmposResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("2.3513752571634776", CommonLogarithmposResult, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Common Logarithm (ln)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
        driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: ln(-20.5) = error
            var CommonLogNegDecResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("Syntax Error Or Infinity", CommonLogNegDecResult, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

        }

        // <---------------------------->

    }
    }
