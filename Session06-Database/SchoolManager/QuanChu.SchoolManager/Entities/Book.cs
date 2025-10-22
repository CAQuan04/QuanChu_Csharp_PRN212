using System;
using System.Collections.Generic;

namespace QuanChu.SchoolManager.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime PublicationDate { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public string Author { get; set; } = null!;

    public int BookCategoryId { get; set; }//CỘT FK TRONG TABLE, GÓC NHÌN DB



    //ĐÂY LÀ GÓC NHÌN OOP: BOOK THUỘC CATE NÀO
    public virtual BookCategory BookCategory { get; set; } = null!;
    //  BookCategory _cate;
    //  biến trỏ đến Category nào
    //mang ý nghĩa cuốn sách thuộc về Category

    //
}
