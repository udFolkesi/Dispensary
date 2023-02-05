using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispensary2
{
    public partial class EditForm : Form
    {
        private readonly bool edit = false;

        public EditForm()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'dispansery2DataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Selected_services' table. You can move, or remove it, as needed.
            this.selected_servicesTableAdapter.Fill(this.dispansery2DataSet.Selected_services);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Habitations' table. You can move, or remove it, as needed.
            this.habitationsTableAdapter.Fill(this.dispansery2DataSet.Habitations);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dispansery2DataSet.Clients);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.dispansery2DataSet.Treatment);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.dispansery2DataSet.Rooms);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Discounts' table. You can move, or remove it, as needed.
            this.discountsTableAdapter.Fill(this.dispansery2DataSet.Discounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Room_types' table. You can move, or remove it, as needed.
            this.room_typesTableAdapter.Fill(this.dispansery2DataSet.Room_types);
            edit = false;
        }

        private int clientID = 0;
        private int habitationID = 0;
        private int selectedRow = 0;
        private bool newClient = true;
        private bool reservationDate = false;

        public EditForm(int id, string surname, string name, string patronymic, DateTime dateOfBirth, string sex, 
            string address, string phone, string citizenship, string passport, string email) : this()
        {
            label1.Text = "DATA EDITING";
            comboBox1.Visible = false;
            this.clientID = id;
            surname_textbox.Text = surname;
            name_textbox.Text = name;
            patronymic_textbox.Text = patronymic;
            birth_dateTimePicker.Value = dateOfBirth;
            sex_comboBox.Text = sex;
            address_textbox.Text = address;
            phone_textbox.Text = phone;
            citizenship_textbox.Text = citizenship;
            passport_textbox.Text = passport;
            email_textbox.Text = email;
            GetHabitationInfo();
            GetDiscountType();
            edit = true;
            save_button.Text = "Save changes";
            //GetTreatmentInfo();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dispansery2DataSet.Accounts' table. You can move, or remove it, as needed.
            AddItmesToCheckedBox();
            GetTreatmentInfo();
        }

        private void AddItmesToCheckedBox()
        {
            for(int i = 0; i < dispansery2DataSet.Treatment.Rows.Count; i++)
            {
                treatment_checkedListBox.Items.Add(dispansery2DataSet.Treatment[i][1]);
                treatment_dataGridView.Rows.Add(dispansery2DataSet.Treatment[i][1]); //= dispansery2DataSet.Treatment[i][1];
            }
            
        }

        private void treatment_checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int i = 0; i < treatment_checkedListBox.CheckedItems.Count; i++)
            {
                MessageBox.Show(treatment_checkedListBox.CheckedItems[i].ToString()); 
            }
        }

        private void treatment_checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private const string ConnectionString = @"Data Source=DESKTOP-C6I6F3P\SQLEXPRESS;Initial Catalog=Dispansery2;Integrated Security=True";
        private Dictionary<int, int> treatmentHoursDict = new Dictionary<int, int>();
        private List<string> treatmentList = new List<string>();
        private string treatments;
        private int AccountServices;
        private int AccountHabitation;
        private bool checkinDateChanged = false;

        private void save_button_Click(object sender, EventArgs e)
        {
            /*if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(surname_textbox.Text, "Demo App - Message!");
            }*/

            if (!edit && surname_textbox.Text != string.Empty)
            {
                if (newClient)
                {
                    clientsTableAdapter.InsertQuery(surname_textbox.Text, name_textbox.Text, patronymic_textbox.Text != string.Empty ? patronymic_textbox.Text : null,
                        birth_dateTimePicker.Value.ToString(), sex_comboBox.Text, address_textbox.Text, phone_textbox.Text,
                        citizenship_textbox.Text, passport_textbox.Text, email_textbox.Text != string.Empty ? email_textbox.Text : null);
                    clientsTableAdapter.Fill(dispansery2DataSet.Clients);

                    habitationsTableAdapter.InsertQuery(Convert.ToInt32(dispansery2DataSet.Clients[dispansery2DataSet.Clients.Rows.Count - 1][0]),
                        Convert.ToInt32(rooms_comboBox.SelectedValue), reservationDate == true ? reservation_dateTimePicker.Value : null,
                        checkin_dateTimePicker.Value, checkout_dateTimePicker.Value);
                    habitationsTableAdapter.Fill(dispansery2DataSet.Habitations);
                }
                else
                {
                    habitationsTableAdapter.InsertQuery(clientID, Convert.ToInt32(rooms_comboBox.SelectedValue), 
                        reservation_dateTimePicker.Value, checkin_dateTimePicker.Value, checkout_dateTimePicker.Value);
                    habitationsTableAdapter.Fill(dispansery2DataSet.Habitations);
                }

                DateTime startDate = Convert.ToDateTime(dispansery2DataSet.Habitations[dispansery2DataSet.Habitations.Rows.Count - 1][4]);
                DateTime endDate = Convert.ToDateTime(dispansery2DataSet.Habitations[dispansery2DataSet.Habitations.Rows.Count - 1][5]);
                AccountHabitation = Convert.ToInt32((endDate - startDate).TotalDays) * GetPricePerDay();

                AddTreatments();
                for (int i = 0; i < treatmentHoursDict.Count; i++)
                {
                    selected_servicesTableAdapter.InsertQuery(Convert.ToInt32(dispansery2DataSet.Habitations[dispansery2DataSet.Habitations.Rows.Count - 1][0]),
                        treatmentHoursDict.Keys.ElementAt(i), treatmentHoursDict.Values.ElementAt(i));
                    //treatmentList.Add(dispansery2DataSet.Treatment.FindByTreatmentID(treatmentHoursDict.Keys.ElementAt(i))[1].ToString());
                    treatments += dispansery2DataSet.Treatment.FindByTreatmentID(treatmentHoursDict.Keys.ElementAt(i))[1].ToString();
                    //if
                    if(i < treatmentHoursDict.Count) treatments += ", ";
                }

                selected_servicesTableAdapter.Fill(dispansery2DataSet.Selected_services);

                accountsTableAdapter.InsertQuery(Convert.ToInt32(dispansery2DataSet.Habitations[dispansery2DataSet.Habitations.Rows.Count - 1][0]),
                    AccountHabitation, Convert.ToDecimal(AccountServices), GetDiscountID(), GetTotalSum(AccountHabitation + AccountServices));
                if(email_textbox.Text != string.Empty) SendEmail();
                MessageBox.Show("Success!");
                Close();
            }
            else if(surname_textbox.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you really sure to save changes?", "Dialog window", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    clientsTableAdapter.UpdateQuery(surname_textbox.Text, name_textbox.Text, patronymic_textbox.Text != string.Empty ? patronymic_textbox.Text : null,
                    birth_dateTimePicker.Value.ToString(), sex_comboBox.Text, address_textbox.Text, phone_textbox.Text,
                    citizenship_textbox.Text, passport_textbox.Text, email_textbox.Text != string.Empty ? email_textbox.Text : null, clientID);
                    clientsTableAdapter.Fill(dispansery2DataSet.Clients);
                    //dispansery2DataSet.AcceptChanges();
                    habitationsTableAdapter.UpdateQuery(Convert.ToInt32(rooms_comboBox.SelectedValue), reservation_dateTimePicker.Value,
                        checkin_dateTimePicker.Value, checkout_dateTimePicker.Value, clientID);
                    habitationsTableAdapter.Fill(dispansery2DataSet.Habitations);

                    GetHabitationRowIndex();
                    DateTime startDate = Convert.ToDateTime(dispansery2DataSet.Habitations[selectedRow - 1][4]);
                    DateTime endDate = Convert.ToDateTime(dispansery2DataSet.Habitations[selectedRow - 1][5]);
                    AccountHabitation = Convert.ToInt32((endDate - startDate).TotalDays) * GetPricePerDay();

                    treatmentHoursDict.Clear();
                    AddTreatments();
                    selected_servicesTableAdapter.DeleteQueryHab(habitationID);
                    for (int i = 0; i < treatmentHoursDict.Count; i++)
                    {
                        //selected_servicesTableAdapter.UpdateQuery(treatmentHoursDict.Keys.ElementAt(i), 
                        //    treatmentHoursDict.Values.ElementAt(i), habitationID);
                        //selected_servicesTableAdapter.Fill(dispansery2DataSet.Selected_services);
                        selected_servicesTableAdapter.InsertQuery(habitationID,
                            treatmentHoursDict.Keys.ElementAt(i), treatmentHoursDict.Values.ElementAt(i));
                    }
                    // dataset accept changes


                    accountsTableAdapter.UpdateQuery(AccountHabitation, Convert.ToDecimal(AccountServices),
                        GetDiscountID(), GetTotalSum(AccountHabitation + AccountServices), habitationID);
                    accountsTableAdapter.Fill(dispansery2DataSet.Accounts);
                    MessageBox.Show("Success!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Fill empty fields please.");
            }
        }

        private void AddTreatments()
        {
            
            for(int i = 0; i < treatment_dataGridView.Rows.Count; i++)
            {
                if (treatment_dataGridView.Rows[i].Cells[1].Value != null)
                {
                    //!!!!!!!!!!
                    treatmentHoursDict.Add(i, Convert.ToInt32(treatment_dataGridView.Rows[i].Cells[1].Value));
                    AccountServices += (Convert.ToInt32(treatment_dataGridView.Rows[i].Cells[1].Value) * Convert.ToInt32(dispansery2DataSet.Treatment.FindByTreatmentID(i).PricePerHour));
                }
            }

            /*foreach(KeyValuePair<string, int> i in treatmentHoursDict)
            {
                MessageBox.Show(i.Key, i.Value.ToString());
            }*/

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to close this window without saving?","Attention", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private int GetPricePerDay()
        {
            string sqlExpression = $"SELECT PricePerDay FROM [Room types] WHERE RoomTypeID = (SELECT RoomTypeCode FROM Rooms WHERE RoomID = {Convert.ToInt32(rooms_comboBox.Text)});";
            int PricePerDay = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                //command.ExecuteNonQuery();
                SqlDataReader thisReader = command.ExecuteReader();
                while (thisReader.Read())
                {
                    PricePerDay = Convert.ToInt32(thisReader["PricePerDay"]);
                }

                connection.Close();
            }

            return PricePerDay;
        }

        private int GetDiscountID()
        {
            string sqlExpression = $"SELECT DiscountID FROM Discounts WHERE DiscountType = '{discount_comboBox.Text}'";
            int discount = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader thisReader = command.ExecuteReader();
                while (thisReader.Read())
                {
                    discount = Convert.ToInt32(thisReader["DiscountID"]);
                }

                connection.Close();
            }

            return discount;
        }

        private decimal GetTotalSum(int accSum)
        {
            return  Convert.ToDecimal(accSum - accSum * (Convert.ToDouble(dispansery2DataSet.Discounts[GetDiscountID()][2]) / 100));
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            //int clientID;
            // поиск по базе данных после ввода в текстбокс есть ли человек с такой фамилией и если есть то подгрузить
            // его персональные в пустые поля, но при этом чтоб новый клиент не добавлялся
            if(name_textbox.Text.Length > 3 && surname_textbox.Text.Length > 3)
            {
                //clientsTableAdapter.GetDataBy1(surname_textbox.Text, name_textbox.Text);
                string sqlexpression = $"SELECT * FROM Clients WHERE Surname = '{surname_textbox.Text}' AND Name = '{name_textbox.Text}'";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlexpression, connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            clientID = reader.GetInt32(0);
                            if (!reader.IsDBNull(3))
                            {
                                patronymic_textbox.Text = reader.GetString(3);
                            }
                            birth_dateTimePicker.Value = reader.GetDateTime(4);
                            sex_comboBox.Text = reader.GetString(5);
                            address_textbox.Text = reader.GetString(6);
                            phone_textbox.Text = reader.GetString(7);
                            citizenship_textbox.Text = reader.GetString(8);
                            passport_textbox.Text = reader.GetString(9);
                            if (!reader.IsDBNull(10))
                            {
                                email_textbox.Text = reader.GetString(10);
                            }
                        }
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter full name and surname.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "only habitation")
            {
                check_button.Visible = true;
                newClient = false;
            }
            else
            {
                check_button.Visible = false;
                newClient = true;
            }
        }

        private void GetHabitationInfo()
        {
            string sqlexpHabitation = $"SELECT * FROM Habitations WHERE ClientCode = {clientID}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlexpHabitation, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        habitationID = reader.GetInt32(0);
                        rooms_comboBox.SelectedValue = reader.GetInt32(2);
                        try
                        {
                            reservation_dateTimePicker.Value = reader.GetDateTime(3);
                        }
                        catch
                        {

                        }

                        checkin_dateTimePicker.Value = reader.GetDateTime(4);
                        checkout_dateTimePicker.Value = reader.GetDateTime(5);
                    }
                }

                reader.Close();
                connection.Close();
            }
        }

        private void GetDiscountType()
        {
            string sqlexpression = $"SELECT DiscountType FROM Discounts WHERE DiscountID = (SELECT DiscountCode FROM Accounts WHERE HabitationCode = {habitationID})";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlexpression, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    discount_comboBox.SelectedValue = reader.GetString(0);
                }

                reader.Close();
                connection.Close();
            }
        }

        private void GetTreatmentInfo()
        {
            string sqlexpression = $"SELECT TreatmentCode, HoursAmount FROM [Selected services] WHERE HabitationCode = {habitationID}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlexpression, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    treatment_dataGridView[1, reader.GetInt32(0)].Value = reader.GetInt32(1);
                }

                reader.Close();
                connection.Close();
            }
            /*for(int i = 0; i < list.Count; i+=2)
            {
                for(int j = 0; j < treatment_dataGridView.Rows.Count; j++)
                {
                    if (list[i] == j)
                    {
                        treatment_dataGridView[1, j].Value = list[i + 1];
                    }
                }
                //treatment_dataGridView[0, ]
            }*/
        }

        private void GetHabitationRowIndex()
        {
            string sqlexpression = $"SELECT COUNT(ClientCode) FROM Habitations WHERE ClientCode <= {clientID};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlexpression, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    //habitationID = reader.GetInt32(0);
                    selectedRow = reader.GetInt32(0);
                }

                reader.Close();
                connection.Close();
            }
        }

        private void SendEmail()
        {
            MailAddress from = new MailAddress("oleksiy.salamatov@gmail.com", "Dispensary");
            MailAddress to = new MailAddress(email_textbox.Text);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Registration in Dispansery \"Оздоровчий\"";
            message.Body = 
                $"<p>You have successfully booked place in our Dispensary.<br>" +
                $"Your client number: {dispansery2DataSet.Clients[dispansery2DataSet.Clients.Rows.Count - 1][0]}<br>" +
                $"Habitation term: {checkin_dateTimePicker.Value} - {checkout_dateTimePicker.Value}<br>" +
                $"Room number and type: {rooms_comboBox.Text}, {dispansery2DataSet.Room_types.FindByRoomTypeID(dispansery2DataSet.Rooms.FindByRoomID(Convert.ToInt32(rooms_comboBox.SelectedValue)).RoomTypeCode).TypeName}<br>" +
                $"Selected services: {treatments}<br>" +
                $"Total sum: {dispansery2DataSet.Accounts[dispansery2DataSet.Accounts.Rows.Count - 1][5]}₴<br>" +
                $"<br>" +
                $"Thank you for choosing us!";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("oleksiy.salamatov@gmail.com", "udcdcftyvtfdgqpr");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }

        private void surname_textbox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidNames(surname_textbox.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(surname_textbox, errorMsg);
            }

            /*if (!Regex.IsMatch(surname_textbox.Text, @"^[а-яА-Я, іІ, їЇ]+$") && surname_textbox.Text != string.Empty)
            {
                e.Cancel = true;
                surname_textbox.Focus();
                errorProvider1.SetError(surname_textbox, "String must contain only letters!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(surname_textbox, "");
            }*/
        }

        private bool ValidNames(string name, out string errorMessage)
        {
            if (Regex.IsMatch(name, @"^[а-яА-Я, іІ, їЇ, єЄ]+$") || name == string.Empty)
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "String must contain only letters!";
            return false;
        }

        private void email_textbox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(email_textbox.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                //не разрешает переключится на другое поле пока не изменишь
                email_textbox.Select(0, email_textbox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(email_textbox, errorMsg);
            }
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1 && email_textbox.Text != string.Empty)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            if (emailAddress == string.Empty)
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void email_textbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(email_textbox, "");
        }

        private void reservation_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            reservationDate = true;
        }

        private void surname_textbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(surname_textbox, "");
        }

        private void name_textbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(name_textbox, "");
        }

        private void patronymic_textbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronymic_textbox, "");
        }

        private void name_textbox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidNames(name_textbox.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(name_textbox, errorMsg);
            }
        }

        private void patronymic_textbox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidNames(patronymic_textbox.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(patronymic_textbox, errorMsg);
            }
        }

        private void citizenship_textbox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidNames(citizenship_textbox.Text, out errorMsg))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(citizenship_textbox, errorMsg);
            }
        }

        private void treatment_dataGridView_Validating(object sender, CancelEventArgs e)
        {
            for(int i = 0; i < treatment_dataGridView.Rows.Count; i++)
            {
                if (treatment_dataGridView.Rows[i].Cells[1].Value != null)
                {
                    if (!Regex.IsMatch(treatment_dataGridView.Rows[i].Cells[1].Value.ToString(), @"^[0-9]+$"))
                    {
                        e.Cancel = true;
                        //email_textbox.Select(0, email_textbox.Text.Length);
                        // Set the ErrorProvider error with the text to display. 
                        this.errorProvider1.SetError(treatment_dataGridView, "You can write only numbers here.");
                        break;
                    }
                }
            }
        }

        private void treatment_dataGridView_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(treatment_dataGridView, "");
        }

        private void phone_textbox_Validating(object sender, CancelEventArgs e)
        {
            if (phone_textbox.Text != string.Empty && !Regex.IsMatch(phone_textbox.Text, @"^[0-9, +]+$"))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(phone_textbox, "Phone number must start with +");
            }
        }

        private void phone_textbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(phone_textbox, "");
        }

        private void checkin_dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if(checkin_dateTimePicker.Value < reservation_dateTimePicker.Value && reservationDate)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(checkout_dateTimePicker, "Check-in date must be greater than reservation one.");
            }
        }

        private void checkout_dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (checkout_dateTimePicker.Value < checkin_dateTimePicker.Value && checkinDateChanged)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(checkout_dateTimePicker, "Check-out date must be greater than check-in one.");
            }
        }
        
        private void checkout_dateTimePicker_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(checkout_dateTimePicker, "");
        }

        private void checkin_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            checkinDateChanged = true;
        }

        private void birth_dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (birth_dateTimePicker.Value > DateTime.Today)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(birth_dateTimePicker, "Birth date can't be later than current date.");
            }
        }

        private void birth_dateTimePicker_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(birth_dateTimePicker, "");
        }
    }
}
