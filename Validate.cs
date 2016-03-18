using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part1
{
    class Validate
    {
        public static double valid = 0;
        public static double invalid = 0;
        public static double Validator(double result, double G, double errorLimit)
        {
            
            double diff = Math.Abs(result - G);
            if (diff < errorLimit)
            {
                valid++;
            }
            else
            {
                invalid++;
            }
            return valid;
        }
    }
}
