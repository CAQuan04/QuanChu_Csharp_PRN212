using System.Collections;

namespace QuanChu.BasicCollection
{

    public class Student
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }// auto implemented property
        // tự động generate backing field _id, _name.... ngắm

        //ko thêm làm ctor, thì ctor default empty để tự tạo

        //ctrl .
        public override string ToString()
        {
            return $"{Id}, {Name},{Yob},{Gpa}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PlayWithList");
            PlayWithList();
            Console.WriteLine("--------------");
            Console.WriteLine("PlayWithListV2");
            PlayWithListV2();
            Console.WriteLine("--------------");
            Console.WriteLine("PlayWithArrayList");
            PlayWithArrayList();
        }

        public static void PlayWithListV2()
        {
            //đây là túi đa năng, đựng nhiều đồ nhưng chỉ cùng 1 loại
            //List<Student> bag = new List<Student>();//java phải là new ArrayList();
            List<Student> bag = new();

            //bag.Add(3.14)//chửi, chỉ chơi với Sv thôi
            //chỉ chứa Student, nên biết chắc chắn, YOB, NAME, GPA okk luôn !!!!

            Student an = new Student() { Id = "SE2", Name = "An", Yob = 2005 };
            bag.Add(an);

            Student binh = new Student() { Id = "SE3", Name = "Binh", Yob = 2005 };
            bag.Add(binh);

            bag.Add(new Student() { Id = "SE4", Name = "Cuong" });

            Console.WriteLine($"There is/are {bag.Count} student(s)");
            Console.WriteLine("The list of Students");
            for (int i = 0; i < bag.Count; i++)
            {
                Console.WriteLine(bag.ElementAt(i)); //inToString;
                Console.WriteLine(bag[i]);

                Console.WriteLine(bag.ElementAt(i).Name); //~ get (i) bên java
                                                          //IN NAME THÔI VÌ LÀ STUDENT, LẤY GET 1 PHẦN ĐỂ IN
                Console.WriteLine(bag[i].Id);
            }
        }
        public static void PlayWithList ()
        {
            //đây là túi đa năng, đựng nhiều đồ nhưng chỉ cùng 1 loại
            //List<Student> bag = new List<Student>();//java phải là new ArrayList();
            List<Student> bag = new();

            //bag.Add(3.14)//chửi, chỉ chơi với Sv thôi
            //chỉ chứa Student, nên biết chắc chắn, YOB, NAME, GPA okk luôn !!!!

            Student an = new Student() { Id = "SE2", Name = "An", Yob = 2005 };
            bag.Add(an);

            Student binh = new Student() { Id = "SE3", Name = "Binh", Yob = 2005 };
            bag.Add(binh);

            bag.Add(new Student() { Id = "SE4", Name = "Cuong" });

            Console.WriteLine($"There is/are {bag.Count} student(s)");
            Console.WriteLine("The list of Students");
            for (int i = 0; i < bag.Count; i++)
            {
                Console.WriteLine(bag[i].ToString());
            }
            //Xóa bình khỏi dsach nhưng thật ra vẫn còn tồn tại bên ngoài
            //CHỨNG MINH
            bag.Remove(binh); // xóa con trỏ trong túi thôi
            Console.WriteLine("After removing, the bag now has: ");
            for(int i = 0;  i < bag.Count; i++)
            {
                Console.WriteLine(bag[i].ToString());
                //còn an cuong và Binh ở ngoài dsach
            }
            Console.WriteLine("Binh day ne: " + binh);// khỏi gọi ToString(); cx đc

            //làm sao xóa Cường, lôi tọa độ cường ra

            //Student cuong = bag[1];//lấy phần tử thứ [1] chính là lấy tọa độ vùng new cuong, cat vào biến
            //bag.Remove(cuong);

            Student cuong = bag[1];
            bag.Remove(bag[1]);//Xóa hẳn Cường trong dsach


            Console.WriteLine("After Removing Cuong, the bag now has:");
            for(int i = 0; i < bag.Count; i++)
            {
                Console.WriteLine(bag[i].ToString());         
            }
            //Console.WriteLine(" Cuong em đay: " + cuong);
        }


        public static void PlayWithArrayList()
        {
            //java: List<Student> bag = new ArrayList<>();
            //      ArrayList<Student> bag = new ArrayList<>();// túi bự trong ram để nhét sv nào
            //                  <bắt buộc phải có>, kỹ thuật Generic
            //                  1 class tại thời điểm chỉ chơi với 1 class kahsc bên trong List<Student> bag đc hiểu là bag chỉ chứa Student, ko ai khác
            //Java: List, ArrayList là túi đa năng, đựng nhiều obj bên trong 
            //                  nhưng tại 1 thời điểm chỉ chấp  nhận chứ nhiều obj chỉ thuốc về một loại <Stundent> <Lecturer> <Object> <User> <1 loại>

            //C#: ArrayList kh phải túi Generic, tức là chứa nhiều và lộn xộn
            //C#: list là túi GENERIC, TỨC LÀ NHIỀU NHƯNG KO LỘN XỘN
            //                                NHIỀU NHƯNG CHỈ 1 LOẠI
            //LIST TRONG C# NEW ĐC NHEN, XÀI PHỔ BIẾN NHẤT --- Y CHANG ARRAYLIST
            //ARRAYLIST TRONG C# KO CÓ TƯƠNG ĐƯƠNG BÊN JAVA

            ArrayList bag = new ArrayList(); // nhét nhiều và lộn xộn
            bag.Add(1);
            bag.Add(2);
            bag.Add(3.14);
            bag.Add('A');
            bag.Add("Ngọc Trinh");

            Student an = new Student() { Id = "Se2", Name = "An", Yob = 2005 };
            bag.Add(an);

            bag.Add(new Student() {Id ="SE2", Name = "Binh"  });

            Console.WriteLine("Bag count: " + bag.Count);

            for (int i = 0; i < bag.Count; i++)
            {
                Console.WriteLine(bag[i]); //[i] lấy phần tử thứ i
            } 
                
        }
    }
}
