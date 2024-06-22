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
using NguyenQuangTrungWPF;
using FUHotelManageLibrary.Model;
using FUHotelManageLibrary.Services;


namespace NguyenQuangTrungWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LoginService _loginService;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            
            if (email == "admin@FUMiniHotelSystem.com" && password == "@@abc123@@")
            {
                Admin AdminWindow = new Admin();
                AdminWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai email hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            if (email == "WilliamShakespeare@FUMiniHotel.org" && password == "123@")
            {
                /* Customer cus = _loginService.GetCustomerByEmailAndPassword(email,password);*/
                CustomerWindow customerWindow = new CustomerWindow();
                customerWindow.Show();
                this.Close();
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
