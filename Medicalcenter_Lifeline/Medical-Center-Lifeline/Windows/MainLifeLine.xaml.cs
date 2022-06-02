using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
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
using System.Windows.Threading;

namespace Medical_center_Lifeline
{


    public partial class MainLifeLine : Window
    {
        Classes.Clients client;
        static public bool messange;
        public static object names;
        ForAdmin.Admin admin;
        public bool Admin = false;
        public bool guest = false;
        public bool user = false;
        string connectionString;
        public MainLifeLine(Classes.Clients clients)
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            this.client = clients;
            InitializeComponent();
            DoctorFraim.Navigate(new Main(client));
            Manager.DoctorFraim = DoctorFraim;
            names = client.Name_Client;
            var image = new BitmapImage();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 2);
            dispatcherTimer.Start();

            using (var mem = new MemoryStream((client.Image)))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }

            image.Freeze();
            photo.Source = image;
            Greeting.Text = $"Здравствуйте, {client.Name_Client}! Как ваш день?";
            user = true;

        }
        public MainLifeLine(ForAdmin.Admin admin)
        {

            InitializeComponent();
            DoctorFraim.Navigate(new Main(admin));
            Manager.DoctorFraim = DoctorFraim;
            Admin = true;
            Greeting.Text = $"Здравствуйте, админ! Как ваш день?";
        }
        public MainLifeLine()
        {
            InitializeComponent();
            DoctorFraim.Navigate(new Main());
            Manager.DoctorFraim = DoctorFraim;
            guest = true;
            Greeting.Text = $"Здравствуйте, гость! Как ваш день?";
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windowses = new MainWindow();
            windowses.Show();
            this.Close();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            Manager.DoctorFraim.Navigate(new Aboutas());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (guest)
                Manager.DoctorFraim.Navigate(new Main());
            if (Admin)
                Manager.DoctorFraim.Navigate(new Main(admin));
            if (user)
                Manager.DoctorFraim.Navigate(new Main(client));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (guest)
                Manager.DoctorFraim.Navigate(new allDoctor());
            if (Admin)
                Manager.DoctorFraim.Navigate(new allDoctor(admin));
            if (user)
                Manager.DoctorFraim.Navigate(new allDoctor(client));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Admin)
                Manager.DoctorFraim.Navigate(new allprocedures(admin));
            if (guest || user)
            {
                Manager.DoctorFraim.Navigate(new allprocedures());
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (user)
                Manager.DoctorFraim.Navigate(new Reviews(client));
            if (Admin)
                Manager.DoctorFraim.Navigate(new Reviews(admin));
            if (guest)
                Manager.DoctorFraim.Navigate(new Reviews());

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (user)
                Manager.DoctorFraim.Navigate(new Profil(client));
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
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlExpression2 = $"SELECT * FROM Clients Where ID_Client='{client.ID_Clients}'";


                SqlCommand sqlCommand = new SqlCommand(sqlExpression2, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                try
                {
                    var image = new BitmapImage();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Greeting.Text = $"Здраствуйте, {client.Name_Client}! Как ваш день?";
                            using (var mem = new MemoryStream((client.Image)))
                            {
                                mem.Position = 0;
                                image.BeginInit();
                                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.UriSource = null;
                                image.StreamSource = mem;
                                image.EndInit();
                            }

                            image.Freeze();
                            photo.Source = image;

                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }
}


