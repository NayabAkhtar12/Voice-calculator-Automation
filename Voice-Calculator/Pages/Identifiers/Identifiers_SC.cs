using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.PageObjects;
using System.Drawing.Text;
using System.Security.Principal;

namespace ScientificCalculator.Pages
{
    public class Identifiers_SC
    {
        private readonly AppiumDriver<IWebElement> driver;

        public Identifiers_SC(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
           // PageFactory.InitElements(driver, this); // Initialize elements using PageFactory
        }

        //Locating Elements using FindsBy method
        //[FindsBy(How = How.Id, Using = "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one")]
        //[CacheLookup]
        //private IWebElement ButtonOne { get; set; }
        //public IWebElement GetOne()
        //{
        //    return ButtonOne;
        //}

        // Readonly properties for web elements
        private IWebElement Button1 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one"));
        private IWebElement Button2 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two"));
        private IWebElement Button3 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three"));
        private IWebElement Button4 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four"));
        private IWebElement Button5 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five"));
        private IWebElement Button6 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six"));
        private IWebElement Button7 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven"));
        private IWebElement Button8 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight"));
        private IWebElement Button9 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine"));
        private IWebElement zero => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero"));
        private IWebElement point => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point"));
        private IWebElement PI => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/pi"));
        private IWebElement Equal => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal"));
        private IWebElement Plus => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus"));
        private IWebElement Minus => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/minus"));
        private IWebElement Multiply => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/multiply"));
        private IWebElement Divide => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/divide"));
        private IWebElement Sin => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sin"));
        private IWebElement Tan => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/tan"));
        private IWebElement Cos => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/cos"));
        private IWebElement Factorial => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/factorial"));
        private IWebElement LeftBracket => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/leftBracket"));
        private IWebElement Rightbracket => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/rightBracket"));
        private IWebElement SquareRoot => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/sqrt"));
        private IWebElement Square => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/square"));
        private IWebElement Power => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/powern"));
        private IWebElement ClearScreen => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clearScreen"));
        private IWebElement Backspace => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/clear"));
        private IWebElement Degree => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/degree"));
        private IWebElement Log => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/log"));
        private IWebElement Ln => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/ln"));
        private IWebElement FinalResult => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/finalResult"));

       

        // Getter methods to access the web elements
        public IWebElement GetButton1() => Button1;
        public IWebElement GetButton2() => Button2;
        public IWebElement GetButton3() => Button3;
        public IWebElement GetButton4() => Button4;
        public IWebElement GetButton5() => Button5;
        public IWebElement GetButton6() => Button6;
        public IWebElement GetButton7() => Button7;
        public IWebElement GetButton8() => Button8;
        public IWebElement GetButton9() => Button9;
        public IWebElement GetZero() => zero;
        public IWebElement GetPoint() => point;
        public IWebElement GetPI() => PI;
        public IWebElement GetEqual() => Equal;
        public IWebElement GetPlus() => Plus;
        public IWebElement GetMinus() => Minus;
        public IWebElement GetMultiply() => Multiply;
        public IWebElement GetDivide() => Divide;
        public IWebElement GetSin() => Sin;
        public IWebElement GetTan() => Tan;
        public IWebElement GetCos() => Cos;
        public IWebElement GetFactorial() => Factorial;
        public IWebElement GetLeftBracket() => LeftBracket;
        public IWebElement GetRightBracket() => Rightbracket;
        public IWebElement GetSquareRoot() => SquareRoot;
        public IWebElement GetSquare() => Square;
        public IWebElement GetPower() => Power;
        public IWebElement GetClearScreen() => ClearScreen;
        public IWebElement GetBackspace() => Backspace;
        public IWebElement GetDegree() => Degree;
        public IWebElement GetLog() => Log;
        public IWebElement GetLn() => Ln;
        public IWebElement GetFinalResult() => FinalResult;
    }
}
