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
    /// Логика взаимодействия для WillWriteService.xaml
    /// </summary>
    public partial class WillWriteService : Window
    {
        public WillWriteService()
        {
            InitializeComponent();
            grid.ItemsSource = Help.Context.WILLWrite(1);
            if (Help.Context.WILLWrite(1) == null)
            {

                MessageBox.Show("Предстоящей записи нет");
            }
            
        }
        private void bPicture_MouseDown(object sender, MouseEventArgs e)
        {

            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainPatientPage mainPatient = new MainPatientPage();
            mainPatient.Show();
            this.Close();
        }
    }
}
