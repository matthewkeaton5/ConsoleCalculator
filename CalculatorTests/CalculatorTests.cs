﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Models;
using MyCalculator.Interfaces;
using MyCalculator;


namespace CalculatorTests
{
    [TestClass()]
    class CalculatorTests
    {
        [TestMethod()]
        public void CalculatorTest()
        {

            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));

        }

        [TestMethod()]
        public void SumTest()
        {


            double _a = 1;
            double _b = 2;
            Func<double, double, double> _action = Operations.Sum;
            Calculator _calculator = new Calculator();


            var _result = _calculator.CreateCalculation(_a, _b, _action);

            Assert.AreEqual(_result.GetResult(), 3);


            //var _result = _calculation.calculations[0].GetResults();
            //Console.WriteLine(_result);


        }

        [TestMethod()]
        public void DifferenceTest()
        {
            double _a = 15;
            double _b = 5;
            Func<double, double, double> _action = Operations.Difference;
            Calculator _calculator = new Calculator();

            var _result = _calculator.CreateCalculation(_a, _b, _action);

            Assert.AreEqual(_result.GetResult(), 10);
        }


        [TestMethod()]
        public void MultiplicationTest()
        {
            double _a = 15;
            double _b = 5;
            Func<double, double, double> _action = Operations.Multiplication;
            
            Calculator _calculator = new Calculator();

            var _result = _calculator.CreateCalculation(_a, _b, _action);

            Assert.AreEqual(_result.GetResult(), 75);
        }
        [TestMethod()]
        public void DivisionTest()
        {
            double _a = 15;
            double _b = 5;
            Func<double, double, double> _action = Operations.Division;
            Calculator _calculator = new Calculator();

            var _result = _calculator.CreateCalculation(_a, _b, _action);

            Assert.AreEqual(_result.GetResult(), 3);

        }
        [TestMethod()]
        public void CalculationListTest()
        {




            double _a = 4;
            double _b = 2;
            Func<double, double, double> _action = Operations.Sum;
            Calculator _calculator = new Calculator();


            _calculator.CreateCalculation(_a, _b, _action);

            _action = Operations.Difference;
            _calculator.CreateCalculation(_a, _b, _action);

            _action = Operations.Division;
            _calculator.CreateCalculation(_a, _b, _action);


            _action = Operations.Multiplication;
            _calculator.CreateCalculation(_a, _b, _action);





            _calculator.Calculations.ForEach(action: delegate (ICalculation calculations)
            {
                Console.WriteLine(calculations.GetResult());

            });

        }
    }
}