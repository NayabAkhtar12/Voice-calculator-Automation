using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.Pages.Identifiers
{  
        public class EMI_Identifiers
        {
            private AppiumDriver<IWebElement> driver;

            public EMI_Identifiers(AppiumDriver<IWebElement> driver)
            {
                this.driver = driver;
            }

        public IWebElement LoanAmount => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_amount"));
        public IWebElement Interest => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_interest"));
        public IWebElement LoanTenure => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_tenure"));
        public IWebElement Calculate => driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Calculate\"]"));
        public IWebElement Clear => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/btnClear"));

        //For Keyboard
        //public IWebElement Button1 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/one"));
        //public IWebElement Button2 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/two"));
        //public IWebElement Button3 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three"));
        //public IWebElement Button4 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/four"));
        //public IWebElement Button5 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five"));
        //public IWebElement Button6 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/six"));
        //public IWebElement Button7 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/seven"));
        //public IWebElement Button8 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/eight"));
        //public IWebElement Button9 => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/nine"));
        //public IWebElement zero => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/zero"));
        //public IWebElement point => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/point"));
        //public IWebElement PI => driver.FindElement(By.Id(@"com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/pi"));

    }
}
