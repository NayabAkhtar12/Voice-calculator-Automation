using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using ScientificCalculator.Core;
using ScientificCalculator.Pages;

namespace ScientificCalculator.Test_Class
{
    [TestClass]
    public class TestClass_EMI 
    {
        EMI E;
        private AppiumDriver<IWebElement> driver;
        private TestInitialize testInitialize;

        public TestClass_EMI()
        {
            // Initialize TestInitialize class
            testInitialize = new TestInitialize();

            // Call the Setup method from TestInitialize
            testInitialize.Setup();

            // Assign the driver instance
            driver = testInitialize.GetDriver();
        }

        [TestMethod]
      public void EMI()
        {
            E = new EMI(driver);

            E.EMIWithValidValues();

            E.EMIWithLargeValues();

            E.EMIWithNullValues();

            E.EMIWithMinimumValues();

            E.EMIWithInvalidPeriod();
        }
    }
}
