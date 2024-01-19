using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Security.Cryptography;
using UnitTestProject2.POM;

namespace UnitTestProject2

//namespace Scientific-Calculator
{
   // [TestClass]
    public class pomtest :Baseclass
    {
        //Operations of Scientific Calculator
        //Addition
        //Baseclass c1;
        AdditionPOM P1;

        //[TestInitialize]
        //public void TestInitialize()
        //{
        //    c1 = new Baseclass();
        //    c1.Setup();
        //}

        [TestMethod]
        public void AdditionOp()
        {
            P1 = new AdditionPOM();
            P1.Sum();
            // P1.ButtonEqual(); // Uncomment if needed
        }

        //[TestCleanup]
        //public void TestCleanup()
        //{
        //    c1.TestCleanup();
        //}

    } 
}
