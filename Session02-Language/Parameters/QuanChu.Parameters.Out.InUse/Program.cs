using System.Diagnostics.Metrics;
using System.Threading;

namespace QuanChu.Parameters.Out.InUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xài hàm thì phải cso biến để hứng, truyền
            //trong hàm sửa bên ngoài đổi theo;
            int countA, countE, sumA, sumE, countO, sumO;
            countA = CalculateIntList(out sumA, out countE, out sumE, out countO, out sumO);
            Console.WriteLine("Count all" + countA);
            Console.WriteLine("Sum all" + sumA);
            Console.WriteLine("Count evens" + countE);
            Console.WriteLine("Sum evens" + sumE);
            Console.WriteLine("Count odds: " + countO);
            Console.WriteLine("Sum odds: " + sumO);
            //1 2 3 4 5 6 7 8 9 10
            //out

        }




        //CHALLENGE: VIẾT HÀM, 1 HÀM NHEN, ĐẾM VÀ TÍNH TRONG DÃY SỐ TỪ 1 ĐẾN 100
        //CÓ BN CON SỐ
        //TỔNG TỪ 1 ĐẾN 100
        //CÓ BN SỐ CHẴN
        //TỔNG CÁC SỐ CHẴN


        //SỐ LẺ....
        public static int CalculateIntList(out int allSum, out int evenCount, out int evenSum, out int oddCount, out int oddSum)
        //out là gì
        //hàm out là chắc chắn trong hàm sẽ gán giá trị cho biến
        {
            allSum = 0;
            evenCount = 0;
            evenSum = 0;
            int allCount = 0;
            oddCount = 0;
            oddSum = 0;

            //tính, đếm, dùng for và if để check
            for (int i = 1; i <= 10; i++)
            {
                allCount++; //cứ có 1 con số đếm luôn; số lượng tất cả
                allSum += i; //cứ có 1 con số cộng luôn; tổng tất cả
                if (i % 2 == 0)
                {
                    evenCount++;
                    evenSum += i;
                }
                //else 
                else
                {
                    oddCount++;
                    oddSum += i;
                }
            }
            return allCount;
        }
    }
}
    
