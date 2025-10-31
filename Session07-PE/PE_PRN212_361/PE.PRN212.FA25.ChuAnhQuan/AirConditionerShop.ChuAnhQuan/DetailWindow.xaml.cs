using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entites;
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

namespace AirConditionerShop.ChuAnhQuan
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {

        //private AirConditioner _editedOne; // - selected nêm Main gắn vào qua hàm Set() -> thay bằng property

        //prop tab tab
        public AirConditioner EditedOne { get; set; }

        //cần 2 service bên detail;
        //SupplierService dành chotreo đầu dê
        //AirConService dành cho nút [save] -> create, update, AirCon

        private AirConditionerService _airService = new();
        private SupplierCompanyService _supService = new();
        public DetailWindow()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Are you sure ?", "quit", MessageBoxButton.YesNo);
            if (answer == MessageBoxResult.Yes)
            {
                //tắt app
                Application.Current.Shutdown();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //BẠN GÕ GÌ TRÊN MÀN HÌNH TỚ CẤT HẾT VÀO OBJECT AIRCON
            AirConditioner obj = new() { };
            obj.AirConditionerId = int.Parse(AirConditionerIdTextBox.Text);
            obj.AirConditionerName = string.Air;
            obj.Quantity= string.QuantityTextBox.Text;
            obj.DollarPrice = int.Parse(DollarPriceTextBox.Text);
            obj.Warranty = int.Parse(WarrantyTextBox.Text);
            obj.SoundPressureLevel = string.SoundPressureLevelTextBox.Text;
            obj.FeatureFunction = string.FeatureFunctionTextBox.Text;

            //CÁI CUỐI KHÓA NGOẠI LẤY THỊT HEO
            obj.SupplierId = (string)SupplierComboBox.SelectedItem;

            if (EditedOne == null)
            {
                _airService.CreateAirCon(obj);   
            }
            else
            {
                _airService.UpdateAirCon(obj);
            } 
            this.Close();
                
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            // chẳng quan tâm mode, phải đổ vào combo cả 2 mode
            //tạo mới cx chọn, edit cũng chọ NCC
            SupplierComboBox.ItemsSource = _supService.GetAllSupplie();
            //thằng này combo giống data grid là shơ nhiều dòng
            //nhưng grid show all cột, thằng combo chỉ show 1 cột
            SupplierComboBox.DisplayMemberPath = "SupplierName";//treo đầu dê
            SupplierComboBox.SelectedValuePath = "SupplierId";//Lấy thịt heo




            if (EditedOne != null)
            {
                DetailWindowMode.Content = "Sửa thông tin đi em";
                AirConditionerIdTextBox.Text = EditedOne.AirConditionerId.ToString();


                AirConditionerNameTextBox.Text = EditedOne.AirConditionerName.ToString();
                QuantityTextBox.Text = EditedOne.Quantity.ToString();
                DollarPriceTextBox.Text = EditedOne.DollarPrice.ToString();
                WarrantyTextBox.Text = EditedOne.Warranty.ToString();
                SoundPressureLevelTextBox.Text = EditedOne.SoundPressureLevel.ToString();
                FeatureFunctionTextBox.Text = EditedOne.FeatureFunction.ToString();

                //nhày đến đúng Cate, đúng hãng sx mà sản phẩm thuộc về SupplierComboBox.SelectedValue

                SupplierComboBox.SelectedValuePath = EditedOne.SupplierId;
            }
            else
            {
                DetailWindowMode.Content = "Tạo mới đi em";
            }


        }

        //[SAVE] DO MÀN HÌNH NÀY XÀI CHUNG CHO TẠO MỚI VÀ UPDATE
    }
}
