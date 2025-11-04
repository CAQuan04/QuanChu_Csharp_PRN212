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
                this.Close();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //BẠN GÕ GÌ TRÊN MÀN HÌNH TỚ CẤT HẾT VÀO OBJECT AIRCON
            AirConditioner obj = new() { };


            obj.AirConditionerId = int.Parse(AirConditionerIdTextBox.Text);


            obj.Quantity = int.Parse(QuantityTextBox.Text);
            obj.DollarPrice = double.Parse(DollarPriceTextBox.Text);
            obj.Warranty = WarrantyTextBox.Text;
            obj.SoundPressureLevel = SoundPressureLevelTextBox.Text;
            obj.FeatureFunction = FeatureFunctionTextBox.Text;
            obj.AirConditionerName = AirConditionerNameTextBox.Text;

            //CÁI CUỐI KHÓA NGOẠI LẤY THỊT HEO
            obj.SupplierId = (string)SupplierComboBox.SelectedValue;

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
            //Lưu ý: biến EditedOne chính là biến flag, biến cờ đánh dấu trạng thái, mode của màn hình này
            //Nếu biến này == null, tạo mới, vì kh có selected đc gửi sang!!!
            //khác null là do đi từ nút bấm [Update], thì có gửi sang selected
            //Mình dùng biến này để biết khi nào create, khi nào update khi nhấn nút [Save]
            // chẳng quan tâm mode, phải đổ vào combo cả 2 mode
            //tạo mới cx chọn, edit cũng chọ NCC
            SupplierComboBox.ItemsSource = _supService.GetAllSupplier();
            //thằng này combo giống data grid là shơ nhiều dòng
            //nhưng grid show all cột, thằng combo chỉ show 1 cột
            SupplierComboBox.DisplayMemberPath = "SupplierName";//treo đầu dê
            SupplierComboBox.SelectedValuePath = "SupplierId";//Lấy thịt heo




            if (EditedOne != null)
            {   //EDIT MODE
                DetailWindowMode.Content = "Sửa thông tin đi em";
                // ĐỔ INFO TỪ OBJECT VÀO CÁC Ô NHẬP, HỌC RỒI
                AirConditionerIdTextBox.Text = EditedOne.AirConditionerId.ToString();
                //CHỮ VÀ SỐ PHẢI CONVERT MỚI GÁN VÀO ĐC 
                //KHÓA Ô ID LẠI
                AirConditionerIdTextBox.IsEnabled = false;//ko cho sửa key


                AirConditionerNameTextBox.Text = EditedOne.AirConditionerName; // Tên cũ
                QuantityTextBox.Text = EditedOne.Quantity.ToString();
                DollarPriceTextBox.Text = EditedOne.DollarPrice.ToString();
                WarrantyTextBox.Text = EditedOne.Warranty;
                SoundPressureLevelTextBox.Text = EditedOne.SoundPressureLevel;
                FeatureFunctionTextBox.Text = EditedOne.FeatureFunction;

                //CÒN CÁI FK, KO SHOW FK VÀO Ô TEXT, MÀ SHOW QUA TREO ĐẦU DÊ BÁN THỊT HEO
                //VÌ CATEGORY, HAY NHÀ SẢN XUẤT, NHÀ CUNG CẤP LÀ 1 BẢNG KHÁC
                //id | name | quantity | price | .... | mã hãng sản xuất FK
                //                                              H1
                //                                              H2
                //MÌNH CHỌN SHOW CÁI COMBOX, CHỨA CHỮ SAMSUNG, TOSHIBA, DAIKIN
                //NHƯNG KHI CHỌN SAMSUNG, THÌ LẤU H1 CẤT VÀO FK


                //nhày đến đúng Cate, đúng hãng sx mà sản phẩm thuộc về SupplierComboBox.SelectedValue
                SupplierComboBox.SelectedValue = EditedOne.SupplierId;


                //CÒN CÁI FK, KO SHOW FK VÀO Ô TEXT, MÀ SHOW QUA TREO ĐÀU DÊ BÁN THỊT HEO
                //VÌ CATEGORY, HAY NHÀ SẢN XUẤTM NHÀ, NHÀ CUNG CẤP ;LÀ 1 BẢNG KHÁC 
                //id mã hãng sc |   name tên hãng sx    |   country quốc gia    |
                //  H1                  SAMSUNG                 HÀN QUỐC
                //  H2                  TOSHIBA                 NHẬT BẢN
                //  H3                  DAIKIN                  NHẬT BẢN

            }
            else
            {   //create mode
                DetailWindowMode.Content = "Tạo mới đi em";
                
            }


        }

        private void SupplierComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        //[SAVE] DO MÀN HÌNH NÀY XÀI CHUNG CHO TẠO MỚI VÀ UPDATE
    }
}
