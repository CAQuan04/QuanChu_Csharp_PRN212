using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Music //namespace là tên thư mục chứa file source code này, nó chỉ ra nơi tập tin source đang nằm,chỉ ra hộ khẩu thường trú
    //Mặc định, 1 tập tin source code sẽ lấy project, thu mục project làm hộ khẩu
    // Tương đương khái niệm package bên java
    //java: package music;
    //1 thư mục có thể chứa nhiều tập tin. Xem điều này sau
    //1 Tập tin thì chứa nhiều class bên trong
{

    // Class khác viết ở đây
    //không viết lệnh ở đây
    
    public class Student
    {
        
    }
    internal class Program
    {
        //trong class ta viết code: biến, hàm, OOP. field and  method
        static void Main(string[] args)
        {
            PrintLyricV2();
        }

        //static chỉ chơi với static!!!!!!!
        public static void PrintLyricV4()
        {
            int publicedYear = 2024, view = 10000000;
            //Chuỗi nguyên bản , có sao in vậy
            //WYSWYG = RAW STRING, VERGATIM STRING
            //JAVA
            Console.WriteLine(@"Ngày hôm nay trời trong xanh
Đẹp như tranh
Mình cùng dạo vòng quanh cả thế giới
Đừng vội nhanh
Một hành trình nhật ký yêu thương đời mình
Hát vu vơ về tình đầu em ơi
Ngày hôm ấy là cô bé tuổi đôi mươi
Vậy mà giờ đã lớn trưởng thành hơn
Mặc váy cưới
Chẳng điều gì dừng bước em tôi
Vì người mãi kiêu sa đẹp tuyệt vời
Anh ở vùng quê khu nghèo khó đó
Có trăm điều khó
Muốn lên thành phố nên phải cố
Sao cho bụng anh luôn no
Thế rồi gặp em
Những vụn vỡ đã lỡ đêm lại nhớ
Nằm mơ gọi tên em
"); //System.out.println(); bên java

        }

        public static void PrintLyricV3()
        {
            int publicedYear = 2024, view = 10000000;
            Console.WriteLine($"Ngày hôm nay trời trong xanh\r\nĐẹp như tranh\r\nMình cùng dạo vòng quanh cả thế giới\r\nĐừng vội nhanh\r\nMột hành trình nhật ký yêu thương đời mình\r\nHát vu vơ về tình đầu em ơi\r\nNgày hôm ấy là cô bé tuổi đôi mươi {publicedYear} {view}"); //System.out.println(); bên java
        }

        public static void PrintLyricV2()
        {
            int publicedYear = 2024, view = 10000000;
            Console.WriteLine("Ngày hôm nay trời trong xanh\r\nĐẹp như tranh\r\nMình cùng dạo vòng quanh cả thế giới\r\nĐừng vội nhanh\r\nMột hành trình nhật ký yêu thương đời mình\r\nHát vu vơ về tình đầu em ơi\r\nNgày hôm ấy là cô bé tuổi đôi mươi {0} {1}", publicedYear, view); //System.out.println(); bên java
            //place-holder, điền vào chỗ trống trong chuỗi qua( đánh dấu biến thứ mấy đưa value vào thay thế)
            //{0} {1} {2}, phía ngoài chuỗi là danh sách biến theo thứ tự bạn muốn in
        }

        public static void PrintLyricV1()
        {
            int publicedYear = 2024;
            Console.WriteLine("Ngày hôm nay trời trong xanh\r\nĐẹp như tranh\r\nMình cùng dạo vòng quanh cả thế giới\r\nĐừng vội nhanh\r\nMột hành trình nhật ký yêu thương đời mình\r\nHát vu vơ về tình đầu em ơi\r\nNgày hôm ấy là cô bé tuổi đôi mươi" + publicedYear); //System.out.println(); bên java
            //ghép chuỗi với biến dùng dấu + : CONCATENATION ghép chuỗi
        }

        public static void PrintLyricV5()
        {
            // tui muốn lưu đường dẫn thư mục C:\news\; và in ra màn hình
            //string path = "C:\\news";
            string path = @"C:\news";
            Console.WriteLine(path);//cw tab = sout bên java
        }
    }

    // Class khác viết ở đây
    //không viết lệnh ở đây
    public class Lecturer
    {

    }
}
