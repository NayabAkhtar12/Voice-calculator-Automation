using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace ScientificCalculator.Pages
{
    // By default, its access modifier is internal
    class EMI
    {
        private AppiumDriver<IWebElement> driver;

        public EMI(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }

        // Identifiers
        private IWebElement LoanAmount => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_amount"));
        private IWebElement Interest => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_interest"));
        private IWebElement LoanTenure => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/loan_tenure"));
        private IWebElement Calculate => driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Calculate\"]"));
        private IWebElement Clear => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/btnClear"));
        private IWebElement TotalPayment => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/totalAmountTv"));
        private IWebElement MonthlyEMI => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/emi"));
        private IWebElement TotalInterest => driver.FindElement(By.Id("com.voice.calculator.qr.scanner.scientificcalculator.qrcode.barcode.reader:id/totalIntrestTv"));

        // Methods
        public void EMIWithValidValues()
        {
            // Expected Result
            // Amount: ₹10,000           Monthly Emi= 856
            // Interest: 5 %             Total Interest = 273
            // Period: 12 months         Total Payment: 10,273

            LoanAmount.Click();
            LoanAmount.SendKeys("10000 ");
            Interest.SendKeys("5");
            LoanTenure.SendKeys("12");
            Calculate.Click();

            var MonthlyEMIValue = MonthlyEMI.Text;
            Assert.AreEqual("856.07", MonthlyEMIValue, "Incorrect Monthly EMI");

            var TotalInterestValue = TotalInterest.Text;
            Assert.AreEqual("272.9", TotalInterestValue, "Incorrect Total Interest");

            var TotalPaymentValue = TotalPayment.Text;
            Assert.AreEqual("10272.9", TotalPaymentValue, "Incorrect Total Payment");
        }

        public void EMIWithLargeValues()
        {
            // Expected Result
            // Amount: ₹1,000,000         Monthly Emi= 13215
            // Interest: 10 %             Total Interest = 5,85,809
            // Period: 120 months         Total Payment: 15,85,809

            Clear.Click();
            LoanAmount.SendKeys("1000000 ");
            Interest.SendKeys("10");
            LoanTenure.SendKeys("120");
            Calculate.Click();

            var MonthlyEMIValue = MonthlyEMI.Text;
            Assert.AreEqual("13215.07", MonthlyEMIValue, "Incorrect Monthly EMI");

            var TotalInterestValue = TotalInterest.Text;
            Assert.AreEqual("585808.84", TotalInterestValue, "Incorrect Total Interest ");

            var TotalPaymentValue = TotalPayment.Text;
            Assert.AreEqual("1585808.84", TotalPaymentValue, "Incorrect Total Payment");
        }

        public void EMIWithNullValues()
        {
            //Expected Result
            //Amount: 0                Error
            //Interest: 0 %            Error
            //Period: 0 months         Error

            Clear.Click();
            LoanAmount.SendKeys("0 ");
            Interest.SendKeys("0");
            LoanTenure.SendKeys("0");
            Calculate.Click();
            var MonthlyEMI1 = MonthlyEMI.Text;
            Assert.AreEqual("Error", MonthlyEMI1, "Incorrect Monthly EMI");

            var TotalInterest1 = TotalInterest.Text;
            Assert.AreEqual("Error", TotalInterest1, "Incorrect Total Interest ");

            var TotalPayment1 = TotalPayment.Text;
            Assert.AreEqual("Error", TotalPayment1, "Incorrect Total Payment");

            Clear.Click();
        }

        public void EMIWithMinimumValues()
        {
            //Expected Result
            //Amount: ₹1                  EMI= 1
            //Interest: 0.1 %             Total Interst = 0
            //Period: 1 month             Total Payment =1

            Clear.Click();
            LoanAmount.SendKeys("1");
            Interest.SendKeys("0.1");
            LoanTenure.SendKeys("1");
            Calculate.Click();
            var MonthlyEMI1 = MonthlyEMI.Text;
            Assert.AreEqual("Error", MonthlyEMI1, "Incorrect Monthly EMI");

            var TotalInterest1 = TotalInterest.Text;
            Assert.AreEqual("Error", TotalInterest1, "Incorrect Total Interest ");

            var TotalPayment1 = TotalPayment.Text;
            Assert.AreEqual("Error", TotalPayment1, "Incorrect Total Payment");

            Clear.Click();
        }
        public void EMIWithInvalidPeriod()
        {
            //Expected Result
            //Amount: ₹15,000
            //Interest: 7 %
            //Period: 0 months
            //Calculate = ErrorContext on Period Field
            Clear.Click();
            LoanAmount.SendKeys("15000");
            Interest.SendKeys("7");
            LoanTenure.SendKeys("0");
            Calculate.Click();

            var TotalPayment1 = TotalPayment.Text;
            Assert.AreEqual("Error", TotalPayment1, "Incorrect Total Payment");

            Clear.Click();

        }
    }
}
