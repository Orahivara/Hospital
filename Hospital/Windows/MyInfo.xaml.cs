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
using Hospital.ClassHelper;
using Hospital.DB;

namespace Hospital.Windows
{
    /// <summary>
    /// Логика взаимодействия для MyInfo.xaml
    /// </summary>
    public partial class MyInfo : Window
    {
        public MyInfo()
        {
            InitializeComponent();
            data.ItemsSource = Help.Context.MyINfo(1);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainPatientPage mainPatientPage = new MainPatientPage();
            mainPatientPage.Show();
            this.Close();
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            ChangeInfo changeInfo = new ChangeInfo();
            changeInfo.Show();
            this.Close();
        }
    }
}
