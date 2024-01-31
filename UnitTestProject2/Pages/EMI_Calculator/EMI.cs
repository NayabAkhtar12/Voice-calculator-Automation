using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Support.PageObjects;
using ScientificCalculator.Core;
using ScientificCalculator.Pages.Identifiers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator.Pages
{
    //By default Its access modifier is Internal
     class EMI : TestInitialize
    {
        private EMI_Identifiers I;

        public EMI(AppiumDriver<IWebElement> driver)
        {
            // Initialize I1 in the constructor
            I = new EMI_Identifiers(driver);
        }

        public void ClearScreen()
        {
            if (!string.IsNullOrEmpty(I.LoanAmount.Text))
            {
                // If not clear, perform the clear operation
                I.Clear.Click();

                // You can add an assertion or print a message to verify the clear operation
                Assert.IsTrue(string.IsNullOrEmpty(I.LoanAmount.Text), "Result screen is not cleared after clicking ClearScreen.");

                // Or print a message
                Console.WriteLine("Result screen has been cleared.");
            }
            else
            {
                // The result screen is already clear
                Console.WriteLine("Result screen is already clear.");
            }
        }
        //Methods for Identifiers like click
        public void EMIWithValidValues()
        {
            //Amount: ₹10,000           Monthly Emi= 856
            //Interest: 5 %             Total Interest = 273
            //Period: 12 months         Total Payment: 10,273

            // Assert.IsNotNull(I, "Identifiers instance is not initialized");
            //I.Button5.Click();
            //I.Plus.Click();
            //I.Button3.Click();
            //I.Equal.Click();
            //var AdditionResult = I.FinalResult.Text;
            //Assert.AreEqual("8", AdditionResult, "Result is not as Expected");
            I.Clear.Click();
        }
        public void EMIWithLargeValues()
        {
            //Amount: ₹1,000,000         Monthly Emi= 13215
            //Interest: 10 %             Total Interest = 5,85,809
            //Period: 120 months         Total Payment: 15,85,809


        }
        public void EMIWithNullValues()
        {
            //Amount: 0                Error
            //Interest: 0 %            Error
            //Period: 0 months         Error

        }

        public void EMIWithMinimumValues()
        {
            //Amount: ₹1                  EMI= 1
            //Interest: 0.1 %             Total Interst = 0
            //Period: 1 month             Total Payment =1

        }
        public void EMIWithInvalidPeriod()
        {
        //Amount: ₹15,000
        //Interest: 7 %
       //Period: 0 months
       //Calculate = ErrorContext on Period Field

        }

    }
}
