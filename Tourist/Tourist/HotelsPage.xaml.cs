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

namespace Tourist
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<MyTable> result = new List<MyTable>(3);
            result.Add(new MyTable(1, "Воронеж", 3000, 1, true));
            result.Add(new MyTable(2, "Париж", 300000, 5, true));
            result.Add(new MyTable(3, "Лаишево", 100, 0, true));
            grid.ItemsSource = result;
        }

        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MyTable path = grid.SelectedItem as MyTable;
            MessageBox.Show(" ID: " + path.Id + "\n Наименование: " + path.Name + "\n Стоимость: " + path.Price + " руб." 
                + "\n Количество путевок: " + path.Count + "\n Статус активности: " +path.Status);
        }
    }
}
