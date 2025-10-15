using QuanChu.StudentManager.DAL.Entities;
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
            MessageBoxResult answer = MessageBox.Show("Are you sure", "Confirm ?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                //tắt app
                Application.Current.Shutdown();
                //câu lệnh xóa data nằm ở đây, vì là yes

            }

            //nhớ đoạn code này để làm tính năng xóa Delete
            //thang điểm chấm cho tính năng delete là khi delete phải hỏi có chắc xóa ko, bị trừ 0.5 điểm.
        }

        private void LoadData_Click(System.Object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void StudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void LoadData_Loaded(object sender, RoutedEventArgs e)
        {
            //Bước 1 chuẩn bị 1 cái list student bằng 1 cái túi từ db lên, tạm thời hard code, cho ta sẵn vào
            List<Student> bag = new();
            bag.Add(new Student() { Id = 1, Name = "an nguyen", Yob = 2005, Gpa = 3.5 });
            bag.Add(new Student() { Id = 2, Name = "binh nguyen", Yob = 2004, Gpa = 3.6 });
            bag.Add(new Student() { Id = 3, Name = "cuong nguyen", Yob = 2003, Gpa = 3.7 });
            bag.Add(new Student() { Id = 4, Name = "dung nguyen", Yob = 2002, Gpa = 3.8 });
            bag.Add(new Student() { Id = 5, Name = "em nguyen", Yob = 2001, Gpa = 3.9 });
            StudentList.ItemsSource = bag;
            //grid ơi tao gửi mã cái túi
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //1. kiểm tra xem user đã chọn 1 dòng trên grid chưa. Nếu chưa chọn, chửi, muốn xóa thì phải chọn đúng
            //2. Hỏi câu are you sure ? nếu đã chọn dòng để xóa hoặc update
            //3. nếu yes thì xóa trong DB và F5 lại cái grid để thấy dòng này đã xóa đã biến mất, NO thì thôi
            //Cái StudentListDataGrid nó sẽ lắng nghe xem user có chọn dòng nào không và mỗi dòng nếu chọn thì là 1 student x vì mình đưa 1 cái bag student vào grid mà
            //Mình chỉ việc hỏi nó có dòng chọn hay không, qua cái PROPERTY!!!!

            Student? selected = StudentList.SelectedItem as Student;//as: ép kiểu 1 dòng về student, hoặc ép ko đc thì là null, nghĩa là chưa chọn dòng củ thể !!!!
            if (selected == null)
            {
                //nhấn Delete mà chưa chọn dòng, chửi chết mẹ nó
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;// thoát khỏi hàm nút xóa
            }
            //todo: viết code phần xóa that trong db
            //ghi thông báo xóa thành công, giả thôi sau này làm thật
            MessageBox.Show($"Delet Successfully student: {selected.Id},{selected.Name}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detail = new();
            detail.ShowDialog();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}