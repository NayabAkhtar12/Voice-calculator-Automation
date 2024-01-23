//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Android;
//using OpenQA.Selenium.Appium.Enums;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.PageObjects;
//using System;
//using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
//using OpenQA.Selenium.Support.PageObjects;
//using PageFactory = OpenQA.Selenium.Support.PageObjects.PageFactory;

//namespace UnitTestProject2

////namespace Scientific-Calculator
//{
//    [TestClass]

//    public class Addition : TestInitialize
//    {

//        public Addition(AppiumDriver<IWebElement> driver)
//        {
//            PageFactory.InitElements(driver, this);
//            this.driver = driver;
//        }

//        [TestMethod]
//        //Operations of Scientific Calculator
//        //Addition
//        public void SimpleAdditionWithIdentifiers()
//        {
//            // Addition
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Test Data: 5 + 3 = 8
//            var AdditionResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            Assert.AreEqual("8", AdditionResult, "Result is not as Expected");
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void DecimalAddition()
//        {

//            // Addition of Decimals
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Test Data: 2.5 + 1.5 = 4
//            var DecimalAdditionResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            Assert.AreEqual("4", DecimalAdditionResult, "Result is not as Expected");
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void DecimalIntegerAdd()
//        {
//            // Addition of Integer and Decimals
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Expected Result: 8 + 4.2 = 12.2
//            var DecimalIntegerAdd = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            Assert.AreEqual("12.2", DecimalIntegerAdd, "Result is not as Expected");
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void ZeroAddition()
//        {
//            // Addition of Zero
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Expected Result: 0 + 10 = 10
//            var ZeroAdditionResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            Assert.AreEqual("10", ZeroAdditionResult, "Result is not as Expected");
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void PositiveNegativeAddition()
//        {
//            // Positive-Negative Addition
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Expected Result: 5 + (-3) = 2
//            var PositiveNegativeAdditionResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            Assert.AreEqual("2", PositiveNegativeAdditionResult, "Result is not as Expected");
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void NegativeIntegerAddition()
//        {
//            // Negative Integer Addition
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();

//            // Expected Result: (-4) + (-2) = -6
//            var NegativeIntegerAddition = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            Assert.AreEqual("-6", NegativeIntegerAddition, "Result is not as Expected");
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void AdditionOfNegativeDecimals()
//        {
//            // Addition of Negative Decimals
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Expected Result: (-2.5) + (-1.5) = -4
//            var AdditionOfNegativeDecimals = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            // Assert.AreEqual with the expected value
//            Assert.AreEqual("-4", AdditionOfNegativeDecimals, "Result is not as Expected");
//            // Clear screen
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void AdditionOfNegativePositiveDecimals()
//        {
//            // Addition of Negative positive Decimals
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Expected Result: (-7) + 3.5 = -3.5
//            // Get the actual result from the EditText element
//            var AdditionOfNegativePositiveDecimals = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            // Assert.AreEqual with the expected value
//            Assert.AreEqual("-3.5", AdditionOfNegativePositiveDecimals, "Result is not as Expected");
//            // Clear screen
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void ErrorHandling()
//        {
//            // Error Handling
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Expected Result: (-7) + 3.5) = Syntax Error Or Infinity
//            // Get the actual result from the EditText element
//            var ErrorHandlingResult = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            // Assert.AreEqual with the expected value
//            Assert.AreEqual("Syntax Error Or Infinity", ErrorHandlingResult, "Result is not as Expected");
//            // Clear screen
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();
//        }

//        [TestMethod]
//        public void LargeNumbersAddition()
//        {
//            // Scenario: Handling of large numbers
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();

//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus").Click();

//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine").Click();
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal").Click();
//            // Expected Result: 999999999 + 9999999999 = 1999999998

//            // Get the actual result from the EditText element
//            var LargeNumbersAddition = driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")).Text;
//            // Assert.AreEqual with the expected value
//            Assert.AreEqual("1999999998", LargeNumbersAddition, "Result is not as Expected");
//            // Clear screen
//            driver.FindElementById("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen").Click();


//        }

//    } 
//}
