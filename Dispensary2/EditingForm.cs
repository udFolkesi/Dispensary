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
    public partial class EditingForm : Form
    {
        public EditingForm()
        {
            InitializeComponent();
        }

        private bool refresh = false;

        private void EditingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dispansery2DataSet.Selected_services' table. You can move, or remove it, as needed.
            this.selected_servicesTableAdapter.Fill(this.dispansery2DataSet.Selected_services);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dispansery2DataSet.Clients);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Habitations' table. You can move, or remove it, as needed.
            this.habitationsTableAdapter.Fill(this.dispansery2DataSet.Habitations);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.dispansery2DataSet.Rooms);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Discounts' table. You can move, or remove it, as needed.
            this.discountsTableAdapter.Fill(this.dispansery2DataSet.Discounts);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Room_types' table. You can move, or remove it, as needed.
            this.room_typesTableAdapter.Fill(this.dispansery2DataSet.Room_types);
            // TODO: This line of code loads data into the 'dispansery2DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.dispansery2DataSet.Treatment);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void roomTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
            refresh = true;
        }

        //private Dictionary<>
        private int habitationID = 0;

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Dialog Window", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.DataSource == treatmentBindingSource)
                {
                    //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        treatmentTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        treatmentTableAdapter.Fill(dispansery2DataSet.Treatment);
                        dispansery2DataSet.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this item as it's already used\n in another table!", "Warning", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show();
                    }
                }

                if (dataGridView1.DataSource == roomTypesBindingSource)
                {
                    try
                    {
                        room_typesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        room_typesTableAdapter.Fill(dispansery2DataSet.Room_types);
                        dispansery2DataSet.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this item as it's already used in another table!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (dataGridView1.DataSource == discountsBindingSource)
                {
                    try
                    {
                        discountsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        discountsTableAdapter.Fill(dispansery2DataSet.Discounts);
                        dispansery2DataSet.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this item as it's already used in another table!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (dataGridView1.DataSource == accountsBindingSource)
                {
                    accountsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
                    accountsTableAdapter.Fill(dispansery2DataSet.Accounts);
                    dispansery2DataSet.AcceptChanges();
                }

                if(dataGridView1.DataSource == roomsBindingSource)
                {
                    try
                    {
                        roomsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                        roomsTableAdapter.Fill(dispansery2DataSet.Rooms);
                        dispansery2DataSet.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("You can't delete this item as it's already used in another table!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if(dataGridView1.DataSource == selectedServicesBindingSource)
                {
                    //int habitID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                    selected_servicesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    selected_servicesTableAdapter.Fill(dispansery2DataSet.Selected_services);
                    dispansery2DataSet.AcceptChanges();
                    //EditForm editForm = new EditForm();
                    //accountsTableAdapter.UpdateQuery(AccountHabitation, Convert.ToDecimal(AccountServices),
                    //    GetDiscountID(), GetTotalSum(AccountHabitation + AccountServices), habitID);
                    //accountsTableAdapter.Fill(dispansery2DataSet.Accounts);

                }

                if(dataGridView1.DataSource == habitationsBindingSource)
                {
                    accountsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    accountsTableAdapter.Fill(dispansery2DataSet.Accounts);
                    dispansery2DataSet.AcceptChanges();
                    selected_servicesTableAdapter.DeleteQueryHab(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    selected_servicesTableAdapter.Fill(dispansery2DataSet.Selected_services);
                    dispansery2DataSet.AcceptChanges();
                    habitationsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    habitationsTableAdapter.Fill(dispansery2DataSet.Habitations);
                    dispansery2DataSet.AcceptChanges();
                }

                if (dataGridView1.DataSource == clientsBindingSource)
                {
                    GetHabitationID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    accountsTableAdapter.DeleteQuery(habitationID);
                    accountsTableAdapter.Fill(dispansery2DataSet.Accounts);
                    dispansery2DataSet.AcceptChanges();
                    selected_servicesTableAdapter.DeleteQueryHab(habitationID);
                    selected_servicesTableAdapter.Fill(dispansery2DataSet.Selected_services);
                    dispansery2DataSet.AcceptChanges();
                    habitationsTableAdapter.DeleteQuery(habitationID);
                    habitationsTableAdapter.Fill(dispansery2DataSet.Habitations);
                    dispansery2DataSet.AcceptChanges();
                    clientsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    clientsTableAdapter.Fill(dispansery2DataSet.Clients);
                    dispansery2DataSet.AcceptChanges();
                }
            }
        }

        private void treatment_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = treatmentBindingSource;
        }

        private void roomTypes_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = roomTypesBindingSource;
        }

        private void discounts_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = discountsBindingSource;
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accountsBindingSource;
        }

        private void clients_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientsBindingSource;
        }

        private void rooms_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = roomsBindingSource;
        }

        private void habitations_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = habitationsBindingSource;
        }

        private void selectedServices_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = selectedServicesBindingSource;
        }

        private void EditingForm_MouseEnter(object sender, EventArgs e)
        {
            if (refresh)
            {
                this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
                this.clientsTableAdapter.Fill(this.dispansery2DataSet.Clients);
                this.selected_servicesTableAdapter.Fill(this.dispansery2DataSet.Selected_services);
                this.habitationsTableAdapter.Fill(this.dispansery2DataSet.Habitations);
                this.roomsTableAdapter.Fill(this.dispansery2DataSet.Rooms);
                this.discountsTableAdapter.Fill(this.dispansery2DataSet.Discounts);
                this.room_typesTableAdapter.Fill(this.dispansery2DataSet.Room_types);
                this.treatmentTableAdapter.Fill(this.dispansery2DataSet.Treatment);
                refresh = false;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            refresh = true;
            List<object> rowList = new List<object>();
            for(int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                rowList.Add(dataGridView1.CurrentRow.Cells[i].Value);
            }

            EditForm editForm = new EditForm(Convert.ToInt32(rowList[0]), rowList[1].ToString(), rowList[2].ToString(), 
                rowList[3].ToString(), Convert.ToDateTime(rowList[4]), rowList[5].ToString(), rowList[6].ToString(), 
                rowList[7].ToString(), rowList[8].ToString(), rowList[9].ToString(), rowList[10].ToString());
            editForm.ShowDialog();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            if (refresh)
            {
                this.accountsTableAdapter.Fill(this.dispansery2DataSet.Accounts);
                this.clientsTableAdapter.Fill(this.dispansery2DataSet.Clients);
                this.selected_servicesTableAdapter.Fill(this.dispansery2DataSet.Selected_services);
                this.habitationsTableAdapter.Fill(this.dispansery2DataSet.Habitations);
                this.roomsTableAdapter.Fill(this.dispansery2DataSet.Rooms);
                this.discountsTableAdapter.Fill(this.dispansery2DataSet.Discounts);
                this.room_typesTableAdapter.Fill(this.dispansery2DataSet.Room_types);
                this.treatmentTableAdapter.Fill(this.dispansery2DataSet.Treatment);
                refresh = false;
            }
        }

        private void GetHabitationID(int clientID)
        {
            string ConnectionString = @"Data Source=DESKTOP-C6I6F3P\SQLEXPRESS;Initial Catalog=Dispansery2;Integrated Security=True";
            string sqlexpHabitation = $"SELECT HabitationID FROM Habitations WHERE ClientCode = {clientID}";
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
                    }
                }

                reader.Close();
                connection.Close();
            }
        }
    }
}
