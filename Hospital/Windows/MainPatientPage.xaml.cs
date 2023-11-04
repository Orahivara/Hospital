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
    /// Логика взаимодействия для MainPatientPage.xaml
    /// </summary>
    public partial class MainPatientPage : Window
    {
        public MainPatientPage()
        {
            InitializeComponent();
        }

        private void history_Click(object sender, RoutedEventArgs e)
        {
            
            MyIstory istory = new MyIstory();
            istory.Show();
            this.Close();
        }

        private void mydate_Click(object sender, RoutedEventArgs e)
        {
           
            MyInfo info = new MyInfo();
            info.Show();
            this.Close();
        }

        private void write_Click(object sender, RoutedEventArgs e)
        {
            
            WriteService write = new WriteService();
            write.Show();
            this.Close();
        }
        private void aPicture_MouseDown(object sender, MouseEventArgs e)
        {
           WillWriteService willWrite =new WillWriteService();
            willWrite.Show();
            this.Close();
        }
        private void bPicture_MouseDown(object sender, MouseEventArgs e)
        {
           
            this.Close();
        }
    }
}
