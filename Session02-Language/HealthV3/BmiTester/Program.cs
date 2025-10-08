using Bmi;//import bmi.*; bên java

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(70,1.7);
            Console.WriteLine(bmi);
            Console.ReadLine();
        }
    }
}
