using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05
{
    internal class Linear
    {
        private double a;
        private double b;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public Linear(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Calculate(double x)
        {
            return A * x + B;
        }
        public void PrintEquation()
        {
            Console.WriteLine($"y = {a}x + {b}");
        }
    }
}
