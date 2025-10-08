using QuanChu.Nullable.Entity;

namespace QuanChu.Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithObjectNullable();
        }

        public static void PlayWithObjectNullable()
        {
            Student an = new() {Id="se1", Name="an nguyen" };
            // điểm, năm sinh default 0
            Console.WriteLine(an.ToString());

            Student binh = null; // chưa xác định là đứa nào
            //Console.WriteLine(binh.ToString());//vỡ mặt vì null exception
            binh = an;
            // Tên biến ko phải là vấn đề, mà vấn đề đang trỏ ai
            
            
            if (binh != null)
            {
                Console.WriteLine("2 chàng 1 nàng bình là:");
                Console.WriteLine(binh.ToString());//an Info
            }
            else
            {
                Console.WriteLine("null dell in đc");
            }
            // khai bái biến cho bằng null và dùng biến!!!!
        }

        public static void PlayWithPrimitiveNullable()
        {
            //int yob = null; // chửi chắc luôn
            int? yob = null;
            yob = yob + 2005;// yob vẫn kh có giá trị, chứ ko phải 2005, vì khởi đầu ko bt là mấy sao dám cộng!!!
            Console.WriteLine("yob: " + yob);// in ra ko gì cả

            int? yob1 = 0;
            yob1 = yob1 + 2005;// 2005 chắc luôn
            Console.WriteLine("yob1: " + yob1);

            // khi chơi biến ? thì ta dùng toán tử != null, == null để check xem có giá trị hay ko để quyết định làm gì tiếp

            if (yob == null)
            {
                Console.WriteLine("can not add value to yob due to the current null value");
            }    
        }
    }
}
