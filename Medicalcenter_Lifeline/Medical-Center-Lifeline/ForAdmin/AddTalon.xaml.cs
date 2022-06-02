using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace Medical_center_Lifeline
{
    /// <summary>
    /// Логика взаимодействия для AddTalon.xaml
    /// </summary>
    public partial class AddTalon : Window
    {
        int dayofweek;
        string connectionString;
        public List<Classes.Doctor> doctors = new List<Classes.Doctor>();
        Classes.schedule schedule = new Classes.schedule();
        int ID_D;
        public AddTalon()
        {
            InitializeComponent();
            Doctorname.SelectedIndex = 0;
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sqlExpression2 = $"SELECT * FROM Doctor ";
                    string comdobox;
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Classes.Doctor doctor = new Classes.Doctor();

                            doctor.ID_Doctor = reader.GetValue(0);
                            doctor.Name_Doctor = reader.GetValue(1);
                            doctor.Surname_Doctor = reader.GetValue(2);
                            doctor.Middle_name_Doctor = reader.GetValue(3);
                            doctors.Add(doctor);

                            comdobox = (string)doctor.Surname_Doctor + " " + (string)doctor.Name_Doctor + " " + (string)doctor.Middle_name_Doctor;
                            Doctorname.Items.Add(comdobox);

                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Doctorname_DropDownClosed(object sender, EventArgs e)
        {
            Dateone.Items.Clear();
            Datetwo.Items.Clear();


            if (Doctorname.Text == "Врач")
            {
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {

                        foreach (var doc in doctors)
                        {


                            if ((string)doc.Surname_Doctor + " " + (string)doc.Name_Doctor + " " + (string)doc.Middle_name_Doctor == Doctorname.Text)
                            {
                                ID_D = (int)doc.ID_Doctor;
                            }

                        }
                        string sqlExpression2 = $"SELECT top(1) Coupon.Date FROM Coupon where ID_Doctor={ID_D} ORDER BY Date desc ";
                        string sqlExpression3 = $"Select * from schedule where ID_doctor={ID_D}";

                        SqlCommand sqlCommand = new SqlCommand(sqlExpression2, connection);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                Dateone.Items.Add(reader.GetValue(0));

                            }
                        }
                        reader.Close();
                        SqlCommand sqlCommand2 = new SqlCommand(sqlExpression3, connection);
                        SqlDataReader reader1 = sqlCommand2.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            while (reader1.Read())
                            {


                                Mondfrom.Items.Add(reader1.GetValue(1));
                                Mondto.Items.Add(reader1.GetValue(2));
                                Tuefrom.Items.Add(reader1.GetValue(3));
                                Tueto.Items.Add(reader1.GetValue(4));
                                Wenfrom.Items.Add(reader1.GetValue(5));
                                Wento.Items.Add(reader1.GetValue(6));
                                Thufrom.Items.Add(reader1.GetValue(7));
                                Thuto.Items.Add(reader1.GetValue(8));
                                Frifrom.Items.Add(reader1.GetValue(9));
                                Frito.Items.Add(reader1.GetValue(10));
                                Mondfrom.SelectedIndex = 0;
                                Mondto.SelectedIndex = 0;
                                Tuefrom.SelectedIndex = 0;
                                Tueto.SelectedIndex = 0;
                                Wenfrom.SelectedIndex = 0;
                                Wento.SelectedIndex = 0;
                                Thufrom.SelectedIndex = 0;
                                Thuto.SelectedIndex = 0;
                                Frifrom.SelectedIndex = 0;
                                Frito.SelectedIndex = 0;

                            }

                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void Dateone_DropDownClosed_1(object sender, EventArgs e)
        {
            Datetwo.Items.Clear();
            if (Dateone.Text != "")
            {
                DateTime fromtime = DateTime.Parse(Dateone.Text);
                DateTime dateplusmounth = fromtime.AddMonths(1);
                fromtime = fromtime.AddDays(1);
                while (fromtime < dateplusmounth)
                {
                    Datetwo.Items.Add(fromtime);

                    fromtime = fromtime.AddDays(1);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                DateTime fromtime = DateTime.Parse(Dateone.Text);
                fromtime = fromtime.AddDays(1);
                DateTime totime = DateTime.Parse(Dateone.Text);
                totime = totime.AddDays(1);
                while (fromtime <= totime)
                {
                    dayofweek = (int)fromtime.DayOfWeek;
                    switch (dayofweek)
                    {
                        case 1:
                            {
                                DateTime Monfromtime = DateTime.Parse((string)schedule.Mondfrom);
                                DateTime Montotime = DateTime.Parse((string)schedule.Mondfrom);
                                while (Monfromtime < Montotime)
                                {
                                    var dateOnlyString = fromtime.ToShortDateString();
                                    string sqlmond = $"Insert into Coupon([Date],[time],[ID_Doctor],[Ordered]) VALUES (Convert(date, Right('{dateOnlyString}', 4)+SUBSTRING('{dateOnlyString}',4 , 2)+LEFT('{dateOnlyString}', 2) ),Convert(time, Right('{Monfromtime}', 9)),'{ID_D}','no')";
                                    SqlCommand command4 = new SqlCommand(sqlmond, sqlConnection);
                                    command4.ExecuteNonQuery();
                                    Monfromtime = Monfromtime.AddMinutes(30);
                                }
                                fromtime = fromtime.AddDays(1);
                                break;
                            }
                        case 2:
                            {
                                DateTime Tuefromtime = DateTime.Parse(Tuefrom.Text);
                                DateTime Tuetotime = DateTime.Parse(Tueto.Text);
                                while (Tuefromtime < Tuetotime)
                                {
                                    var dateOnlyString = fromtime.ToShortDateString();
                                    string sqltue = $"Insert into Coupon([Date],[time],[ID_Doctor],[Ordered]) VALUES (Convert(date, Right('{dateOnlyString}', 4)+SUBSTRING('{dateOnlyString}',4 , 2)+LEFT('{dateOnlyString}', 2) ),Convert(time, Right('{Tuefromtime}', 9)),'{ID_D}','no')";
                                    SqlCommand command4 = new SqlCommand(sqltue, sqlConnection);
                                    command4.ExecuteNonQuery();
                                    Tuefromtime = Tuefromtime.AddMinutes(30);
                                }
                                fromtime = fromtime.AddDays(1);
                                break;
                            }
                        case 3:
                            {
                                DateTime Wenfromtime = DateTime.Parse(Wenfrom.Text);
                                DateTime Wentotime = DateTime.Parse(Wento.Text);
                                while (Wenfromtime < Wentotime)
                                {
                                    var dateOnlyString = fromtime.ToShortDateString();
                                    string sqlwen = $"Insert into Coupon([Date],[time],[ID_Doctor],[Ordered]) VALUES (Convert(date, Right('{dateOnlyString}', 4)+SUBSTRING('{dateOnlyString}',4 , 2)+LEFT('{dateOnlyString}', 2) ),Convert(time, Right('{Wenfromtime}', 9)),'{ID_D}','no')";
                                    SqlCommand command4 = new SqlCommand(sqlwen, sqlConnection);
                                    command4.ExecuteNonQuery();
                                    Wenfromtime = Wenfromtime.AddMinutes(30);
                                }
                                fromtime = fromtime.AddDays(1);
                                break;
                            }
                        case 4:
                            {
                                DateTime Thufromtime = DateTime.Parse(Thufrom.Text);
                                DateTime Thutotime = DateTime.Parse(Thuto.Text);
                                while (Thufromtime < Thutotime)
                                {
                                    var dateOnlyString = fromtime.ToShortDateString();
                                    string sqlwen = $"Insert into Coupon([Date],[time],[ID_Doctor],[Ordered]) VALUES (Convert(date, Right('{dateOnlyString}', 4)+SUBSTRING('{dateOnlyString}',4 , 2)+LEFT('{dateOnlyString}', 2) ),Convert(time, Right('{Thufromtime}', 9)),'{ID_D}','no')";
                                    SqlCommand command4 = new SqlCommand(sqlwen, sqlConnection);
                                    command4.ExecuteNonQuery();
                                    Thufromtime = Thufromtime.AddMinutes(30);
                                }
                                fromtime = fromtime.AddDays(1);
                                break;
                            }
                        case 5:
                            {
                                DateTime Frifromtime = DateTime.Parse(Frifrom.Text);
                                DateTime Fritotime = DateTime.Parse(Frito.Text);
                                while (Frifromtime < Fritotime)
                                {
                                    var dateOnlyString = fromtime.ToShortDateString();
                                    string sqlfr = $"Insert into Coupon([Date],[time],[ID_Doctor],[Ordered]) VALUES (Convert(date, Right('{dateOnlyString}', 4)+SUBSTRING('{dateOnlyString}',4 , 2)+LEFT('{dateOnlyString}', 2) ),Convert(time, Right('{Frifromtime}', 9)),'{ID_D}','no')";
                                    SqlCommand command4 = new SqlCommand(sqlfr, sqlConnection);
                                    command4.ExecuteNonQuery();
                                    Frifromtime = Frifromtime.AddMinutes(30);
                                }
                                fromtime = fromtime.AddDays(1);
                                break;
                            }
                        case 6:
                            fromtime = fromtime.AddDays(1);
                            break;
                        case 0:
                            fromtime = fromtime.AddDays(1);
                            break;
                        default:
                            break;

                    }
                }
                sqlConnection.Close();
                MessangeBox_Ok messangeBox_Ok = new MessangeBox_Ok("Талоны добавлены!");
                messangeBox_Ok.Show();
                this.Close();
            }
        }
    }
}
