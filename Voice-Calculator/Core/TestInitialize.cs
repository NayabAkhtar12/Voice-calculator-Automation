using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;


namespace ScientificCalculator.Core
{
    public class TestInitialize
    {

        private AppiumDriver<IWebElement> driver;
        public AppiumDriver<IWebElement> GetDriver()
        {
            return driver;
        }
        //s8
        [TestInitialize]
        public void Setup()
        {
            AppiumOptions Cap = new AppiumOptions();
            Cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            Cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy S8");
            Cap.AddAdditionalCapability(MobileCapabilityType.Udid, "ce11171b9bd3d81105");
            Cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9");
            Cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
            Cap.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader.ScientificCal");
            Cap.AddAdditionalCapability(MobileCapabilityType.App, "/data/app/com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader--MO3PCVgfH7n4Uv5R86seQ==/base.apk");

            //Navigate to App
            driver = new AndroidDriver<IWebElement>(new Uri("http://192.168.100.22:4723/"), Cap, TimeSpan.FromSeconds(180));

              driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Code for cleaning up resources, closing the app, etc.
            driver.CloseApp();
            driver.Quit();
        }
    }
}
