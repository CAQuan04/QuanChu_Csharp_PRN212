using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiTester
{
    public class BmiCalculator
    {
        //HÀM TÍNH BMI, TỰ CODE COI NÀO
        //public static double GetBmi(double weight, double height)
        //{           
        //    return weight/Math.Pow(height,2);
        //}
        public static double GetBmi(double weight, double height) => weight/Math.Pow(height,2);
    }
}
