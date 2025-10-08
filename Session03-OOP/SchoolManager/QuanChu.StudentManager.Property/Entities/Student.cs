using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanChu.StudentManager.Property.Entities
{
    public class Student
    {
        private string _id;      // ID: ___________
        private string _name;    // Name: _________
        private int _yob;        // YOB: __/__/____
        private double _gpa;     // GPA: __________

        //ctor tab tab

        public Student()
        {
            //constructor rỗng,  ko có tham số, ko có info gì, empty constructor
            //nếu xài ctor này, để new, toàn bộ các field mang giá trị default: số > 0, chữ > rỗng, bool > false
            //tương đương việc là mình lấy photo đem về nhà chưa điền, tương đương tờ giấy bài làm đc giám thị phát cho mình, mình nộp giấy trắng

        }
        public Student(string id, string name)
        {
            _id = id;//KO CẦN DÙNG THIS ĐỂ PHÂN BIỆT BIẾN BÊN NGOÀI
            _name = name;// VÀ ĐẶC TÍNH CỦA PROJECT
            // 2 đứa còn lại default
        }

        //ctor có tham số, dùng ctrl . 
        //có bao nhiêu ctor , có bấy nhiêu cách new!!!

        //GET SET TOSTRING TRUYỀN THỐNG
        //KO CÓ TOOL GENERATE, CÓ LÍ DO!!!!

        //public string GetId()
        //{
        //    return _id;
        //}
        //public string GetName()
        //{
        //    return _name;
        //}
        //public int GetYob() => _yob;
        //public double GetGpa() => _gpa;

        ////HÀM SET
        //public void SetId(string id)
        //{
        //    _id = id;
        //}
        ////== mình đổi màn hình nền của con IP17
        ////đưa ảnh mới vào - value đè vào ảnh cũ _name
        //public void SetName(string value)
        //{
        //    _name = value;
        //}
        //public void SetYob(int value) => _yob = value;
        //public void SetGpa(double value) => _gpa = value;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name 
        { get 
            { 
                return _name; //coi chừng expression bodied
            } 
            set { _name = value; } 
        }
        
        public int Yob
        {
            get => _yob; // dùng expression bodied
            set => _yob = value;
        }

        public double Gpa
        {
            get => _gpa; // hậu trường hộc máu chống lưng 
            set => _gpa = value;// giá trị cho .Gpa .Gpa =???
        }

        public override string? ToString()
        {
            string profile = $"|{_id}|{_name}|{_yob}|{_gpa}|";
            return profile;
        }
    }
}
