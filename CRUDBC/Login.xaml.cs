using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Outlook = Microsoft.Office.Interop.Outlook;
using CRUDBC.NewFolder1;

namespace CRUDBC
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        MyContext myContext = new MyContext();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var email = myContext.Users.Where(u => u.Email == TxtUserEmail.Text).FirstOrDefault();

                if ((TxtUserEmail.Text == "") || (TxtPassword.Password == ""))
                {
                    if (TxtUserEmail.Text == "")
                    {
                        MessageBox.Show("Email is Required!", "Caution", MessageBoxButton.OK);
                        TxtUserEmail.Focus();
                    }
                    else if (TxtPassword.Password == "")
                    {
                        MessageBox.Show("Password is Required!", "Caution", MessageBoxButton.OK);
                        TxtPassword.Focus();
                    }
                }
                else
                {
                    if (email != null)
                    {
                        var psw = email.Password;
                        psw = TxtPassword.Password;
                        if (TxtPassword.Password == psw)
                        {
                            MessageBox.Show("Login Successfully!", "Login Succes", MessageBoxButton.OK);
                            MainWindow dashboard = new MainWindow();
                            dashboard.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email and Password are wrong!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email and Password is invalid");
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnForgot_Click(object sender, RoutedEventArgs e)
        {
            gLogin.Visibility = Visibility.Hidden;
            gForgotPassword.Visibility = Visibility.Visible;

        }

        private void TxtUserEmail_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z0-9.@]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtUserEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPassword_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z0-9.@]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBlock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            gLogin.Visibility = Visibility.Visible;
            gForgotPassword.Visibility = Visibility.Hidden;
        }

        private void BtnSubmitForgetPwd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtUserEmail.Text == "")
                {
                    MessageBox.Show("Email is Required", "Caution", MessageBoxButton.OK);
                    TxtUserEmail.Focus();
                }
                else
                {
                    var cekemail = myContext.Users.FirstOrDefault(v => v.Email == TxtUserEmail.Text);
                    if (cekemail != null)
                    {
                        var email = cekemail.Email;
                        if (TxtUserEmail.Text == email)
                        {
                            string newpsw = Guid.NewGuid().ToString();
                            var emailcek = myContext.Users.Where(s => s.Email == TxtUserEmail.Text).FirstOrDefault();
                            emailcek.Password = newpsw;
                            myContext.SaveChanges();
                            MessageBox.Show("Password has been update!");
                            Outlook._Application _app = new Outlook.Application();
                            Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                            mail.To = TxtUserEmail.Text;
                            mail.Subject = "[Forgot Password]" + DateTime.Now;
                            mail.Body = "Dear.." + TxtUserEmail.Text + "\nThis is ur new password :" + newpsw + "\nDont Forget Your Password Again!";
                            mail.Importance = Outlook.OlImportance.olImportanceNormal;
                            ((Outlook._MailItem)mail).Send();
                            MessageBox.Show("Check Your Email For Your New Password", "Message", MessageBoxButton.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("That Email Not Registered Yet!", "Caution", MessageBoxButton.OK);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
