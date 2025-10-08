namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeBmi();
        }
        //CHALLGE #1: VIẾT HÀM TÍNH VÀ IN RA CHỈ SỐ bmi - CHỈ SỐ KHỐI CƠ THỂ - BODY MASS INDEX
        //NÓI VỀ TÌNH TRẠNG MẬP ỐM CỦA AI ĐÓ DỰA TRÊN CHIỀU CAO VÀ CÂN NẶNG
        //bmi = cân nặng (kg) / (chiều cao (m) * chiều cao (m))
        //NẾU BMI TỪ 18.5 -24.9 CHUẨN FROM

        // static chơi với static
        static void GeBmi()
        {
            double weight = 70; // Cân nặng (kg)
            double height = 1.75; // Chiều cao (m)
            double bmi = weight / (height * height); // Tính chỉ số BMI
            Console.WriteLine($"Bmi (w:{weight} | h:{height}): {bmi}");  
        }

    }
    //ĂN ĐÒN
}
