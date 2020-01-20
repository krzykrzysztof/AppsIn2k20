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
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        employeesCrudAppContext _db = new employeesCrudAppContext();
        public InsertPage()
        {
            InitializeComponent();
        }
        
        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Worker worker = new Worker()
                {
                    Name = nameTextBox.Text,
                    Age = Convert.ToInt16(ageBox.Text),
                };
                _db.Workers.Add(worker);
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
