using Hospital.ClassHelper;
using Hospital.DB;
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
    /// Логика взаимодействия для WriteService.xaml
    /// </summary>
    public partial class WriteService : Window
    {
        public WriteService()
        {
            InitializeComponent();

            grid.ItemsSource = Help.Context.MedicalServiceShitikova.ToList();
              grid.SelectedIndex = 1;
                grid.DisplayMemberPath = "TitleService";
            
         
        }

        private void Назад_Click(object sender, RoutedEventArgs e)
        {
            
            Windows.MainPatientPage patientPage = new MainPatientPage();
            patientPage.Show();
            this.Close();
        }

        private void write_Click(object sender, RoutedEventArgs e)
        {
            AppointmentYulia appointmentYulia = new AppointmentYulia();
            appointmentYulia.IDMedicalService = (grid.SelectedItem as DB.MedicalServiceShitikova).ID;
            appointmentYulia.IDEmloyee = 1;
            string datet = date.SelectedDate.ToString();
            appointmentYulia.DateService = Convert.ToDateTime(datet);
            Help.Context.AppointmentYulia.Add(appointmentYulia);

            Help.Context.SaveChanges();
            MessageBox.Show("Вы записаны");

        }
    }
}
