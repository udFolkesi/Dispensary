using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispensary2
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private const string ConnectionString = @"Data Source=DESKTOP-C6I6F3P\SQLEXPRESS;Initial Catalog=Dispansery2;Integrated Security=True";

        private void roomTypes_button_Click(object sender, EventArgs e)
        {
            statisticsName_label.Text = "The most popular room types";
            string sqlExpression =
                @"SELECT [Room types].TypeName, count(Habitations.RoomCode) AS 'Number' FROM Habitations
                  RIGHT JOIN Rooms ON Rooms.RoomID = Habitations.RoomCode
                  RIGHT JOIN [Room types] ON [Room types].RoomTypeID = Rooms.RoomTypeCode
                  GROUP BY [Room types].TypeName
                  ORDER BY COUNT(Rooms.RoomTypeCode) DESC;";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sqlExpression, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void medicalServices_button_Click(object sender, EventArgs e)
        {
            statisticsName_label.Text = "The most popular medical services";
            string sqlExpression =
                @"SELECT Treatment.TreatmentID, Treatment.TreatmentName, COUNT([Selected services].TreatmentCode) AS 'Number', SUM([Selected services].HoursAmount) AS [Hours amount] 
                  FROM [Selected services]
                  INNER JOIN Treatment ON Treatment.TreatmentID = [Selected services].TreatmentCode
                  GROUP BY Treatment.TreatmentID, Treatment.TreatmentName
                  ORDER BY COUNT([Selected services].TreatmentCode) DESC, SUM([Selected services].HoursAmount) DESC;";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sqlExpression, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void treatmentAccounts_button_Click(object sender, EventArgs e)
        {
            statisticsName_label.Text = "The largest treatment accounts";
            string sqlExpression =
                @"SELECT Clients.ClientID, Clients.Surname, Clients.Name, SUM([Selected services].HoursAmount * Treatment.PricePerHour) AS 'Price' 
                  FROM [Selected services]
                  INNER JOIN Habitations ON Habitations.HabitationID = [Selected services].HabitationCode
                  INNER JOIN Clients ON Clients.ClientID = Habitations.ClientCode
                  INNER JOIN Treatment ON Treatment.TreatmentID = [Selected services].TreatmentCode
                  GROUP BY Clients.ClientID, Clients.Surname, Clients.Name
                  ORDER BY SUM([Selected services].HoursAmount * Treatment.PricePerHour) DESC;";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sqlExpression, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void discountTypes_button_Click(object sender, EventArgs e)
        {
            statisticsName_label.Text = "The most popular discount types";
            string sqlExpression =
                @"SELECT Discounts.DiscountType, Discounts.DiscountID, COUNT(Accounts.DiscountCode) AS 'Number' FROM Accounts
                  INNER JOIN Discounts ON.Accounts.DiscountCode = Discounts.DiscountID
                  GROUP BY Discounts.DiscountID, Discounts.DiscountType
                  ORDER BY COUNT(Accounts.DiscountCode) DESC;";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sqlExpression, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }
    }
}
