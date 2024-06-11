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
using NguyenQuangTrungWPF.View;
using NguyenQuangTrungWPF.View.Dialog;


namespace NguyenQuangTrungWPF
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
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            // Kiểm tra thông tin đăng nhập
            if (email == "admin@FUMiniHotelSystem.com" && password == "@@abc123@@")
            {
                // Mở cửa sổ chính cho Admin
                Admin AdminWindow = new Admin();
                AdminWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai email hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
