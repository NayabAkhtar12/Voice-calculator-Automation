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
        }

        //Identifiers
        public IWebElement Button1 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one"));
        public IWebElement Button2 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two"));
        public IWebElement Button3 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three"));
        public IWebElement Button4 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four"));
        public IWebElement Button5 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five"));
        public IWebElement Button6 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six"));
        public IWebElement Button7 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven"));
        public IWebElement Button8 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight"));
        public IWebElement Button9 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine"));
        public IWebElement zero => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero"));
        public IWebElement point => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point"));
        public IWebElement PI => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/pi"));
        public IWebElement Equal => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal"));
        public IWebElement Plus => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus"));
        public IWebElement Minus => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus"));
        public IWebElement Multiply => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply"));
        public IWebElement Divide => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide"));
        public IWebElement Sin => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sin"));
        public IWebElement Tan => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/tan"));
        public IWebElement Cos => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/cos"));
        public IWebElement Factorial => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial"));
        public IWebElement LeftBracket => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket"));
        public IWebElement Rightbracket => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket"));
        public IWebElement SquareRoot => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt"));
        public IWebElement Square => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/square"));
        public IWebElement Power => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern"));
        public IWebElement ClearScreen => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen"));
        public IWebElement Backspace => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clear"));
        public IWebElement Degree => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree"));
        public IWebElement Log => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log"));
        public IWebElement Ln => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln"));
        public IWebElement FinalResult => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult"));

    }
}
