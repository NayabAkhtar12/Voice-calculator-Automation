using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.Pages
{
    public class Identifiers
    {
        private AppiumDriver<IWebElement> driver;

        public Identifiers(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        //Identifiers
        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one")] 
       public IWebElement Button1 { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two")]
     public   IWebElement Button2 { get; set; }

       [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three")]
        public IWebElement Button3 { get; set; }


        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four")]
        public IWebElement Button4 { get; set; }


        [FindsBy(How=How.Id,Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five")]
        public IWebElement Button5 { get; set; }


        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six")]
        public IWebElement Button6 { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven")]
        public IWebElement Button7 { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight")]
        public IWebElement Button8 { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine")]
        public IWebElement Button9 { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point")]
        public IWebElement point { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero")]
        public IWebElement Zero { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/pi")]
        public IWebElement PI { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal")]
        public IWebElement Equal { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus")]
        public IWebElement Plus { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus")]
        public IWebElement Minus { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply")]
        public IWebElement Multiply { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide")]
        public IWebElement Divide { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sin")]
        public IWebElement Sin { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/tan")]
        public IWebElement Tan { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/cos")]
        public IWebElement Cos { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial")]
        public IWebElement Factorial { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket")]
        public IWebElement Leftbracket { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket")]
        public IWebElement Rightbracket { get; set; }


        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt")]
        public IWebElement SquareRoot { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/square")]
        public IWebElement Square { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern")]
        public IWebElement Power { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen")]
        public IWebElement ClearScreen { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clear")]
        public IWebElement Backspace { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree")]
        public IWebElement Degree { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log")]
        public IWebElement Log { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln")]
        public IWebElement Ln { get; set; }

        [FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult")]
        public IWebElement FinalResult { get; set; }

        //Methods for Identifiers like click
    }
}
