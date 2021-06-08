using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jan,");
            Console.WriteLine("I'm Robbie and I like programming!");
            Console.WriteLine("But I like " + Console.ReadLine() + " even better!");
            Console.ReadKey();

            float pi = 3.14F;
            float pi2 = 0.0314e2F;
            float topval = float.MaxValue;

            Console.WriteLine("pi: {0}, pi2: {1}, topval short: {2}, topval: {3:F}", pi, pi2, topval, topval);
            Console.ReadKey();

        }
    }
}
