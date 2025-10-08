using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tên thư mục và class đang ở mặc định đc dùng làm hộ khẩu, namespace 
// nơi nào khác muốn xài class này thì phải import/ using đủ đường dẫn package, namespace

namespace QuanChu.StudentManager.Entities
{
    internal class Student
    {
        //class xem như là 1 template, khuôn, report, biểu mẫu, bản phác thảo, blue-print, chứ những khoảng trống để fill info vào
        // một class đại diện cho 1 nhóm object đồng dạng, kiểu giống nhau
        // một class chứa đặc tính và hành vi: bạn dog ở nhà thì có màu lông, giống, kg, hành vi: vãy đuôi..
        // class chứa biến - field và hàm - method đại diện cho đặc tính và hành vi, gọi chung là: Members of a class


        private string _id;      // ID: ___________
        private string _name;    // Name: _________
        private int _yob;        // YOB: __/__/____        
        private double _gpa;     // GPA: __________


        // CONSTRUCTOR: DÙNG ĐỂ INFO VÀO TRONG PROJECT !!!!!, ĐỔ VÀO CLASS ĐỂ TẠO THÀNH OBJECT
        // new chính là clone ra from riêng cho mỗi người điền info vào
        // form gốc giống như class
        // form photo từ gốc 
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;//KO CẦN DÙNG THIS ĐỂ PHÂN BIỆT BIẾN BÊN NGOÀI
            _name = name;// VÀ ĐẶC TÍNH CỦA PROJECT
            _yob = yob;
            _gpa = gpa;
        }

        //FORM CÓ CHỪA CHỖ ĐỂ AI ĐÓ ĐIỀN INFO VÀO, HÀNH ĐỘNG ĐIỀN INFO GỌI LÀ CONSTRUCT, CONSTRUCTOR - TẠO DỰNG RA 1 SẢN PHẨM, 1 PHIÊN BẢN, 1 OBJECT
        //CTRL . ĐỂ TẠO CONSTRUCTOR

        //COI NHƯ CTOR ĐC GỌI TRƯỚC ĐỂ ĐỔ INFO VÀO OBJECT, THÌ OBJECT ĐÃ CÓ INFO ID, NAME, YOB, GPA THOÃI MÁI XÀI BÌNH THƯỜNG
        //GET(), SET(), TOSTRING()
        //BA MA CHO MÌNH INFO : ID,NAME, YOB, GPA
        //MÌNH ĐI GIAO LƯU: ĐẰNG ẤY TÊN GÌ - GETNAME()
        //GET LÀ RETURN
        //SET LÀ THAY ĐỔI LẠI INFO BA MÁ ĐÃ CHO, TỪ LÚC CONSTRUCTOR ĐỔ VÀO

        public string GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;

        //HÀM SET
        public void SetId(string id)
        {
            _id = id;
        }
        public void SetName(string name) => _name = name;
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;

        public override string? ToString()
        {
            //return base.ToString();//super bên java
            //$ is a string interpolation
            String profile = $"|{_id}|{_name}|{_yob}|{_gpa}|";
            //Console.WriteLine(profile);
            
            return profile;
        }

        //toString() chính là show ra cái profile TRÊN FB, BIOGRAPHY...
        //có Info nào thì khoe ra hết





    }
}
