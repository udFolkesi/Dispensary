
namespace Dispensary2
{
    partial class EditingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            this.add_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dispansery2DataSet = new Dispensary2.Dispansery2DataSet();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.dataEditing_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roomTypes_button = new System.Windows.Forms.Button();
            this.rooms_button = new System.Windows.Forms.Button();
            this.discounts_button = new System.Windows.Forms.Button();
            this.habitations_button = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.clients_button = new System.Windows.Forms.Button();
            this.selectedServices_button = new System.Windows.Forms.Button();
            this.treatment_button = new System.Windows.Forms.Button();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.TreatmentTableAdapter();
            this.roomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_typesTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.Room_typesTableAdapter();
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.DiscountsTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.RoomsTableAdapter();
            this.habitationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitationsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.HabitationsTableAdapter();
            this.clientsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.ClientsTableAdapter();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.AccountsTableAdapter();
            this.selectedServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selected_servicesTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.Selected_servicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispansery2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedServicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.SkyBlue;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.ForeColor = System.Drawing.Color.Black;
            this.add_button.Location = new System.Drawing.Point(432, 48);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(97, 47);
            this.add_button.TabIndex = 23;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.citizenshipDataGridViewTextBoxColumn,
            this.passportNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(130, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(988, 436);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            // 
            // passportNumberDataGridViewTextBoxColumn
            // 
            this.passportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.HeaderText = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportNumberDataGridViewTextBoxColumn.Name = "passportNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // dispansery2DataSet
            // 
            this.dispansery2DataSet.DataSetName = "Dispansery2DataSet";
            this.dispansery2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.SkyBlue;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.ForeColor = System.Drawing.Color.Black;
            this.delete_button.Location = new System.Drawing.Point(670, 48);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(97, 47);
            this.delete_button.TabIndex = 21;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.SkyBlue;
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.ForeColor = System.Drawing.Color.Black;
            this.update_button.Location = new System.Drawing.Point(549, 48);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(97, 47);
            this.update_button.TabIndex = 20;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // dataEditing_label
            // 
            this.dataEditing_label.AutoSize = true;
            this.dataEditing_label.BackColor = System.Drawing.Color.RoyalBlue;
            this.dataEditing_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataEditing_label.ForeColor = System.Drawing.Color.White;
            this.dataEditing_label.Location = new System.Drawing.Point(531, 11);
            this.dataEditing_label.Name = "dataEditing_label";
            this.dataEditing_label.Size = new System.Drawing.Size(140, 24);
            this.dataEditing_label.TabIndex = 19;
            this.dataEditing_label.Text = "DATA EDITING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-72, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1306, 120);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // roomTypes_button
            // 
            this.roomTypes_button.BackColor = System.Drawing.Color.SkyBlue;
            this.roomTypes_button.FlatAppearance.BorderSize = 0;
            this.roomTypes_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.roomTypes_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomTypes_button.ForeColor = System.Drawing.Color.Black;
            this.roomTypes_button.Location = new System.Drawing.Point(24, 510);
            this.roomTypes_button.Name = "roomTypes_button";
            this.roomTypes_button.Size = new System.Drawing.Size(82, 35);
            this.roomTypes_button.TabIndex = 32;
            this.roomTypes_button.Text = "Room types";
            this.roomTypes_button.UseVisualStyleBackColor = false;
            this.roomTypes_button.Click += new System.EventHandler(this.roomTypes_button_Click);
            // 
            // rooms_button
            // 
            this.rooms_button.BackColor = System.Drawing.Color.SkyBlue;
            this.rooms_button.FlatAppearance.BorderSize = 0;
            this.rooms_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rooms_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_button.ForeColor = System.Drawing.Color.Black;
            this.rooms_button.Location = new System.Drawing.Point(24, 457);
            this.rooms_button.Name = "rooms_button";
            this.rooms_button.Size = new System.Drawing.Size(82, 35);
            this.rooms_button.TabIndex = 31;
            this.rooms_button.Text = "Rooms";
            this.rooms_button.UseVisualStyleBackColor = false;
            this.rooms_button.Click += new System.EventHandler(this.rooms_button_Click);
            // 
            // discounts_button
            // 
            this.discounts_button.BackColor = System.Drawing.Color.SkyBlue;
            this.discounts_button.FlatAppearance.BorderSize = 0;
            this.discounts_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.discounts_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discounts_button.ForeColor = System.Drawing.Color.Black;
            this.discounts_button.Location = new System.Drawing.Point(24, 404);
            this.discounts_button.Name = "discounts_button";
            this.discounts_button.Size = new System.Drawing.Size(82, 35);
            this.discounts_button.TabIndex = 30;
            this.discounts_button.Text = "Discounts";
            this.discounts_button.UseVisualStyleBackColor = false;
            this.discounts_button.Click += new System.EventHandler(this.discounts_button_Click);
            // 
            // habitations_button
            // 
            this.habitations_button.BackColor = System.Drawing.Color.SkyBlue;
            this.habitations_button.FlatAppearance.BorderSize = 0;
            this.habitations_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.habitations_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.habitations_button.ForeColor = System.Drawing.Color.Black;
            this.habitations_button.Location = new System.Drawing.Point(24, 351);
            this.habitations_button.Name = "habitations_button";
            this.habitations_button.Size = new System.Drawing.Size(82, 35);
            this.habitations_button.TabIndex = 29;
            this.habitations_button.Text = "Habitations";
            this.habitations_button.UseVisualStyleBackColor = false;
            this.habitations_button.Click += new System.EventHandler(this.habitations_button_Click);
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.Color.SkyBlue;
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.account_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.account_button.ForeColor = System.Drawing.Color.Black;
            this.account_button.Location = new System.Drawing.Point(24, 298);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(82, 35);
            this.account_button.TabIndex = 28;
            this.account_button.Text = "Accounts";
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // clients_button
            // 
            this.clients_button.BackColor = System.Drawing.Color.SkyBlue;
            this.clients_button.FlatAppearance.BorderSize = 0;
            this.clients_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clients_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients_button.ForeColor = System.Drawing.Color.Black;
            this.clients_button.Location = new System.Drawing.Point(24, 139);
            this.clients_button.Name = "clients_button";
            this.clients_button.Size = new System.Drawing.Size(82, 35);
            this.clients_button.TabIndex = 27;
            this.clients_button.Text = "Clients";
            this.clients_button.UseVisualStyleBackColor = false;
            this.clients_button.Click += new System.EventHandler(this.clients_button_Click);
            // 
            // selectedServices_button
            // 
            this.selectedServices_button.BackColor = System.Drawing.Color.SkyBlue;
            this.selectedServices_button.FlatAppearance.BorderSize = 0;
            this.selectedServices_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectedServices_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedServices_button.ForeColor = System.Drawing.Color.Black;
            this.selectedServices_button.Location = new System.Drawing.Point(24, 245);
            this.selectedServices_button.Name = "selectedServices_button";
            this.selectedServices_button.Size = new System.Drawing.Size(82, 35);
            this.selectedServices_button.TabIndex = 26;
            this.selectedServices_button.Text = "Selected Services";
            this.selectedServices_button.UseVisualStyleBackColor = false;
            this.selectedServices_button.Click += new System.EventHandler(this.selectedServices_button_Click);
            // 
            // treatment_button
            // 
            this.treatment_button.BackColor = System.Drawing.Color.SkyBlue;
            this.treatment_button.FlatAppearance.BorderSize = 0;
            this.treatment_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.treatment_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treatment_button.ForeColor = System.Drawing.Color.Black;
            this.treatment_button.Location = new System.Drawing.Point(24, 192);
            this.treatment_button.Name = "treatment_button";
            this.treatment_button.Size = new System.Drawing.Size(82, 35);
            this.treatment_button.TabIndex = 25;
            this.treatment_button.Text = "Treatment";
            this.treatment_button.UseVisualStyleBackColor = false;
            this.treatment_button.Click += new System.EventHandler(this.treatment_button_Click);
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // roomTypesBindingSource
            // 
            this.roomTypesBindingSource.DataMember = "Room types";
            this.roomTypesBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // room_typesTableAdapter
            // 
            this.room_typesTableAdapter.ClearBeforeFill = true;
            // 
            // discountsBindingSource
            // 
            this.discountsBindingSource.DataMember = "Discounts";
            this.discountsBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // habitationsBindingSource
            // 
            this.habitationsBindingSource.DataMember = "Habitations";
            this.habitationsBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // habitationsTableAdapter
            // 
            this.habitationsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // selectedServicesBindingSource
            // 
            this.selectedServicesBindingSource.DataMember = "Selected services";
            this.selectedServicesBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // selected_servicesTableAdapter
            // 
            this.selected_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 587);
            this.Controls.Add(this.roomTypes_button);
            this.Controls.Add(this.rooms_button);
            this.Controls.Add(this.discounts_button);
            this.Controls.Add(this.habitations_button);
            this.Controls.Add(this.account_button);
            this.Controls.Add(this.clients_button);
            this.Controls.Add(this.selectedServices_button);
            this.Controls.Add(this.treatment_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dataEditing_label);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditingForm";
            this.Text = "EditingForm";
            this.Load += new System.EventHandler(this.EditingForm_Load);
            this.MouseEnter += new System.EventHandler(this.EditingForm_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispansery2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedServicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label dataEditing_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Dispansery2DataSet dispansery2DataSet;
        private System.Windows.Forms.Button roomTypes_button;
        private System.Windows.Forms.Button rooms_button;
        private System.Windows.Forms.Button discounts_button;
        private System.Windows.Forms.Button habitations_button;
        private System.Windows.Forms.Button account_button;
        private System.Windows.Forms.Button clients_button;
        private System.Windows.Forms.Button selectedServices_button;
        private System.Windows.Forms.Button treatment_button;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private Dispansery2DataSetTableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.BindingSource roomTypesBindingSource;
        private Dispansery2DataSetTableAdapters.Room_typesTableAdapter room_typesTableAdapter;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private Dispansery2DataSetTableAdapters.DiscountsTableAdapter discountsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Dispansery2DataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource habitationsBindingSource;
        private Dispansery2DataSetTableAdapters.HabitationsTableAdapter habitationsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Dispansery2DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Dispansery2DataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource selectedServicesBindingSource;
        private Dispansery2DataSetTableAdapters.Selected_servicesTableAdapter selected_servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}