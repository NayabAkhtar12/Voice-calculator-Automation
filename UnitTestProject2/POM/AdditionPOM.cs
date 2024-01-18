using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.POM
{
    public class AdditionPOM:Baseclass
    {
        //Identifiers
        By Button1 = By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/five");
        By Button2 = By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/plus");
        By Button3 = By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/three");
        By Button4 = By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/equal");

        //Methods for Identifiers like click
        public void Sum()
        {
            driver.FindElement(Button1).Click();
            driver.FindElement(Button2).Click();
            driver.FindElement(Button3).Click();
            driver.FindElement(Button4).Click();
            //IMobileElement<MobileElement>
        }
        //public void ButtonEqual()
        //{
        //}
    }
}
