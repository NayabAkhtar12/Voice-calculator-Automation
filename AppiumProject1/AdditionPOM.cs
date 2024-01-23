//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Android;
//using OpenQA.Selenium.Appium.Interfaces;
//using OpenQA.Selenium.Support.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnitTestProject2.POM
//{
//    public class AdditionPOM:TestInitialize
//    {
//        public AdditionPOM(AppiumDriver<IWebElement> driver)
//        {
//            PageFactory.InitElements(driver, this);
//            this.driver = driver;
//        }

//        //Identifiers
//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one")] 
//        IWebElement Button1 { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two")]
//        IWebElement Button2 { get; set; }

//       [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three")]
//        IWebElement Button3 { get; set; }


//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four")]
//        IWebElement Button4 { get; set; }


//        [FindsBy(How=How.Id,Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five")]
//        IWebElement Button5 { get; set; }


//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six")]
//        IWebElement Button6 { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven")]
//        IWebElement Button7 { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight")]
//        IWebElement Button8 { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine")]
//        IWebElement Button9 { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point")]
//        IWebElement point { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero")]
//        IWebElement Zero { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/pi")]
//        IWebElement PI { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal")]
//        IWebElement Equal { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus")]
//        IWebElement Plus { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus")]
//        IWebElement Minus { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply")]
//        IWebElement Multiply { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide")]
//        IWebElement Divide { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sin")]
//        IWebElement Sin { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/tan")]
//        IWebElement Tan { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/cos")]
//        IWebElement Cos { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial")]
//        IWebElement Factorial { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket")]
//        IWebElement Leftbracket { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket")]
//        IWebElement Rightbracket { get; set; }


//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt")]
//        IWebElement SquareRoot { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/square")]
//        IWebElement Square { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern")]
//        IWebElement Power { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen")]
//        IWebElement ClearScreen { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clear")]
//        IWebElement Backspace { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree")]
//        IWebElement Degree { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log")]
//        IWebElement Log { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln")]
//        IWebElement Ln { get; set; }

//        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")]
//        IWebElement FinalResult { get; set; }

//        //Methods for Identifiers like click
//        public void ClickAdd()
//        {
//            Button5.Click();
//            Plus.Click();
//            Button3.Click();
//            Equal.Click();
//            var AdditionResult = FinalResult.Text;
//            Assert.AreEqual("8", AdditionResult, "Result is not as Expected");
//            ClearScreen.Click();
                                               
//        }
//    }
//}
