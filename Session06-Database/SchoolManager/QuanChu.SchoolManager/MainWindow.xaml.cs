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
    }
}