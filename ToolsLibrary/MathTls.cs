using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class MathTls
    {
        public double X { get; set; }
        public double Epselan { get; set; }
        public MathTls(double X, double Epselan)
        {
            this.X = X;
            this.Epselan = Epselan;
        }
        public double CalcWay1()
        {
            return Math.Pow(Math.E, X);
        }
        private double GetAn(double a, int n)
        {
            if (n == 1)
                return 1;
            else
                return a * X / (n - 1);
        }
        public double CalcWay2(out int n)
        {
            n = 0;
            double a = 1;
            double Sum = 0;
            while (Math.Abs(a) > Epselan)
            {
                a = GetAn(a, ++n);
                Sum += a;
            }
            return Sum;
        }
    }
}
