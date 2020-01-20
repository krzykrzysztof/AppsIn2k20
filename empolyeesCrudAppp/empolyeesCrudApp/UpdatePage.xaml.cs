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
using empolyeesCrudApp.Model;

namespace empolyeesCrudApp
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        employeesCrudAppContext _db = new employeesCrudAppContext();
        int id;
        public UpdatePage(int workerId)
        {
            InitializeComponent();
           id = workerId;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Worker updateMember = (from m in _db.Workers
                                       where m.Id == id
                                       select m).Single();
                updateMember.Age = Convert.ToInt16(ageBox.Text);
                updateMember.Name = nameTextBox.Text;
                _db.SaveChanges();
                MainWindow.datagrid.ItemsSource = _db.Workers.ToList();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       



        }
    }
}
