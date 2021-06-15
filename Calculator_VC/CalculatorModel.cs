using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class CalculatorModel
    {
        // Property
        public double d_Result { get; private set; }

        // Constructor
        public CalculatorModel()
        {
            d_Result = 0;
        }

        public void Calculate(double d_1st, double d_2nd, string s_operator)
        {
            switch (s_operator)
            {
                case "+":
                    d_Result = Add(d_1st, d_2nd);
                    break;

                case "-":
                    d_Result = Substract(d_1st, d_2nd);
                    break;

                case "*":
                    d_Result = Multiply(d_1st, d_2nd);
                    break;

                case "/":
                    d_Result = Divide(d_1st, d_2nd);
                    break;

                default:
                    break;
            }
        }

        private double Add(double d_1st, double d_2nd)
        {
            double d_sum = d_1st + d_2nd;

            return d_sum;
        }

        private double Substract(double d_minuend, double d_subtrahend)
        {
            double d_difference = d_minuend - d_subtrahend;

            return d_difference;
        }

        private double Multiply(double d_multiplier, double d_multiplicand)
        {
            double d_product = d_multiplier * d_multiplicand;

            return d_product;
        }

        private double Divide(double d_dividend, double d_divisor)
        {
            double d_fraction = d_dividend / d_divisor;

            return d_fraction;
        }
    }
}
