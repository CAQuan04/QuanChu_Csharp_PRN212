namespace Bmi
{

    /// <summary>
    /// Classs này cung cấp các hàm tính chỉ số BMI (Body Mass Index) của 1 cá nhân dựa trên chiều cao và cân nặng.
    /// </summary>
    public class BmiCalculator
    {
        //singleton instance
        static double GetBmi(double weight, double height)
        {
            // tiêu chuẩn thiết kế hàm tốt, re - use ngon, giống Math.sqrt(??) java Math.Sqrt(??) C#
            // hàm nhận đầu vào trả đầu ra !!!
            // tiêu chuẩn hàm y = f(x) = x^2
            //               y = f(5) = 25
            //ko lệnh nhập và không lệnh xuất là tốt nhất!!!!


            return weight / (height * height);
        }
    }
}
