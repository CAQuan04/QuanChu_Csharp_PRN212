using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    /// <summary>
    /// This class offers methods to measure health statcus based on weight and height.
    /// Class này cung cấp các phương thức để do lường tình trạng sức khỏe dựa trên cân nặng và chiều cao.
    /// </summary>    
    public class BmiCalculator
    {
        /// <summary>
        /// This method calculates BMI based on weight and height.
        /// </summary>
        /// <param name="weight">kg</param>
        /// <param name="height">metre</param>
        /// <returns></returns>
        public static double GetBmi(double weight, double height) => weight / Math.Pow(height,2);

    }
}
