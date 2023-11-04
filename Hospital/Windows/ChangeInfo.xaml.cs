using Hospital.ClassHelper;
using Hospital.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hospital.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangeInfo.xaml
    /// </summary>
    public partial class ChangeInfo : Window
    {
        public ChangeInfo()
        {
            InitializeComponent();
            date.ItemsSource = Help.Context.MyINfo(75);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
//
            
        }
    }
}
