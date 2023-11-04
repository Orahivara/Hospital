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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hospital.DB;
using Hospital.ClassHelper;
using Hospital.Windows;

namespace Hospital
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Windows.Registration reg = new Windows.Registration();
            reg.Show();
            this.Close();
        }

        private void In_Click(object sender, RoutedEventArgs e)
        {
            var correct = Help.Context.PatientShitikovas.FirstOrDefault(u => u.Login == login.Text && u.Password == password.Password);
            if (correct != null)
            {
               
                MainPatientPage main = new MainPatientPage();
                main.Show();
                this.Close();
            }
            else {

                MessageBox.Show("Несходится логин или пароль");
            }
        }
    }
}
