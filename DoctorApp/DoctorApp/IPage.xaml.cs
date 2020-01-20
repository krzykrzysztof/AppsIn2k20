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

namespace DoctorApp
{
    /// <summary>
    /// Interaction logic for IPage.xaml
    /// </summary>
    public partial class IPage : Window
    {
        DoctorAppDbContext context = new DoctorAppDbContext();
        public IPage()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member member = new Member()
                {
                    Name = nameTextBox.Text,
                    Age = Convert.ToInt16(ageBox.Text),
                };
                context.Members.Add(member);
                context.SaveChanges();
                MemberPage.datagrid.ItemsSource = context.Members.ToList();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
