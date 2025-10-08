using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bmi: " + BmiCalculator.GetBmi(70, 1.7));
        }
    }
}
