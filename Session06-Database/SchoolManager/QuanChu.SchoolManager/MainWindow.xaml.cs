using Microsoft.EntityFrameworkCore;
using QuanChu.SchoolManager.Entities;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanChu.SchoolManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Prn212BookstoreContext ctx = new();//new ngắn

            List<Book> bag = ctx.Books.Include("BookCategory").ToList();//convert từ DBset<> thành List<>
            StudentListDataGrid.ItemsSource = bag;//đổ dữ liệu vào datagrid

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Prn212BookstoreContext ctx = new();

            Book book = new Book()
            {
                BookId = 100,
                BookName = "asdsd",
                Description = "adasda",
                Author = "Japan",
                Price = 12313,
                Quantity = 100,
                PublicationDate = new DateTime(2020, 10, 31),
                BookCategoryId = 5//Cate 5 | self help}
            };
            ctx.Books.Add(book);//add vào bag, cái giỏ
            ctx.SaveChanges();//chính thức xong table


            //F5 lại cái Grid, đổ lại lưới để có dòng mới

            ctx = new();// quan trọng !!!! phải new lại context
            List<Book> bag = ctx.Books.Include("BookCategory").ToList();//convert từ DBset<> thành List<>
            StudentListDataGrid.ItemsSource = bag;//đổ dữ liệu vào datagrid
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //đi bắt cái dòng đã chọn, học rồi, nhưng em đã quên
            Book? selected = StudentListDataGrid.SelectedItem as Book;
            if (selected == null)
            {
                MessageBox.Show("Chọn 1 cuốn sách để edit");
                return;
            }

            selected.BookName = "Tôi thương mà em đâu có hay";
            selected.Author = "Đoàn Thạch Biển";
            Prn212BookstoreContext ctx = new();
            ctx.Books.Update(selected);
            ctx.SaveChanges();

            //F5 lại cái Grid, đổ lại lưới để có dòng mới
            ctx = new();// quan trọng !!!! phải new lại context
            List<Book> bag = ctx.Books.Include("BookCategory").ToList();//convert từ DBset<> thành List<>
            StudentListDataGrid.ItemsSource = bag;//đổ dữ liệu vào datagrid
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Book? selected = StudentListDataGrid.SelectedItem as Book;
            if (selected == null)
            {
                MessageBox.Show("Chọn 1 cuốn sách để xóa");
                return;
            }

            
            Prn212BookstoreContext ctx = new();
            ctx.Books.Remove(selected);
            ctx.SaveChanges();

            //F5 lại cái Grid, đổ lại lưới để có dòng mới
            ctx = new();// quan trọng !!!! phải new lại context
            List<Book> bag = ctx.Books.Include("BookCategory").ToList();//convert từ DBset<> thành List<>
            StudentListDataGrid.ItemsSource = bag;//đổ dữ liệu vào datagrid
        }
    }
}