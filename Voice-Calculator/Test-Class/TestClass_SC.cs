using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using ScientificCalculator.Core;
using ScientificCalculator.Pages;

namespace ScientificCalculator.Test_Class

{

    [TestClass]
    public class TestClass_SC 
    {
        private AppiumDriver<IWebElement> driver;
        private TestInitialize testInitialize;

        public TestClass_SC()
        {
            // Initialize TestInitialize class
            testInitialize = new TestInitialize();

            // Call the Setup method from TestInitialize
            testInitialize.Setup();

            // Assign the driver instance
            driver = testInitialize.GetDriver();
        }


        Addition Add;
        Subtraction Sub;
        Multiplication Mul;
        Division Div;
        ExponentFunctions Exp;
        LogarithmicFunctions LF;
        TrignometricFunctions TF;
        OtherFunctions OF;
        
        // [TestMethod]

        [TestMethod]
        public void Addition()
        {
            Add = new Addition(driver);
            Add.ClearScreen();
            Add.BasicAddition();
            Add.DecimalAddition();
            Add.DecimalIntegerAdd();
            Add.PositiveNegativeAddition();
            Add.NegativeIntegerAddition();
            Add.ZeroAddition();
            Add.AdditionOfNegativeDecimals();
            Add.AdditionOfNegativePositiveDecimals();
            Add.ErrorHandling();
            Add.LargeNumbersAddition();
        }

        //Subtraction
        [TestMethod]
        public void Subtraction()
        {
            Sub = new Subtraction(driver);
            Sub.ClearScreen();
            Sub.BasicSubtration();
            Sub.SubtractionOfDecimals();
            Sub.DecimalIntegerSub();
            Sub.SubtractionOfZero();
            Sub.PositiveNegativeSubtraction();
            Sub.NegIntSubtraction();
            Sub.SubtractionOfNegPosDec();
            Sub.SubtractionOfNegativeDecimals();
            Sub.ErrorHandling();
            Sub.LargeNumbersSubtraction();
        }

        //Multiplication
        [TestMethod]
        public void Multiplication()
        {
            Mul = new Multiplication(driver);
            Mul.ClearScreen();
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
            Div = new Division(driver);
            Div.ClearScreen();
            Div.ClearScreen();
            Div.BasicDivision();
            Div.DivisionOfZero();
            Div.DecimalDivision();
            Div.PosNegDivision();
            Div.NegativeIntegerDivision();
            Div.DivisionOfNegativeDecimals();
            Div.NegPosDecDivision();
            Div.ErrorHandling();
            Div.LargeNumbersDiv();
        }

        //Exponent Functions
        [TestMethod]
        public void ExponentFunctions()
        {
            Exp = new ExponentFunctions(driver);
            Exp.ClearScreen();
            Exp.PowerFunction();
            Exp.ExponentOfDecimal();
            Exp.ExponentOfNegativeDecimal();
            Exp.ExponentOfLargeValue();
            Exp.ExponentOfZeroWithNegativePower();
            Exp.ExponentOfZeroWithPositivePower();
            Exp.ExponentOfPosNumberWithZero();
            Exp.ExponentialDecimalToNegativeExponent();
            Exp.ExponentialXSquare();
            Exp.SquareRoot();
            Exp.SquareRootZero();
            Exp.SquareRootNegativeNumber();
            Exp.SquareRootDecimal();
            Exp.TestSquareRootNegativeDecimal();
        }

        // LogarithmicFunctions
        [TestMethod]
        public void LogarithmicFunctions()
        {
            //LF=  LogarithmicFunctions
            LF = new LogarithmicFunctions(driver);
            LF.ClearScreen();
            LF.CommonLog();
            LF.CommonLogNeg();
            LF.CommonLogPos();
            LF.CommonLogDecimal();
            LF.NaturalLogarithm();
            LF.NaturalLogarithmNegative();
            LF.NaturalLogarithmNegativeDecimal();
            LF.NaturalLogarithmPositiveDecimal();
        }

        // TrignometricFunctions
        [TestMethod]
        public void TrignometricFunctions()
        {
            // Tf= TrignometricFunctions
            TF = new TrignometricFunctions(driver);
            TF.ClearScreen();
            TF.Sin30DegreeMode();
            TF.Sin60DegreeMode();
            TF.Cos();
            TF.Tan45();
            TF.Tan120();
            TF.Tan90();
            TF.SinRadian();
        }

        // OtherFunctions
        [TestMethod]
        public void OtherFunctions()
        {
            //OF= Other Functions
            OF = new OtherFunctions(driver);
            OF.ClearScreen();
            OF.ConstantPi();
            OF.ConstantPiDivide();
            OF.Factorial();
            OF.FactorialZero();
            OF.FactorialNegativeNum();
            OF.FactorialDecimal();
            OF.FactorialDec();
        }
    }
}
