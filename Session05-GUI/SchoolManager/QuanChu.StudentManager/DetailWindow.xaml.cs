using QuanChu.StudentManager.DAL.Entities;
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
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        //Cửa sổ detail, class detail cần 1 biến student _ediedOne để đc set = selected từ mainwindow truyền sang
        //Nếu bạn dừng backing field thì phải viết code get set cho nó để gắn value vào baking field xài luôn property cho lành cũng đặt mục tiêu vào code đẹp

        public Student EditedOne { get; set; }// _editedOne=
        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GpaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void YobTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            //đổ data vào combo box major - lẽ ra phải lấy từ db
            List<Major> majors = new();
            majors.Add(new Major() { Id = "SE", Name = "Kỹ thuật phần mềm", Description = "CNTT" });
            majors.Add(new Major() { Id = "GD", Name = "Thiết kế mỹ thuật số", Description = "CNTT" });
            majors.Add(new Major() { Id = "IB", Name = "Kinh doanh quốc tế", Description = "CNTT" });

            //Đưa vào combobox, y chang đưa vào datagrid; 3 thg này nó thầu danh sách dữ liệu
            MajorComboBox.ItemsSource = majors;
            //Vì combo box đc design để hiển thị 1 object, nên ta phải nói cho nó biết hiển thị thuộc tính nào
            MajorComboBox.DisplayMemberPath = "Name";//Show cột cho user select, treo đầu dê
            MajorComboBox.SelectedValuePath = "Id";//giá trị thật sự đằng sau, lấy cột id cho student table!!!! Cực kì quan trọng!!!!



            //Nếu biến editedOne khác null, thì gắn từng thuộc tính của nó vào từng textbox tương ứng 
            //edit one là flag variable
            if (EditedOne != null)
            {
                IdTextBox.Text = EditedOne.Id.ToString();
                NameTextBox.Text = EditedOne.Name;
                YobTextBox.Text = EditedOne.Yob.ToString();
                GpaTextBox.Text = EditedOne.Gpa.ToString();
                TitleLabel.Content = "Chỉnh sửa nha!!!";
                IdTextBox.IsEnabled = false;//không cho sửa ID vì ID là khóa chính ko đc trùng


                //NHẢY ĐÚNG ĐẾN CHUYÊN NGÀNH ĐANG CÓ
                MajorComboBox.SelectedValue = "IB";//Fk đang có
                                                   //Thay vì set thì là get, tự nhảy lên EditedOne.MajorId đang có!!!

            }

            else
            {
                // khong lam gi ca, de nguyen cac textbox rong
                TitleLabel.Content = "tao moi nguyen";
            }
        }

        private void CloseButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Close();
            //hàm của cha window
            //đóng cửa sổ, khác với .Hide() là chỉ ấn đi và show trở lại _Hide() cùng new vần còn trong râm
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Đề thi yếu cầu phải bật validation
            //Để check xem name có rỗng ko, min max
            //Số thì phải trong 1 đoạn nào đó
            //Chiếm khoảng 1-1.5 điểm
            //
            //Khi ấn nút save, check xem user chọn chuyên ngành nào ?
            string majorId = (String)MajorComboBox.SelectedValue;
            //ép kiểu trong ô chọn thành chuỗi, vì khi vào thg combo, mọi thứ là object, class ông tổ
            MessageBox.Show("Bạn chọn chuyen ngành: " + majorId);

            String id, name;
            id = IdTextBox.Text;
            name = NameTextBox.Text;
            int yob = int.Parse(YobTextBox.Text);
            double gpa = double.Parse(GpaTextBox.Text);
            if (CheckVar() == true)
            {
                //todo gởi lệnh save xuống table
                MessageBox.Show($"The student info: {id}||{name}||{yob}||{gpa} is saved successfully", "Confirm", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private Boolean CheckVar()
        {

            //todo yêu cầu nhập số mà gõ chữ, chửi làm sao???
            //    sso nhaoạ ngoài đoạn v...v nào đó, chửi??
            //    chuỗi rỗng, hoặc dài quá, ngắn quá
            //    ko thêm chọn chuyên ngành, chửi
            if (String.IsNullOrEmpty(IdTextBox.Text))
            {   
                MessageBox.Show("Id không được để trống","Invalid input", MessageBoxButton.OK,MessageBoxImage.Stop);
                return false;
            }

            if (String.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Name không được để trống", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }

            if (int.IsEvenInteger(int.Parse(YobTextBox.Text)))
            {
                MessageBox.Show("Yob không được để trống", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }

            if (double.IsEvenInteger(double.Parse(GpaTextBox.Text)))
            {
                MessageBox.Show("Gpa không được để trống", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }
            return true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
