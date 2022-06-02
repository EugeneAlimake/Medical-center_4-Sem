using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        string connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Text == "пароль")
            {
                Password.Text = "";
            }
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Password.Text))
                Password.Text = "пароль";
        }

        private void Login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Logine.Text == "логин")
            {
                Logine.Text = "";
            }
        }

        private void Login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Logine.Text))
                Logine.Text = "логин";
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new Registration());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool pointadmin = false;
            ForAdmin.Admin admin = new ForAdmin.Admin();
            if (Logine.Text == admin.login && Password.Text == admin.password)
            {
                MainLifeLine window1 = new MainLifeLine(admin);
                window1.Show();
                foreach (Window window in Application.Current.Windows)
                {
                    if (window is MainWindow)
                    {
                        window.Close();
                        pointadmin = true;
                        break;
                    }
                }

            }

            string sql = $"SELECT * FROM Clients";
            try
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    if (Logine.Text != "логин" && Password.Text != "пароль")
                    {
                        SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        Classes.Clients clients = new Classes.Clients();
                        if (reader.HasRows)
                        {
                            bool flagClients = false;
                            while (reader.Read())
                            {
                                if (Logine.Text == (string)reader.GetValue(5) && Password.Text == (string)reader.GetValue(4))
                                {
                                    flagClients = true;
                                    clients.ID_Clients = reader.GetValue(0);
                                    clients.Name_Client = reader.GetValue(1);
                                    clients.Surname_Client = reader.GetValue(2);
                                    clients.Email = reader.GetValue(3);
                                    clients.Password = reader.GetValue(4);
                                    clients.Login = reader.GetValue(5);
                                    clients.Image = (byte[])reader.GetValue(6);



                                    break;
                                }

                            }
                            reader.Close();
                            if (flagClients)
                            {
                                MainLifeLine window1 = new MainLifeLine(clients);
                                window1.Show();
                                foreach (Window window in Application.Current.Windows)
                                {
                                    if (window is MainWindow)
                                    {
                                        window.Close();
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (pointadmin == false)
                                    Warring.Text = "Неправильно введен логин или пароль";
                                

                            }
                        }

                    }
                    else
                    {
                        Warring.Text = "Данные до конце не введены";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MainLifeLine window1 = new MainLifeLine();
            window1.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window is MainWindow)
                {
                    window.Close();
                    break;
                }
            }
        }
    }
}
