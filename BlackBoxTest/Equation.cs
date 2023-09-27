using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBoxTest
{
    public class Equation
    {
        public static double Solve(double a, double b)
        {
            if (a == 0)
            {
                // Phương trình vô nghiệm hoặc có vô số nghiệm
                if (b == 0)
                {
                    return double.PositiveInfinity; // Vô số nghiệm
                }
                else
                {
                    return double.NegativeInfinity; // Vô nghiệm
                }
            }
            else
            {
                // Phương trình có nghiệm duy nhất
                return -b / a;
            }
        }
    }
}

