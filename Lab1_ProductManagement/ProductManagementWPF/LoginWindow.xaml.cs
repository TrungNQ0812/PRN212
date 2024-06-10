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
using BusinessObjects;
using Services;

namespace ProductManagementWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IAccountService iAccountService;
        public LoginWindow()
        {
            InitializeComponent();
            iAccountService = new AccountService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AccountMember account = iAccountService.GetAccountById(txtUser.Text);

                if (account == null)
                {
                    MessageBox.Show("Invalid username!");
                    return;
                }

                if (account.MemberPassword == null)
                {
                    MessageBox.Show("Password is not set for this account!");
                    return;
                }

                if (account.MemberPassword.Equals(txtPass.Password) && account.MemberRole == 1)
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Invalid password or you do not have permission!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
