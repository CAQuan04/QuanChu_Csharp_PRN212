using QuanChu.StudentManager.Property.Entities;
//== import cmm.giaolang.studentmanager.property.entities;
namespace QuanChu.StudentManager.Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateObjectStylePropertyV2();
        }

        public static void CreateObjectStylePropertyV2(){
            Student an = new Student() { Yob = 2000, Name = "Nguyen Van A", Id = "S001", Gpa = 3.5,};
            //vừa new vừa gọi hàm set cùng set
            //kỹ thuật này vừa new vừa set qua property, gọi là Object Initializer
            Console.WriteLine(an.ToString());
        }

        public static void CreateObjectStyleProperty()
        {
               Student an = new Student();//empty bên trong do xài ctor rỗng, xài ctor full tham số có đổ info vào.
            //để hay ko thì mình vẫn độ info đc

            //đổ obj hay qua hàm SetYob() nay thay băng .Yob;
            an.Yob = 2000;
            an.Name = "Nguyen Van A";   
            an.Id = "S001";
            an.Gpa = 3.5;
            //CỰC KÌ TỰ NHIÊN NHƯ CĂN CƯỚC CÔNG DÂN, KO HÀM GET, SET THUẦN STYLE LẬP TRÌNH
            //ĐẰNG SAU VẪN CÓ THẰNG _ GÁNH GIÙM 
            Console.WriteLine("AN FULL: " + an.ToString());
        }

        //public static void CreateObject()
        //{
        //    Student an = new Student();
        //    Console.WriteLine("An first: " + an.ToString());
        //    //độ object thôi
        //    an.SetId("S001");
        //    an.SetName("Nguyen Van A");
        //    an.SetYob(2000);
        //    an.SetGpa(3.5);
        //    Console.WriteLine("An second: " + an.ToString());

        //    // gọi GET riêng
        //    Console.WriteLine("An nane: " + an.GetName());
        //    //                                 _name; đc in  ra 
            
        //}
    }
}
