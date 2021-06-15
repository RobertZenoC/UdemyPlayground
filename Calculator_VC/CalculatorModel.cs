using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class CalculatorModel
    {
        public double Calculate(double d_1st, double d_2nd, string s_operator)
        {
            double d_result = 0;

            switch (s_operator)
            {
                case "+":
                    d_result = Add(d_1st, d_2nd);
                    break;

                case "-":
                    d_result = Substract(d_1st, d_2nd);
                    break;

                case "*":
                    d_result = Multiply(d_1st, d_2nd);
                    break;

                case "/":
                    d_result = Divide(d_1st, d_2nd);
                    break;

                default:
                    break;
            }

            return d_result;
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
