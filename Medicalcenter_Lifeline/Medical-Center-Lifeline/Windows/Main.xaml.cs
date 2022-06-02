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

namespace Medical_center_Lifeline
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        Classes.Clients client;
        static public bool messange;
        public static object names;
        ForAdmin.Admin admin;
        public bool Admin = false;
        public bool guest = false;
        public bool user = false;
        public Main()
        {
            InitializeComponent();
            guest = true;
            Allorder.Height = 0;
            Allorder.Width = 0;
            foradmin.Width = 0;
            foradmin.Height = 0;
        }
        public Main(Classes.Clients clients)
        {
            InitializeComponent();
            user = true;
            client = clients;
            Allorder.Height = 0;
            Allorder.Width = 0;
            foradmin.Width = 0;
            foradmin.Height = 0;
        }
        public Main(ForAdmin.Admin admin)
        {
            InitializeComponent();
            Admin = true;
        }
        private void Place1_Click(object sender, RoutedEventArgs e)
        {
            Manager.DoctorFraim.Navigate(new Aboutas());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.DoctorFraim.Navigate(new Aboutas());
        }

        private void Place_Click(object sender, RoutedEventArgs e)
        {
            if (user)
            {
                Createorder createorder = new Createorder(client);
                createorder.Show();
            }
            if (guest)
            {
                MessangeBox_Ok messangeBox_OK = new MessangeBox_Ok("Для начала зарегистрируйтесь!");
                messangeBox_OK.Show();
            }
            if (Admin)
            {
                MessangeBox_Ok messangeBox_OK1 = new MessangeBox_Ok("Вы администратор!");
                messangeBox_OK1.Show();
            }
        }

        private void Allorder_Click(object sender, RoutedEventArgs e)
        {
            Manager.DoctorFraim.Navigate(new AllOrder());
        }

        private void foradmin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.DoctorFraim.Navigate(new AllOrder());
        }
    }
}
