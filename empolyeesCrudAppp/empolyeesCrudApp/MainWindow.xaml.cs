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
using System.Windows.Navigation;
using System.Windows.Shapes;
using empolyeesCrudApp.Model;

namespace empolyeesCrudApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        employeesCrudAppContext _db = new employeesCrudAppContext();
        public static DataGrid datagrid;
        public MainWindow()
        {
            InitializeComponent();
            Load();

        }
        public static void AddWorker()
        {
            var workers = new List<Worker>
            {
                new Worker{Id = 1, Age = 10, Name = "ssss"},
                new Worker{Id = 4, Age = 10, Name = "qwe"},
                new Worker{Id = 5, Age = 10, Name = "Krzyszqwetof"},
                new Worker{Id = 6, Age = 10, Name = "qwe"},
                new Worker{Id = 2, Age = 15, Name = "Tom"},
                new Worker{Id = 3, Age = 12, Name = "Andrzej"},
            };
            using(var context = new employeesCrudAppContext())
            {
                context.Workers.AddRange(workers);
                context.SaveChanges();
            }
            
        }

        private void Load()
        {

            MyDataGrid.ItemsSource = _db.Workers.ToList();
            datagrid = MyDataGrid;
        }

        private void InsertBnt_Click(object sender, RoutedEventArgs e)
        {
            InsertPage IPage = new InsertPage();
            IPage.ShowDialog();
        }

        private void UpdateBnt_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16((MyDataGrid.SelectedItem as Worker).Id);
            UpdatePage Upage = new UpdatePage(Id);
            Upage.ShowDialog();


        }

        private void DeleteBnt_Click(object sender, RoutedEventArgs e)
        {

            int Id = Convert.ToInt16((MyDataGrid.SelectedItem as Worker).Id);
            var deletedMeber = _db.Workers.Where(m => m.Id == Id).Single();
            _db.Workers.Remove(deletedMeber);
            _db.SaveChanges();
            MyDataGrid.ItemsSource = _db.Workers.ToList();
        }
    }
}
