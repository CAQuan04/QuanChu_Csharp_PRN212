namespace QuanChu.Parameters.Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;//kh cần gắn value vì đằng nào hàm cũng đưa cho
            PowerByTwo(out n);
            Console.WriteLine("After calling method, n new is {0}", n);

            PowerByTwo(out int n);// kỹ thuật khai báo biến style inline ngay trong tham số out.
            Console.WriteLine("After calling method, n now is {0}", y);
        }

        public static void PowerByTwo(out int x)//Pass by referent//out: (bên trong hàm thay đổi, bên ngoài đổi theo)(object in side out(YT:GiaoLang))
        {
            //out: hàm hứa rằng sẽ có 1 giá trị x đc tạo ra
            //và return ra ngoài!!!
            //Console.WriteLine(x);// báo lỗi vì chưa có giá trị x đc gắn, đc tạo, lâsy gì mà in
            x = 8386;
            //Console.WriteLine(x);// ok vì đã có value rồi


        }

        //HÀM DƯỚI LÀ TRUYỀN THAM TRỊ, TRONG HÀM MÀ SỬA, BÊN NGOÀI GIỮ NGUYÊN
        //public static void PowerByTwo(int x)
        //{
        //    Console.WriteLine(x);
        //}

    }
}
