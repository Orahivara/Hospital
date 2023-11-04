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
            date.ItemsSource = Help.Context.INFO(75);
           
        }
        private void bPicture_MouseDown(object sender, MouseEventArgs e)
        {

            this.Close();
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
        forhelp.ItemsSource =  Help.Context.PatientShitikovas.Where(u => u.ID == 75).ToList();
            PatientShitikova patient = new PatientShitikova();
            patient.DateOfBirth = Convert.ToDateTime(date.SelectedCells[1]);
            patient.IDGender = (forhelp.Items[6] as DB.Gender).ID;
            patient.FName = forhelp.Items[1].ToString();
            patient.LName = forhelp.Items[2].ToString();
            patient.MName = forhelp.Items[3].ToString();
            patient.Phone = date.SelectedCells[2].ToString();
            patient.Address = date.SelectedCells[4].ToString();
            patient.Email = date.SelectedCells[5].ToString();

            Help.Context.PatientShitikovas.AddOrUpdate(patient);
            Help.Context.SaveChanges();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainPatientPage mainPatientPage = new MainPatientPage();
            mainPatientPage.Show();
            this.Close();
        }
    }
}
