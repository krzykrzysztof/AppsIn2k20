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

    public partial class UPage : Window
    {
        DoctorAppDbContext context = new DoctorAppDbContext();
        int id;
        public UPage(int memberId)
        {
            InitializeComponent();
            id = memberId;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Member updateMember = (from m in context.Members
                                       where m.Id == id
                                       select m).Single();
                updateMember.Age = Convert.ToInt16(ageBox.Text);
                updateMember.Name = nameTextBox.Text;
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
