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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Medical_center_Lifeline
{
    /// <summary>
    /// Логика взаимодействия для AllOrder.xaml
    /// </summary>
    public partial class AllOrder : Page
    {
        string connectionString;
        public AllOrder()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string sqlExpression2;
                    string sqlExpression3;
                    sqlExpression2 = $"SELECT [Order].Order_number,[Order].Date,[Order].[Time],[Order].ID_Coupon, [Procedures].Name_Procedures,Doctor.Name_Doctor,Doctor.Middle_name_Doctor,[Procedures].Price, Clients.Name_Client,Clients.Surname_Client FROM [Order] " +
                        $"inner join[Procedures] on[Order].ID_Procedures =[Procedures].ID_Procedures and Date> cast(GETDATE() as date)" +
                        $"inner join[Doctor] on[Order].ID_Doctor =[Doctor].ID_Doctor " +
                        $"inner join Clients on Clients.ID_Client =[Order].ID_Client";

                    sqlExpression3 = $"SELECT [Order].Order_number,[Order].Date,[Order].[Time],[Order].ID_Coupon, [Procedures].Name_Procedures,Doctor.Name_Doctor,Doctor.Middle_name_Doctor,[Procedures].Price, Clients.Name_Client,Clients.Surname_Client FROM [Order] " +
                        $"inner join[Procedures] on[Order].ID_Procedures =[Procedures].ID_Procedures  and Date = cast(GETDATE() as date) and Time> CAST(GETDATE() as time)" +
                        $"inner join[Doctor] on[Order].ID_Doctor =[Doctor].ID_Doctor " +
                        $"inner join Clients on Clients.ID_Client =[Order].ID_Client";

                    SqlCommand sqlCommand = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    List<Classes.Order> orders = new List<Classes.Order>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Classes.Order order = new Classes.Order();

                            order.Ordet_number = reader.GetValue(0);
                            DateTime a = (DateTime)reader.GetValue(1);
                            order.Date = a.ToShortDateString();
                            order.Time = reader.GetValue(2);
                            order.ID_Coupon = reader.GetValue(3);
                            order.ID_Procedures = reader.GetValue(4);
                            string name = (string)reader.GetValue(5);
                            string surname = (string)reader.GetValue(6);
                            order.ID_Doctor = $"{name} {surname}";
                            string clientname = (string)reader.GetValue(8);
                            string clientsurname = (string)reader.GetValue(9);
                            order.ID_Client = $"{clientname} {clientsurname}";
                            order.Price = reader.GetValue(7);
                            orders.Add(order);
                        }
                    }
                    reader.Close();
                    SqlCommand sqlCommand1 = new SqlCommand(sqlExpression3, connection);
                    SqlDataReader reader1 = sqlCommand1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            Classes.Order order = new Classes.Order();
                            order.Ordet_number = reader.GetValue(0);
                            DateTime a = (DateTime)reader.GetValue(1);
                            order.Date = a.ToShortDateString();
                            order.Time = reader.GetValue(2);
                            order.ID_Coupon = reader.GetValue(3);
                            order.ID_Procedures = reader.GetValue(4);
                            string name = (string)reader.GetValue(5);
                            string surname = (string)reader.GetValue(6);
                            order.ID_Doctor = $"{name} {surname}";
                            string clientname = (string)reader.GetValue(8);
                            string clientsurname = (string)reader.GetValue(9);
                            order.ID_Client = $"{clientname} {clientsurname}";
                            order.Price = reader.GetValue(7);

                            orders.Add(order);
                        }
                    }
                    Control.ItemsSource = orders;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
