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

namespace animalsCatalogApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        animalsCatalogAppContext context = new animalsCatalogAppContext();
        public DataGrid datagrid;
        public MainWindow()
        {
            
            InitializeComponent();
            Load();
        }

        
        private void addAnimal()
        {
            var Animals = new List<Animal>
            {
                new Animal { Country = "Poland", Id=4,MaxAge= 10,MaxHeight=150,MaxWeight=50,Name= "Tiger" },
                new Animal { Country = "Poland", Id=5,MaxAge= 10,MaxHeight=150,MaxWeight=50,Name= "Tiger"},
                new Animal { Country = "Poland", Id=6,MaxAge= 10,MaxHeight=150,MaxWeight=50,Name= "Tiger"}
            };
            using (var context = new animalsCatalogAppContext())
            {
                context.Animals.AddRange(Animals);
                context.SaveChanges();
            }
        }
        private void Load()
        {
            MyDataGrid.ItemsSource = context.Animals.ToList();
            datagrid = MyDataGrid;
        }


    }
}
