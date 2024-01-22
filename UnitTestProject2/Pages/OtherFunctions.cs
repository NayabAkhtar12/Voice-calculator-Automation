using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class OtherFunctions : TestInitialize
    {
        // Other Funcs
        //pi, !, 

        [TestMethod]
        public void OtherFunctns()
        {
            //Explicit Wait
            //  var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five")));

            // Constants pi
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/pi").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: π= 3.14159
            var PI = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("3.141592653589793", PI, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Constants pi/3
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/pi").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: π/3 = 1.04719755
            var Pidivthree = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("1.0471975511965976", Pidivthree, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Factorial (!)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: 5! = 120
            var Fact = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("120", Fact, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Factorial (zero!)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: 0! = 1
            var Factzero = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("1", Factzero, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Factorial (-50!)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: -50! = error
            var FactNegValue = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            Assert.AreEqual("Syntax Error Or Infinity", FactNegValue, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Factorial (20.0!)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: 20.0! = 2.432902e
            var FactPosValue = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
           // Assert.AreEqual("2.432902e", FactPosValue, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

            // Factorial (3.5!)
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial").Click();
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
            // Test Data: 3.5! = 11.6317283966
            var FactDecValue = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
            //Assert.AreEqual("11.6317283966", FactDecValue, "Result is not as Expected");
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();

        }

        //Mode Switch
        void Mode()
        {
            // Switch to Radian
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree").Click();
            // Validate if the mode is switched to Degrees
            Assert.AreEqual("Radian", driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree").Text);

            // Switch to Degree
            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree").Click();
            // Validate if the mode is switched to Radians
            Assert.AreEqual("Degree", driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree").Text);

        }

        // <---------------------------->

    }
    }
