using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanChu.StudentManagerFullProperty.Entity
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //ctor tab tab constructor rõng, các _ sẽ backing trong field là default

        public Student()
        {
            
        }

        public Student(string id, string name, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Gpa = gpa;
        }

        //ctrl . generate constructor có tham số 
        // get set style cũ hoặc mới. Gọi là property 
        //toString()
        //(getId,) biến bảo hành đóng gói get set vì nó tự nhiên
        
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        //gõ propfull tab tab nó sẽ gợi ý mẫu về get set kiểu mới

        public int Yob
        {
            get { return _yob; }
            set { _yob = value; }
        }
        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        // ? là gì?? có thể bỏ đi đc ko
        //đc và ko đc tùy ngữ cảnh, nhưng trong tình huống biến object chăc chắn bỏ được mà không thay đổi ngữ cảnh, ko thay đổi kết quả xử lý
        public override string? ToString()
        {
            return $"{_id}|| {Name} || {Yob} || {_gpa}";
            //      _id là field, Name là property
        }





    }
}
    