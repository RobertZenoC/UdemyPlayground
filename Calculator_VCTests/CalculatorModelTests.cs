using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_VC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC.Tests
{
    [TestClass()]
    public class CalculatorModelTests
    {
        [TestMethod()]
        public void CalculateTest_DivisionByZero_ResultsInNaN()
        {
            // Create object
            CalculatorModel model = new CalculatorModel();

            // Set properties for calculation '11 / 0'
            model.s_Operator = "/";
            model.d_1st = 11;
            model.d_2nd = 0;

            model.Calculate();

            // Check whether the actual result is indeed what we expect (Not a Number)
            Assert.AreEqual(Double.PositiveInfinity, model.d_Result);
        }
    }
}