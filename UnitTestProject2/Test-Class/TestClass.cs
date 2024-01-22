using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Security.Cryptography;
using UnitTestProject2.POM;

namespace UnitTestProject2

{
    //Operations of Scientific Calculator
    [TestClass]
    public class TestClass :TestInitialize
    {
        Addition A1;
        AdditionPOM P;
        //Addition

        [TestMethod]
        public void PomTest()
        {
            P = new AdditionPOM(driver);
            P.ClickAdd();
        }


      //  [TestMethod]
        public void AdditionOp()
        {
            A1 = new Addition(driver);
            A1.SimpleAdditionWithIdentifiers();
            A1.DecimalAddition();
            A1.DecimalIntegerAdd();
            A1.ZeroAddition();
            A1.PositiveNegativeAddition();
            A1.NegativeIntegerAddition();
            A1.AdditionOfNegativeDecimals();
            A1.AdditionOfNegativePositiveDecimals();
            A1.ErrorHandling();
            A1.LargeNumbersAddition();
        }

      

    } 
}
