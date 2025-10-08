namespace QuanChu.Prameters.Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xài hàm out và ref
            int xOut, xRef = 6969;
            PowerByTwoOut(out xOut);
            PowerByRef(ref xRef);
            Console.WriteLine("xRef: " + xRef);
            //Muốn xài ref biến đưa vào phải có value trước: đề phòng hàm ref ko trả về thì ta vẫn có value ban đầu

        }

        //truyền tham chiếu style out, và ref
        //THỰC CHIẾN CỦA THÀY CHỈ XÀI OUT, VÌ NÓ DỄ THỰC CHIẾN, DẼ KIỂM SOÁT, THAY CHO LỆNH RETURN
        //khi ta muốn viết hàm có nhiều giá trị trả về sau 1 lần xử lý, 1 lần gọi hàm
        // biến hứng giá trị thì ko cần giá trị khởi đầu, vì hứng mà

        //REF KO ĐC XÀI INLINE

        //double result = Math.Sprt(100);

        public static void PowerByRef(ref int x)
        {
            //ref: không cam kết sẽ trả về 1 giá trị x, thích thì làm ko thích thì thôi
            x = 50000;
            //bên ngoài bị đổi ngay, nếu ko có lệnh này bên ngoài vẫn có giá trị cũ.
        }
        public static void PowerByTwoOut(out int x)
        {
            //out: bắt buộc phải có lệnh x = ??? nào đó trước khi gì tiếp!!!!
            x = 22;
        }
        
    }
}
