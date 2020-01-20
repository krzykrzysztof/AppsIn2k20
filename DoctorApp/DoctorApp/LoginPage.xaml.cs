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
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace DoctorApp
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private void SingInBnt_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=LAPTOP-7886A0OP\SQLEXPRESS; initial Catalog=LoginDb; Integrated Security=True;");
            try
            {
                
                string Query  = "SELECT COUNT(1) FROM tbUser WHERE Username=@Username AND Password=@Password";
                sql.Open();
                SqlCommand com = new SqlCommand(Query, sql);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@Password", PasswordBox.Password);
                com.Parameters.AddWithValue("@Username", Loginbox.Text);
                int Count = Convert.ToInt16(com.ExecuteScalar());
                if (Count == 1)
                {
                    MainWindow mainPage = new MainWindow();
                    mainPage.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Login or password is incorrect.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
