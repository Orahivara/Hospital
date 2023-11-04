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
using Hospital.DB;
using Hospital.ClassHelper;
using Hospital.Windows;

namespace Hospital.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow window=new MainWindow();
            window.Show();

        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            PatientShitikova patient=new PatientShitikova();
            if (fname.Text != "" && lname.Text != "" && Mname.Text
                    != "" && addres.Text != "" && phone.Text != "" && email.Text != "" && login.Text != "" && pass.Password != null)
            { 
            patient.FName=fname.Text;
                patient.LName=lname.Text;
                patient.MName = Mname.Text;
                patient.Address = addres.Text;
                patient.Phone= phone.Text;
                patient.Email = email.Text;
                patient.Login= login.Text;
                patient.Password = pass.Password;
                if (m.IsChecked == true) {
                    patient.IDGender = 1;
                }
                if (j.IsChecked == true)
                {
                    patient.IDGender = 2;
                }
                Help.Context.PatientShitikovas.Add(patient);
                Help.Context.SaveChanges();
               
                MainWindow main=new MainWindow();
                main.Show();

                this.Close();

            }
        }
    }
}
