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
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Window
    {
        DoctorAppDbContext context = new DoctorAppDbContext();
        public static DataGrid datagrid;
        public MemberPage()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            MyDataGridMember.ItemsSource = context.Members.ToList();
            datagrid = MyDataGridMember;
        }
        private void InsertBnt_Click(object sender, RoutedEventArgs e)
        {
            IPage ip = new IPage();
            ip.Show();
        }

        private void UpdateBnt_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32((MyDataGridMember.SelectedItem as Member).Id);
            UPage up = new UPage(Id);
            up.Show();

        }

        private void DeleteBnt_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16((MyDataGridMember.SelectedItem as Member).Id);
            var deletedMeber = context.Members.Where(m => m.Id == Id).Single();
            context.Members.Remove(deletedMeber);
            context.SaveChanges();
            MyDataGridMember.ItemsSource = context.Members.ToList();
        }
    }
}
