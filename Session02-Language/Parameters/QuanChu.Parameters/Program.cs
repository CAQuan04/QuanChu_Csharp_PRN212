namespace QuanChu.Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            PowerByTwo(x);// gọi hàm, hy vong nhan ve binh phuong cua x
            Console.WriteLine("In Main, after calling method, x finally =" + x);

            //Expected output:
            //OUTPUT: method:10
            //        method:100
            //        main:10
            //UNIT TEST: TEST 1 HÀM COI CHẠY ĐSUNG HAY KHÔNG -> CÂU SỐ 2 TRONG ĐỀ THI PE MÔN SWT301



        }

        //CHALLENGE: VIẾT 1 HÀM NHẬN VÀO 1 CON SỐ, THAY CON SỐ ĐÓ THÀNH BÌNH PHƯƠNG, IN RA KẾT QUẢ

        public static void PowerByTwo(int x)//pass by value(bên trong hàm sửa, bên ngoài giữ nguyên)
        {
            Console.WriteLine("In method, before raising by 2, x = " + x);
            x = x * x; //x ^ 2;
            Console.WriteLine("In method, after raiding by 2, x now = " + x);
            //(bên trong hàm sửa, bên ngoài giữ nguyên) -> TRUYỀN THAM TRỊ
            // TẠO HÀM CHỈ XIN GIÁ TRỊ CỦA BIẾN BÊN NGOÀI
            //SAU ĐÓ TRONG HÀM TỰ XỬ LÝ MÀ KO ẢNH HƯỞNG BIẾN GỐC BÊN NGOÀI

        }
    }
}
