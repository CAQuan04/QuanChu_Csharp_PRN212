using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanChu.StudentManager.AutoProperty.Entity
{
    public class Student
    {
        //backing field tự động sinh ngầm giúp khi compile và run, ko cần lặp lại điều nhàm chán
        //kỹ thuật tạo ngầm các biến backing field khi build và run app, giúp viết get set ngắn gọn đến mức tối thiểu gọi là auto-implement property, ngắn gọn là auto property
        // nếu quên cú pháp, gõ prop + tab + tab và chỉnh sửa tên kiểu và tên biến ko cần backing field

        public int Id { get; set; } 
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

    }
}
