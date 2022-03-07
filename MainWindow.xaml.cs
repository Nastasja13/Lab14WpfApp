using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF14
{   
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                PrName = "Яблоки",
                PrPrice = 89,
                PrImage = "Data/Яблоко.jpg",
                PrCategory = PrCategorys.Food
            });
            products.Add(new Product()
            { 
                PrName = "Мандарины",
                PrPrice = 140,
                PrImage = "Data/Мандарины.jpg",
                PrCategory = PrCategorys.Food
            });
            products.Add(new Product()
            {
                PrName = "Виноград",
                PrPrice = 229,
                PrImage = "Data/Виноград.jpg",
                PrCategory = PrCategorys.Food
            });
            products.Add(new Product()
            {
                PrName = "Фен",
                PrPrice = 2538,
                PrImage = "Data/Фен.jpg",
                PrCategory = PrCategorys.Appliances
            });
            products.Add(new Product()
            {
                PrName = "Мультиварка",
                PrPrice = 10900,
                PrImage = "Data/Мультиварка.jpg",
                PrCategory = PrCategorys.Appliances
            });
            products.Add(new Product()
            {
                PrName = "Увлажнитель воздуха",
                PrPrice = 24998,
                PrImage = "Data/Воздухоувлажнитель.jpg",
                PrCategory = PrCategorys.Appliances
            });
            listBox.ItemsSource = products; 
        }
    }
}
