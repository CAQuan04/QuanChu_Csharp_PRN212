using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanChu.StudentManager
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new();//new ngắn, cắt bên phải
            //Thông báo thử xem user gõ email gì, pass gì text bỏ email 
            String email = EmailTextBox.Text;//lấy được email user gõ cất vào
            String password = PasswordTextBox.Text;//lấy đc pass user gõ cất vào
            MessageBox.Show($"Bạn vừa nhập: {email}||{password}");
            //giấu Login rồi mới show Main
            this.Hide();//hàm kế thừa từ Cha window
            //chính tui Login ẩn đi, mời thằng main lên
            //main.ShowDialog();// modal, cấm quay về màn hình login nếu ko tắt Main
            main.ShowDialog();           
            //Todo rảnh làm thử show 10 màn hình ở các tọa độ khác nhau giả lập nhiều virus
            //for (int i = 0; i < 10; i++)
            //{
            //    MainWindow main = new();//new ngắn, cắt bên phải
            //    main.Show();
            //}
            ////MainWindow mainWindow = new MainWindow();
            //MainWindow main = new();//new ngắn, cắt bên phải
            //main.Show();

        }

       private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Are you sure?", "quit", MessageBoxButton.YesNo);
            if (answer == MessageBoxResult.Yes)
            {
                //tắt app thôi
                Application.Current.Shutdown();
            }
        } 

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
