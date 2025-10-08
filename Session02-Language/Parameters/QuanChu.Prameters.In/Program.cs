namespace QuanChu.Prameters.In
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            PowerByTwo(y);
        }

        public static void PowerByTwo(in int x)
        {
            //in sẽ khiến cho biến tham số trở thành 
            //dùng biến đầu vào để tham gia biểu thức, chứ kh thay đổi nó, mang ý nghĩa: đầu vào đừng để tính toán chứ ko để gắn giá trị
            //TODO: NẾU ĐÀU VÀO CỦA HÀM NHƯ THẾ NÀO
            //pulic void doStudent(in Student s) {..} 
            //Chữ in nên đc hiểu thế nào nếu biến đàu vào là biến object????????

            int y = x * x;

            Console.WriteLine("In method, x now is: " + y);
        }
    }
}
