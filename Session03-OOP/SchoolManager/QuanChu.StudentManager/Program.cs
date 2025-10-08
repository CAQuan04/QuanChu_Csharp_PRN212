using QuanChu.StudentManager.Entities;

namespace QuanChu.StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentsV4();
        }
        public static void CreateStudentsV4()
        {
            
            Student an = new(gpa: 3.5, id: "S001", name: "Nguyen Van A", yob: 2000);
            //TRUYỀN DATA VÀO HÀM ĐC QUYỀN LỘN XỘN THỨ TỰ KO TUÂN THEO THỨ TỰ CỦA HÀM GỐC, NHƯNG MUỐN LÀM VẬT THÌ GHI CHÚ THÊM TÊN BIẾN ĐẦU VÀO KÈM DẤU 2 CHẤM
            // MANG Ý NGHĨA BIẾN NÀY NHẠN VALUE NÀY
            // KĨ THUẬT NÀY GỌI LÀ: NAMED ARGUMENTS, TRUYỀN THAM SỐ VÀ NÊU LUÔN TÊN THAM SỐ!!!
            Console.WriteLine(an.ToString());
        }
        public static void CreateStudentsV3()
        {
            //new kiểu mới ko khai báo kiểu của biến object, mà data type sẽ đc suy luận dựa vào giá trị gán vào
            //type infference: suy luận kiểu
            // nhìn value biết data type
            // bắt buộc chơi kiểu này phải gắn value luôn!!!
            // var x:  //báo lỗi, vì ko biết data type, ko bố trí ram đc
            var an = new Student("S001", "Nguyen Van A", 2000, 3.5); //okk vì biết x là con info do ăn theo value gắn vào
            Console.WriteLine(an.ToString());
        }
        public static void CreateStudentsV2()
        {
            //new kiểu mới ko cần ghi rõ new gì vì có vế tay trái làm mối
            Student an = new("S001", "Nguyen Van A", 2000, 3.5);
            Console.WriteLine(an.ToString());
        }
        public static void CreateStudents()
        {
            Student an = new Student("S001", "Nguyen Van A", 2000, 3.5);
            Console.WriteLine(an.ToString());
        }    
    }
}
