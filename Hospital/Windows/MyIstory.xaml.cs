using Hospital.ClassHelper;
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

namespace Hospital.Windows
{
    /// <summary>
    /// Логика взаимодействия для MyIstory.xaml
    /// </summary>
    public partial class MyIstory : Window
    {
        public MyIstory()
        {
            InitializeComponent();
            grid.ItemsSource = Help.Context.MyHistory(1);
        }
        private void bPicture_MouseDown(object sender, MouseEventArgs e)
        {

            this.Close();
        }
        private void Назад_Click(object sender, RoutedEventArgs e)
        {
            MainPatientPage mainPatientPage = new MainPatientPage();
            mainPatientPage.Show();
            this.Close();
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
