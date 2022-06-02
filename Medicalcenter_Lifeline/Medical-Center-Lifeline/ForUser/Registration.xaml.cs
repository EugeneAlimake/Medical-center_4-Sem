using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public bool emailbool = true;
        public bool loginregistr = false;
        string connectionString;
        bool names = true;
        bool surnames = true;
        bool password = true;
        string allowedchar = "'";
        public Registration()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == "электронная почта")
            {
                email.Text = "";
            }
        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email.Text))
                email.Text = "электронная почта";
            string emails = email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emails);
            if ((match.Success))
            {
                Yesornoemail.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\yes.png", UriKind.Absolute));
                emailbool = true;
            }
            if ((match.Success == false))
            {
                Yesornoemail.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\no.png", UriKind.Absolute));
                emailbool = false;
            }
        }

        private void name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text))
                name.Text = "имя";

            Regex regex = new Regex(@"^[A-ЯЁ][а-яё]+$");
            if (!regex.IsMatch(name.Text))
            {
                Yesornoname.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\no.png", UriKind.Absolute));
                names = false;
            }
            else if (regex.IsMatch(name.Text))
            {
                Yesornoname.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\yes.png", UriKind.Absolute));
                names = true;
            }
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "имя")
            {
                name.Text = "";
            }
        }

        private void Logine_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Logine.Text == "логин")
            {
                Logine.Text = "";
            }
        }

        private void Logine_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Logine.Text))
                Logine.Text = "логин";

            if ((Logine.Text.ToString().Contains(allowedchar)))
            {
                Yesornologine.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\no.png", UriKind.Absolute));
                loginregistr = false;
                return;
            }
            string sql = $"SELECT * FROM Clients";
            try
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    if (Logine.Text != "логин")
                    {
                        SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                if (Logine.Text == (string)reader.GetValue(5) || Logine.Text == "admin")
                                {
                                    Yesornologine.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\no.png", UriKind.Absolute));
                                    loginregistr = false;
                                    break;
                                }
                                else
                                {
                                    loginregistr = true;
                                    Yesornologine.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\yes.png", UriKind.Absolute));
                                }
                            }
                            reader.Close();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            if ((Password.Text.ToString().Contains(allowedchar)))
            {
                Yesornopassword.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\no.png", UriKind.Absolute));
                password = false;
                return;
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new Login());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((Logine.Text != "логин") && (Password.Text != "пароль") && (name.Text != "имя") && (Surrename.Text != "фамилия") && (email.Text != "электронная почта") && (emailbool) && (loginregistr) && names && surnames&&password)
            {
                byte[] imageBytesBuffer;

                using (FileStream fs = new FileStream(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\woman.png", FileMode.Open, FileAccess.Read))
                {
                    imageBytesBuffer = new byte[fs.Length];
                    fs.Read(imageBytesBuffer, 0, imageBytesBuffer.Length);
                }




                string sql = $"INSERT INTO Clients ([Name_Client],[Surname_Client],[Email],[Login],[Password],[Image]) VALUES ('{name.Text}','{Surrename.Text}','{email.Text}','{Logine.Text}','{Password.Text}',@bytes)";
                try
                {

                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand command1 = new SqlCommand(sql, sqlConnection);
                        command1.Parameters.AddWithValue("@bytes", imageBytesBuffer);
                        command1.ExecuteNonQuery();
                        MessangeBox_Ok messange = new MessangeBox_Ok("Вы зарегистрированы!");
                        messange.Show();
                        Manager.MainFrame.Navigate(new Login());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Manager.MainFrame.Navigate(new Login());
            }
            
        }

        private void Surrename_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Surrename.Text == "фамилия")
            {
                Surrename.Text = "";
            }
        }

        private void Surrename_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Surrename.Text))
                Surrename.Text = "фамилия";

            Regex regex = new Regex(@"^[A-ЯЁ][а-яё]+$");
            if (!regex.IsMatch(Surrename.Text))
            {
                Yesornolastname.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\no.png", UriKind.Absolute));
                surnames = false;
            }
            else if (regex.IsMatch(Surrename.Text))
            {
                Yesornolastname.Source = new BitmapImage(new Uri(@"C:\Users\thesi\Desktop\КП\Medical center-Lifeline\Medical center-Lifeline\image\yes.png", UriKind.Absolute));
                surnames = true;
            }
        }
    }
}
