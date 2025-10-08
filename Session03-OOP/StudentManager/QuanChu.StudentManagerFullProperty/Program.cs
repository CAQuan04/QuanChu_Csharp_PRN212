using QuanChu.StudentManagerFullProperty.Entity;

namespace QuanChu.StudentManagerFullProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new();
            //new style mới bỏ vế phải
            //default cả đám,  2 chuỗi rỗng, 2 số 0 cho năm sinh và gpa
            Console.WriteLine(an.ToString());

            Student binh = new() { Id = "SE2", Name = "binh" };//object initializer
            Console.WriteLine(binh.ToString());

            Student cuong = new Student(yob: 2005,id: "SE3", name: "cuong", gpa: 9.0);//named argument
            Console.WriteLine(cuong.ToString());
        }
    }
}
