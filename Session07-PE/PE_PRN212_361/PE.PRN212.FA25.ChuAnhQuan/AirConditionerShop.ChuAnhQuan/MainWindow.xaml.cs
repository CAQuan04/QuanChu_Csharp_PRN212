using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entites;
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

namespace AirConditionerShop.ChuAnhQuan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //                  BLL         DALL
        //GUI/CONTROLLER -- SERVICE -- REPO -- DBCONTEXT -- TABLE
        //                          !!!

        //@Autowire loose Coupling
        //private AirConService _airService
        private AirConditionerService _airService = new();//new luôn không sợ
        //KÌ 7, MÌNH KO THÊM NEW SERVICE, CHỈ KHAI BÁO VÀ XÀI
        //              KHAI BÁO MÀ KO THÊM NEW MÀ VẪN XÀI ĐC,
        //              CHẮC CHẮN PHẢI CÓ CHỖ NÀO ĐÓ, KHI NÀO ĐÓ NEW CHO MÌNH, ĐƯA NEW CHO MÌNH
        //MĨ THUẬT NEW, ĐƯA CHO MÌNH, GỌI LÀ DEPENDENCY INJECTION (DI) Quantrong
        //TIÊM/CHÍCH/INJECT CÁI NEW VÀO CHO MÌNH, GỌI LÀ DI

        //OOP: KHAI BÁO BIẾN VÀ NEW THÌ MỚI ĐC XÀI
        //TỨC LÀ CHẤM ĐỂ GỌI TÊN HÀM


        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //1. CHECK XEM ĐÃ CLICK ĐÚNG DÒNG CHƯA
            //2. CHỌN 1 DÒNG RỒI THÌ GỬI NÓ SANG MÀN HÌNH DETAIL
            //3. CHỈNH SỬA DATA BÊN MÀN HÌNH DETAIL, ĐÓNG LẠI
            //4. F5 GRID
            //
            

            AirConditioner? selected = AirConDataGrid.SelectedItem as AirConditioner;

            if (selected == null)
            {
                MessageBox.Show("Please select a row before update", "select one", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }

            DetailWindow detail = new();
            //GỬI SELECTED SANG THÌ PHẢI NẰM Ở ĐÂY
            //?????
            detail.EditedOne = selected;// = _editedOne của Detail
            //3 chàng trỏ 1 nàng: EditedOne, selected, grid có 1 con trỏ - > trỏ vùng new AirCon đang cần edit!!!
            detail.ShowDialog();

            //F5 lại cái lưới grid
            FillDataGrid(_airService.GetALLAirCons());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //1.CHECK XEM ĐÃ CLICK ĐÚNG DÒNG CHƯA
            //2.ĐÚNG RỒI THÌ ARE YOU SURE
            //3.NHỜ SERVICE XÓA, SERVICE ĐI NHỜ REPO, REPO ĐI NHỜ DBCONTEXT
            //5.F5 GRID QUA HÀM

            AirConditioner? selected = AirConDataGrid.SelectedItem as AirConditioner;

            if (selected == null)
            {
                MessageBox.Show("Please select a row before deleting", "select one", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }

            MessageBoxResult answer = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.No)
            {
                return;
            }

            //                  BLL         DALL
            //GUI/CONTROLLER -- SERVICE -- REPO -- DBCONTEXT -- TABLE
            //                          !!!!
            //xóa thật 
            //MessageBox.Show($"Xóa thật nè: {selected.AirConditionerId}{selected.AirConditionerName}{selected.FeatureFunction}");

            _airService.DeleteAirCon(selected);

            //F5 - REFRESH CÁI GRID ĐỂ THẤY DÒNG XÓA ĐÃ MẤT
            // VIỆC REFRESH CÁI GRID NÀY XUẤT HIỆN Ở;
            //NÚI CREATE (THÊM MỚI THÌ PHẢI CHO THẤY ĐÃ THÊM)
            //NÚI DELETE (MẤT DÒNG TRÊN GRID LUÔN)
            //NÚI SEARCH (LƯỚI PHẢI HIỆN THỊ 1 -N DÒNG SEARCH THẤY)
            //LOADED_ (MÀN HÌNH MỞ LÊN, LƯỚI PHẢI ĐC ĐỖ SẴN DATA)
            //TÁCH 1 HÀM CHỈ LO VIỆC ĐỔ INFO VÀO GRID ->HÀM HELEPR - HÀM TRỢ GIÚP TRONG SÁNG VÀ Ý NGHĨA

            
            FillDataGrid(_airService.GetALLAirCons());



        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Are you sure", "Confirm ?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                //tat app
                Application.Current.Shutdown();
                //ứng dụng.Hiện hành. Tắt app
            }
        }

        private void AirConditionerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //                  BLL         DALL
        //GUI/CONTROLLER -- SERVICE -- REPO -- DBCONTEXT -- TABLE
        //                          !!!
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ĐỔ VÀO LƯỚI LUÔN, NHƯNG PHẢI NHỜ TRƯỚC AIRCONSERVICE GIÚP TUI List<AirCon>, Service lại đi nhờ Repo, Repo lại nhớ DBContext

            AirConDataGrid.ItemsSource = _airService.GetALLAirCons();
        }

        private void FillDataGrid(List<AirConditioner> data)
        {
            AirConDataGrid.ItemsSource = null;//xóa data đang có nêu có
            AirConDataGrid.ItemsSource = data;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detail = new();
            detail.ShowDialog();
            //f5 lại cái grid
            FillDataGrid(_airService.GetALLAirCons());
        }
    }
}