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
    public class TestClass : TestInitialize
    {
        Addition A1;
        Addition T;
        Subtraction S;
        Multiplication Mul;
        Division D;
        //Addition
         [TestMethod]
        public void Addition()
        {
            T = new Addition(driver);
            T.BasicAddition();
            T.DecimalAddition();
            T.DecimalIntegerAdd();
            T.PositiveNegativeAddition();
            T.NegativeIntegerAddition();
            T.ZeroAddition();
            T.AdditionOfNegativeDecimals();
            T.AdditionOfNegativePositiveDecimals();
            T.ErrorHandling();
            T.LargeNumbersAddition();
        }

        //Subtraction
        [TestMethod]
        public void Subtraction()
        {
            S = new Subtraction(driver);
            S.BasicSubtration();
            S.SubtractionOfDecimals();
            S.DecimalIntegerSub();
            S.SubtractionOfZero();
            S.PositiveNegativeSubtraction();
            S.NegIntSubtraction();
            S.SubtractionOfNegPosDec();
            S.SubtractionOfNegativeDecimals();
            S.ErrorHandling();
            S.LargeNumbersSubtraction();
        }

        //Multiplication
        [TestMethod]
        public void Multiplication()
        {
            Mul = new Multiplication(driver);

            Mul.MultiplicationOp();
            Mul.DecimalMultiplication();
            Mul.PosNegMultiplication();
            Mul.MultiplicationOfZero();
            Mul.NegativeIntegerMultiplication();
            Mul.MultiplicationOfNegativeDecimals();
            Mul.NegPosDecMultiplication();
            Mul.ErrorHandling();
            Mul.LargeNumbersMultiplication();
        }
        //Division
        [TestMethod]
        public void Division()
        {
            D = new Division(driver);
            D.BasicDivision();
            D.DivisionOfZero();
            D.DecimalDivision();
            D.PosNegDivision();
            D.NegativeIntegerDivision();
            D.DivisionOfNegativeDecimals();
            D.NegPosDecDivision();
            D.ErrorHandling();
            D.LargeNumbersDiv();
        }
    }
}
