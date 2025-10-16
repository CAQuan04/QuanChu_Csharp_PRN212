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
            return true;
        }

    }
}
