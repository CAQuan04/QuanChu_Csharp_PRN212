using Poem.XuanQuynh; //improt bên Java

namespace Poem//là thư mực chứa source code
{
    internal class Program
    {
        int yob = 2004;

        static void Main(string[] args)
        {
            //PrintTuAy();
            //UseVerbatim();
            Song.PrintSOngCode();
        }

        static void UseVerbatim()
        {
            //ứng dụng cảu verbatim 
            //1. dùng trong đường dẫn tên tập tin khi có ký tự đặc biệt liên quan đến \
            //giúp cho chuỗi tự nhiên như bản gốc!!!!
            //2. đôi khi verbatim còn dùng trong chuỗi CSDL có thông tin server \ hay /
            //3.  Verbatim có thể dùng kết họp  luôn $ interpolation
            string path = @"C:\SU24\news";
            string path2 = @"E:\";

            Console.WriteLine($@"Path: {path} \/ {path2}");
        }
        //có câu: static chơi với static
        static void PrintTuAy()
        {
            int year = 2024; //Khai bao biến dùng cú pháp camel Case Nation - cú pháp con lạc đà
            //ví dụ: salary, basicSalary
            int month = 5;

            //cw: Console.WriteLine();
            Console.WriteLine("Year: " + year + " / 5");//ghếp chuỗi style truyền thống - string concatenated dùng dấu +

            Console.WriteLine("Year:{0} / {1}", year, month);//place-holder: điền vào chổ trống
                                    //%d bên C
                                    //nếu in nhiều biến {0} {1} {2}, các biến cách nhau = dấu phẩy

            Console.WriteLine($"Year: {year} / {month}");//interplation: nội suy giái trị biến trong chuỗi

            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ");
            //Console.WriteLine("Mặt trời chân lý chối qua tim");
            //Console.WriteLine("Hồn tôi là một vườn hoa lá");
            //Console.WriteLine("Rất rộn hương và rộn tiếng chim");
            // Ctrl K C là comment 1 đám code 
            //Ctrl K U là comment, mở code trở lại

            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ\nMặt trời chân lý chối qua tim\nHồn tôi là một vườn hoa lá\nRất rộn hương và rộn tiếng chim");

            Console.WriteLine(@"TỪ ẤY

Từ ấy trong tôi bừng nắng hạ
Mặt trời chân lý chối qua tim
Hồn tôi là một vườn hoa lá
Rất rộn hương và rộn tiếng chim");
            //@ biến chuỗi thành chuỗi nguyên bản - có ký tự gì bên trong chuỗi lúc edit se in y chang
            //Có \n thì in \n luôn, phế võ công tất cả các ký tự đb thành 
            //có sao in vậy
            //Kỹ thuật chuỗi kiểu này gọi là verbatim
            //Bên Java có y chang

            Console.WriteLine(@"
<html>
    <head>
    </head>
    <body>
        <div>

        </div>
    </body>
</html>");


        }
    }
}
