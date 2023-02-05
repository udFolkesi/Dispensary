using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace Dispensary2
{
    public partial class ViewingForm : Form
    {
        public ViewingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Treatment";
            tableView_dataGridView.DataSource = treatmentBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columns_comboBox.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Selected services";
            tableView_dataGridView.DataSource = selectedServicesBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columns_comboBox.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Clients";
            tableView_dataGridView.DataSource = clientsBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            columns_comboBox.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Accounts";
            tableView_dataGridView.DataSource = accountsBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columns_comboBox.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Habitations";
            tableView_dataGridView.DataSource = habitationsBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columns_comboBox.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Discounts";
            tableView_dataGridView.DataSource = discountsBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columns_comboBox.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Rooms";
            tableView_dataGridView.DataSource = roomsBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columns_comboBox.SelectedIndex = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tableName_label.Text = "Room types";
            tableView_dataGridView.DataSource = roomTypesBindingSource;
            tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columns_comboBox.SelectedIndex = 0;
        }

        private void ViewingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dispansery2DataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Selected_services' table. You can move, or remove it, as needed.
            this.selected_servicesTableAdapter.Fill(this.dispansery2DataSet.Selected_services);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Habitations' table. You can move, or remove it, as needed.
            this.habitationsTableAdapter.Fill(this.dispansery2DataSet.Habitations);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dispansery2DataSet.Clients);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Room_types' table. You can move, or remove it, as needed.
            this.room_typesTableAdapter.Fill(this.dispansery2DataSet.Room_types);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.dispansery2DataSet.Rooms);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Discounts' table. You can move, or remove it, as needed.
            this.discountsTableAdapter.Fill(this.dispansery2DataSet.Discounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.dispansery2DataSet.Treatment);
            tableView_dataGridView.AutoGenerateColumns = true;
            for(int i = 0; i < filter_checkedListBox.Items.Count; i++)
            {
                filter_checkedListBox.SetItemChecked(i, true);
            }

        }

        const string ConnectionString = @"Data Source=DESKTOP-C6I6F3P\SQLEXPRESS;Initial Catalog=Dispansery2;Integrated Security=True";


        private void search_button_Click(object sender, EventArgs e)
        {
            if(filter_comboBox.Text == "")
            {
                MessageBox.Show("Please select a filter", "Error");
            }
            else
            {
                string tableName = tableName_label.Text.Replace(" ", "_");
                try
                {
                    //SELECT * FROM Clients WHERE Surname LIKE '%' + 'пл' + '%'
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter($"SELECT * FROM {tableName} " +
                        $"WHERE {filter_comboBox.SelectedItem} LIKE '%' + '{search_textbox.Text}' + '%'", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    tableView_dataGridView.DataSource = dt;
                    if (tableView_dataGridView.DataSource != clientsBindingSource)
                    {
                        tableView_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void tableView_dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            filter_comboBox.Items.Clear();
            filter_comboBox.Text = "";
            columns_comboBox.Items.Clear();
            //int columnCount = tableView_dataGridView.Columns.Count;
            List<string> columnsArray = new List<string>();
            columnsArray.Clear();
            //ColumnsArray = new string[""];
            for (int i = 0; i <= tableView_dataGridView.Columns.Count - 1; i++)
            {
                columnsArray.Add(tableView_dataGridView.Columns[i].HeaderText);
                //ColumnsArray[i] = tableView_dataGridView.Columns[i].HeaderText;
            }
            filter_comboBox.Items.AddRange(columnsArray.ToArray());
            columns_comboBox.Items.AddRange(columnsArray.ToArray());
            
        }

        private void search_button_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private string pathChecks = @"C:\Users\USER\Desktop\Dispensary2\Reports\Checks";
        private string pathReports = @"C:\Users\USER\Desktop\Dispensary2\Reports\Reports";
        private decimal accServices = 0;
        private decimal accHabitation = 0;
        private decimal sum = 0;
        private int discountCode = 0;

        private void getCheck_button_Click_1(object sender, EventArgs e)
        {
            if(tableView_dataGridView.DataSource != habitationsBindingSource)
            {
                MessageBox.Show("Please select Habitations table.");
            }
            else
            {
                FileStream filestream = new FileStream(pathChecks + $@"\check{GetFilesAmount(pathChecks)}.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, filestream);
                BaseFont baseFont = BaseFont.CreateFont("c:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font font = new Font(baseFont);
                document.Open();
                //document.AddCreationDate();
                //PdfPTable table = new PdfPTable(habitationsTableAdapter);
                Paragraph header = new Paragraph($"Check #{Convert.ToInt32(GetFilesAmount(pathChecks)) - 1}");
                header.Alignment = Element.ALIGN_CENTER;
                document.Add(header);
                //stackalloc
                int habitationID = Convert.ToInt32(tableView_dataGridView.SelectedRows[0].Cells[0].Value);
                string name = dispansery2DataSet.Clients.FindByClientID(habitationID).Name;
                string surname = dispansery2DataSet.Clients.FindByClientID(habitationID).Surname;
                GetAccountsInfo(habitationID);
                //decimal accServices = dispansery2DataSet.Accounts.Rows. (habitationID).AccountServices;
                //decimal accHabitation = dispansery2DataSet.Accounts.FindByAccountID(habitationID).AccountHabitation;
                //decimal sum = dispansery2DataSet.Accounts.FindByAccountID(habitationID).TotalSum;
                //string discountName = dispansery2DataSet.Discounts.FindByAccountID().TotalSum;
                document.Add(new Paragraph($"Client: {name} {surname}", font));
                document.Add(new Paragraph($"Habitation ID: {tableView_dataGridView.SelectedRows[0].Cells[0].Value}"));
                document.Add(new Paragraph($"Account Services: {accServices}"));
                document.Add(new Paragraph($"Account Habitation: {accHabitation}"));
                document.Add(new Paragraph($"Discount: {dispansery2DataSet.Discounts.FindByDiscountID(discountCode).DiscountPercentage}"));
                document.Add(new Paragraph($"Total sum: {sum}"));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph($"Date: {DateTime.Now}"));
                Paragraph footer = new Paragraph("-Dispensary \"Оздоровчий\"-", font);
                footer.Alignment = Element.ALIGN_CENTER;
                document.Add(footer);
                document.Close();
                System.Diagnostics.Process.Start(pathChecks + $@"\check{Convert.ToInt32(GetFilesAmount(pathChecks)) - 1}.pdf");
                
                //FileStream fstream = new FileStream(path + $@"\check{Convert.ToInt32(GetFilesAmount()) - 1}.pdf", FileMode.Open);
            }

        }

        private string GetFilesAmount(string path)
        {
            //DirectoryInfo directInfo = new DirectoryInfo(@"C:\Users\USER\Desktop\Dispensary2\Reports"); 
            //FileInfo[] Files = directInfo.GetFiles("*.pdf"); 
            return Directory.GetFiles(path).Length.ToString();
        }

        private void GetAccountsInfo(int habitationID)
        {
            string sqlExpression = 
                $"SELECT AccountHabitation, AccountServices, DiscountCode, TotalSum FROM Accounts " +
                $"WHERE HabitationCode = {habitationID}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    accHabitation = reader.GetDecimal(0);
                    accServices = reader.GetDecimal(1);
                    discountCode = reader.GetInt32(2);
                    sum = reader.GetDecimal(3);
                }

                reader.Close();
                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sqlExpDiscount = 
                "SELECT TOP 1 Discounts.DiscountType, COUNT(Discounts.DiscountType) FROM Accounts " +
                "INNER JOIN Discounts ON Discounts.DiscountID = Accounts.DiscountCode " +
                "INNER JOIN Habitations ON Habitations.HabitationID = Accounts.HabitationCode " +
                "WHERE Habitations.CheckInDate > (SELECT DATEADD(month, -1, GETDATE())) " +
                "GROUP BY Discounts.DiscountType ORDER BY COUNT(Discounts.DiscountType) DESC; ";
            string sqlExpTreatment = 
                "SELECT TOP 1 Treatment.TreatmentName, COUNT(Treatment.TreatmentName) FROM [Selected services] " +
                "INNER JOIN Treatment ON Treatment.TreatmentID = [Selected services].TreatmentCode " +
                "INNER JOIN Habitations ON Habitations.HabitationID = [Selected services].HabitationCode " +
                "WHERE Habitations.CheckInDate > (SELECT DATEADD(month, -1, GETDATE())) " +
                "GROUP BY Treatment.TreatmentName ORDER BY COUNT(Treatment.TreatmentName) DESC; ";
            string sqlExpRoomType = 
                "SELECT TOP 1 [Room types].TypeName, COUNT([Room types].TypeName) FROM Habitations " +
                "INNER JOIN Rooms ON Rooms.RoomID = Habitations.RoomCode " +
                "INNER JOIN[Room types] ON[Room types].RoomTypeID = Rooms.RoomTypeCode " +
                "WHERE Habitations.CheckInDate > (SELECT DATEADD(month, -1, GETDATE())) " +
                "GROUP BY[Room types].TypeName ORDER BY COUNT([Room types].TypeName) DESC; ";
            FileStream filestream = new FileStream(pathReports + $@"\report{GetFilesAmount(pathReports)}.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, filestream);
            BaseFont baseFont = BaseFont.CreateFont("c:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(baseFont);
            document.Open();
            Paragraph header = new Paragraph($"Report #{Convert.ToInt32(GetFilesAmount(pathReports)) - 1}");
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);
            document.Add(new Paragraph($"Selected period {DateTime.Now.AddMonths(-1).ToString("dd.MM.yyy")} - {DateTime.Now.ToString("dd.MM.yyy")}"));
            document.Add(new Paragraph($"Total income: {GetIncomeMonth()} ₴", font));
            document.Add(new Paragraph($"The most profitable client: {GetFullName().Item1} {GetFullName().Item2}", font));
            document.Add(new Paragraph($"The most popular discount: {GetTopItem(sqlExpDiscount)}", font));
            document.Add(new Paragraph($"The most popular treatment: {GetTopItem(sqlExpTreatment)}", font));
            document.Add(new Paragraph($"The most popular room type: {GetTopItem(sqlExpRoomType)}", font));
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph($"Date: {DateTime.Now}"));
            Paragraph footer = new Paragraph("-Dispensary \"Оздоровчий\"-", font);
            footer.Alignment = Element.ALIGN_CENTER;
            document.Add(footer);
            document.Close();
            System.Diagnostics.Process.Start(pathReports + $@"\report{Convert.ToInt32(GetFilesAmount(pathReports)) - 1}.pdf");
        }

        private decimal GetIncomeMonth()
        {
            string sqlExpression = 
                $"SELECT SUM(Accounts.TotalSum) FROM Accounts " +
                $"INNER JOIN Habitations ON Habitations.HabitationID = Accounts.HabitationCode " +
                $"WHERE Habitations.CheckInDate > (SELECT DATEADD(month, -1, GETDATE())); ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetDecimal(0);
                }

                reader.Close();
                connection.Close();
            }

            return 0;
        }

        private Tuple<string, string> GetFullName()
        {
            string sqlExpression = 
                "SELECT TOP 1 Clients.Surname, Clients.Name AS 'Name', Accounts.TotalSum FROM Accounts " +
                "INNER JOIN Habitations ON Habitations.HabitationID = Accounts.HabitationCode " +
                "INNER JOIN Clients ON Clients.ClientID = Habitations.ClientCode " +
                "WHERE Habitations.CheckInDate > (SELECT DATEADD(month, -1, GETDATE())) " +
                "ORDER BY Accounts.TotalSum DESC";
            string surname = "";
            string name = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    surname = reader.GetString(0);
                    name = reader.GetString(1);
                }

                reader.Close();
                connection.Close();
            }

            return Tuple.Create(surname, name);
        }

        private string GetTopItem(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetString(0);
                }

                reader.Close();
                connection.Close();
            }

            return "";
        }

        //private List<string> columnsList = new List<string>();
        private string selectedColumns = "";

        private void ascending_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // if not clients
            string select = "";
            if(tableName_label.Text == "Clients")
            {
                select = $"SELECT {selectedColumns} FROM [{tableName_label.Text}] ORDER BY {columns_comboBox.Text} ASC";
            }
            else
            {
                select = $"SELECT * FROM [{tableName_label.Text}] ORDER BY {columns_comboBox.Text} ASC";
            }

            var c = new SqlConnection(ConnectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            tableView_dataGridView.DataSource = ds.Tables[0];
        }

        private void descending_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string select = "";
            if(tableName_label.Text == "Clients")
            {
                select = $"SELECT {selectedColumns} FROM [{tableName_label.Text}] ORDER BY {columns_comboBox.Text} DESC";
            }
            else
            {
                select = $"SELECT * FROM [{tableName_label.Text}] ORDER BY {columns_comboBox.Text} DESC";
            }

            //var select = $"SELECT * FROM {tableName_label.Text.Replace(" ", "_")} ORDER BY {columns_comboBox.Text} DESC";
            var c = new SqlConnection(ConnectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            tableView_dataGridView.DataSource = ds.Tables[0];
        }

        private void filter_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> columnsList = new List<string>();
            for (int i = 0; i < dispansery2DataSet.Clients.Columns.Count; i++)
            {
                columnsList.Add(dispansery2DataSet.Clients.Columns[i].ColumnName);
            }

            for (int i = 0; i < filter_checkedListBox.Items.Count; i++)
            {
                if (!filter_checkedListBox.GetItemChecked(i))
                {
                    columnsList.Remove(filter_checkedListBox.Items[i].ToString());
                }
            }

            selectedColumns = "";
            foreach (var i in columnsList)
            {
                selectedColumns += i;
                selectedColumns += ", ";
            }

            selectedColumns = selectedColumns.Remove(selectedColumns.Length - 2);
            var select = $"SELECT {selectedColumns} FROM Clients";
            var c = new SqlConnection(ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            tableView_dataGridView.DataSource = ds.Tables[0];
        }
    }
}
