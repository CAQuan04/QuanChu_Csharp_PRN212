using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanChu.Nullable.Entity
{
    public class Student
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public int? Yob { get; set; }
        public double Gpa { get; set; }
        // ko thêm làm ctor thì sao nó sẽ tự động sinh giúp mình một cái ctor rỗng
        // để giúp chúng ta new default
        // oop bên java y chang
        // java dùng hàng đó, lombork giả lập viết set get ngắn gọn
        public override string? ToString()
        {
            return $"{Id}, {Name}, {Yob}, {Gpa}";
        }
    }
}
