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

namespace QuanChu.StudentManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Mõi cửa sổ / màn hình / WINDOW trong app GUI WPS ĐÊU DỰA TRÊN CỬA SỔ MẪU ĐC CUNG CẤP BỞI HỆ ĐIỀU HÀNH WINDOWS
    /// HỆ ĐIÊU HÀNH WINDOWS CUNG CẤP 1 CLASS TRONG WINDOW, CHO CHÚNG TA 1 CỬA SỔ MẪU MÀ MÕI APP GUI ĐỀU PHẢI CẦN NÊN KẾ THỪA
    /// KẾ THỪA TRONG JAVA: TỪ KHÓA EXTENDS
    /// KẾ THỪA TRONG C#: TỪ KHÓA :
    ///                CLASS    DOG     EXTENDS  ANIMAL
    ///                CLASS    DOG     :        ANIMAL
    /// CLASS WINDOW NÀY CÓ 2 HÀM ĐẶC BIỆT: .Show() VÀ .ShowDialog()
    /// gọi 2 hàm này, HDH WINDOW NÓ VIỆN TRỞ NGAY CARD ĐỒ HỌA, ĐỂ RENDER RA 1 CỬA SỔ TRÊN DESKTOP
    /// MỖI CỬA SỔ XUÁT HIỆN TRONG APP, TRÊN DESKTOP BẢN CHÂT LÀ 1 OBJECT CỦA CLASS MÀ KẾ THỪA CLASS WINDOW
    /// CỬA SỔ ĐANG ĐỨNG LÀ MAINWINDOW ĐỨNG PHÍA SAU NÓ LÀ CLASS CÙNG TÊN 
    /// KHI RUN, CLASS NÀY ĐƯỢC NEW, VÀ .SHOW()
    /// MỘT CỬA SỎ - 1 WINDOW - LÀ 1 CLASS KẾ THỪA CỬA SỔ GỐC TÊN LÀ WINDOW
    /// NÓ SẼ CÓ NHIỀU MÓN ĐỒ BÀY LÊN TRÊN: NÚT BẤM, NHÃN, Ô NHẬP, CHECKBOX, RADIO BUTTON, COMBOBOX, LISTBOX, DROPDOWN, LƯỚI-TABLE-GRID, MENU, ...-> MỖI MÓN ĐỒ NÀY LÀ 1 PROPERTY CỦA CLASS WINDOW
    /// 
    // ĐẶC ĐIỂM HAY LÀ PROP CỦA STUDENT LÀ : ID, GPA, YOB, ADRESS...
    // ĐẶC ĐIỂM HAY LÀ PROP CỦA CỦA SỔ X LÀ: Button1, Button2, TextBox1, Label1...
    // để design đc cửa sổ x, ta phải khai báo các PROP là nút bấm, nhãn, ô nhập, checkbox... 
    // VS CUNG CẤP SẴN 1 UI GIÚP TA DEIGN UI, BẰNG CÁCH KÉO THẢ, 
    // WYSING: NHƯNG ĐẰNG SAU ĐỀU LÀ CODE!!!!
    // VÀ MỖI NÚT BẤM, Ô NHẬP, HỘP KIỂM CHECKBOX,.... ĐỀU LÀ 1 OBJECT CỦA 1 CLASS
    // STUDENT CHỨA STRING ADDRESS, NAME,...
    // CLASS NÀY WINDOWX CHỨA Button, TextBox, Label... ĐỀU LÀ OBJECT CỦA 1 CLASS TƯƠNG ỨNG

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Are you sure","Confirm ?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                //tắt app
                Application.Current.Shutdown();
                //câu lệnh xóa data nằm ở đây, vì là yes

            }

            //nhớ đoạn code này để làm tính năng xóa Delete
            //thang điểm chấm cho tính năng delete là khi delete phải hỏi có chắc xóa ko, bị trừ 0.5 điểm.

        }
    }
}