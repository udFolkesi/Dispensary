
namespace Dispensary2
{
    partial class ViewingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewingForm));
            this.tableView_dataGridView = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            this.treatment_button = new System.Windows.Forms.Button();
            this.selectedServices_button = new System.Windows.Forms.Button();
            this.clients_button = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.habitations_button = new System.Windows.Forms.Button();
            this.discounts_button = new System.Windows.Forms.Button();
            this.rooms_button = new System.Windows.Forms.Button();
            this.roomTypes_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_label = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dispansery2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableName_label = new System.Windows.Forms.Label();
            this.filter_comboBox = new System.Windows.Forms.ComboBox();
            this.treatmentTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.TreatmentTableAdapter();
            this.discountsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.DiscountsTableAdapter();
            this.roomsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.RoomsTableAdapter();
            this.clientsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.ClientsTableAdapter();
            this.habitationsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.HabitationsTableAdapter();
            this.habitationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_typesTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.Room_typesTableAdapter();
            this.selectedServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selected_servicesTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.Selected_servicesTableAdapter();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Dispensary2.Dispansery2DataSetTableAdapters.AccountsTableAdapter();
            this.getCheck_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ascending_radioButton = new System.Windows.Forms.RadioButton();
            this.descending_radioButton = new System.Windows.Forms.RadioButton();
            this.columns_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filter_checkedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableView_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispansery2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispansery2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableView_dataGridView
            // 
            this.tableView_dataGridView.AllowUserToAddRows = false;
            this.tableView_dataGridView.AllowUserToDeleteRows = false;
            this.tableView_dataGridView.AutoGenerateColumns = false;
            this.tableView_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableView_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tableView_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.tableView_dataGridView.DataSource = this.clientsBindingSource;
            this.tableView_dataGridView.Location = new System.Drawing.Point(220, 176);
            this.tableView_dataGridView.Name = "tableView_dataGridView";
            this.tableView_dataGridView.ReadOnly = true;
            this.tableView_dataGridView.RowHeadersWidth = 51;
            this.tableView_dataGridView.RowTemplate.Height = 24;
            this.tableView_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableView_dataGridView.Size = new System.Drawing.Size(939, 391);
            this.tableView_dataGridView.TabIndex = 0;
            this.tableView_dataGridView.DataSourceChanged += new System.EventHandler(this.tableView_dataGridView_DataSourceChanged);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 94;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            this.patronymicDataGridViewTextBoxColumn.Width = 107;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 111;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 60;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 89;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 128;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            this.citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            this.citizenshipDataGridViewTextBoxColumn.Width = 105;
            // 
            // passportNumberDataGridViewTextBoxColumn
            // 
            this.passportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.HeaderText = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportNumberDataGridViewTextBoxColumn.Name = "passportNumberDataGridViewTextBoxColumn";
            this.passportNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportNumberDataGridViewTextBoxColumn.Width = 143;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 71;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIEWING INFORMATION";
            // 
            // treatment_button
            // 
            this.treatment_button.BackColor = System.Drawing.Color.SkyBlue;
            this.treatment_button.FlatAppearance.BorderSize = 0;
            this.treatment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treatment_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treatment_button.ForeColor = System.Drawing.Color.Black;
            this.treatment_button.Location = new System.Drawing.Point(236, 48);
            this.treatment_button.Name = "treatment_button";
            this.treatment_button.Size = new System.Drawing.Size(97, 47);
            this.treatment_button.TabIndex = 2;
            this.treatment_button.Text = "Treatment";
            this.treatment_button.UseVisualStyleBackColor = false;
            this.treatment_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectedServices_button
            // 
            this.selectedServices_button.BackColor = System.Drawing.Color.SkyBlue;
            this.selectedServices_button.FlatAppearance.BorderSize = 0;
            this.selectedServices_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedServices_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedServices_button.ForeColor = System.Drawing.Color.Black;
            this.selectedServices_button.Location = new System.Drawing.Point(364, 48);
            this.selectedServices_button.Name = "selectedServices_button";
            this.selectedServices_button.Size = new System.Drawing.Size(97, 47);
            this.selectedServices_button.TabIndex = 3;
            this.selectedServices_button.Text = "Selected Services";
            this.selectedServices_button.UseVisualStyleBackColor = false;
            this.selectedServices_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // clients_button
            // 
            this.clients_button.BackColor = System.Drawing.Color.SkyBlue;
            this.clients_button.FlatAppearance.BorderSize = 0;
            this.clients_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clients_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients_button.ForeColor = System.Drawing.Color.Black;
            this.clients_button.Location = new System.Drawing.Point(116, 48);
            this.clients_button.Name = "clients_button";
            this.clients_button.Size = new System.Drawing.Size(97, 47);
            this.clients_button.TabIndex = 4;
            this.clients_button.Text = "Clients";
            this.clients_button.UseVisualStyleBackColor = false;
            this.clients_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.Color.SkyBlue;
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.account_button.ForeColor = System.Drawing.Color.Black;
            this.account_button.Location = new System.Drawing.Point(487, 48);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(97, 47);
            this.account_button.TabIndex = 5;
            this.account_button.Text = "Accounts";
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // habitations_button
            // 
            this.habitations_button.BackColor = System.Drawing.Color.SkyBlue;
            this.habitations_button.FlatAppearance.BorderSize = 0;
            this.habitations_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habitations_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.habitations_button.ForeColor = System.Drawing.Color.Black;
            this.habitations_button.Location = new System.Drawing.Point(612, 48);
            this.habitations_button.Name = "habitations_button";
            this.habitations_button.Size = new System.Drawing.Size(97, 47);
            this.habitations_button.TabIndex = 6;
            this.habitations_button.Text = "Habitations";
            this.habitations_button.UseVisualStyleBackColor = false;
            this.habitations_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // discounts_button
            // 
            this.discounts_button.BackColor = System.Drawing.Color.SkyBlue;
            this.discounts_button.FlatAppearance.BorderSize = 0;
            this.discounts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discounts_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discounts_button.ForeColor = System.Drawing.Color.Black;
            this.discounts_button.Location = new System.Drawing.Point(745, 48);
            this.discounts_button.Name = "discounts_button";
            this.discounts_button.Size = new System.Drawing.Size(97, 47);
            this.discounts_button.TabIndex = 7;
            this.discounts_button.Text = "Discounts";
            this.discounts_button.UseVisualStyleBackColor = false;
            this.discounts_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // rooms_button
            // 
            this.rooms_button.BackColor = System.Drawing.Color.SkyBlue;
            this.rooms_button.FlatAppearance.BorderSize = 0;
            this.rooms_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_button.ForeColor = System.Drawing.Color.Black;
            this.rooms_button.Location = new System.Drawing.Point(865, 48);
            this.rooms_button.Name = "rooms_button";
            this.rooms_button.Size = new System.Drawing.Size(97, 47);
            this.rooms_button.TabIndex = 8;
            this.rooms_button.Text = "Rooms";
            this.rooms_button.UseVisualStyleBackColor = false;
            this.rooms_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // roomTypes_button
            // 
            this.roomTypes_button.BackColor = System.Drawing.Color.SkyBlue;
            this.roomTypes_button.FlatAppearance.BorderSize = 0;
            this.roomTypes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomTypes_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomTypes_button.ForeColor = System.Drawing.Color.Black;
            this.roomTypes_button.Location = new System.Drawing.Point(990, 48);
            this.roomTypes_button.Name = "roomTypes_button";
            this.roomTypes_button.Size = new System.Drawing.Size(97, 47);
            this.roomTypes_button.TabIndex = 9;
            this.roomTypes_button.Text = "Room types";
            this.roomTypes_button.UseVisualStyleBackColor = false;
            this.roomTypes_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-58, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1306, 120);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(83, 146);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(53, 17);
            this.search_label.TabIndex = 11;
            this.search_label.Text = "Search";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(24, 178);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(140, 22);
            this.search_textbox.TabIndex = 12;
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(170, 178);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(27, 22);
            this.search_button.TabIndex = 13;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            this.search_button.MouseEnter += new System.EventHandler(this.search_button_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filters";
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.dispansery2DataSetBindingSource;
            // 
            // dispansery2DataSetBindingSource
            // 
            this.dispansery2DataSetBindingSource.DataSource = this.dispansery2DataSet;
            this.dispansery2DataSetBindingSource.Position = 0;
            // 
            // roomTypesBindingSource
            // 
            this.roomTypesBindingSource.DataMember = "Room types";
            this.roomTypesBindingSource.DataSource = this.dispansery2DataSetBindingSource;
            // 
            // discountsBindingSource
            // 
            this.discountsBindingSource.DataMember = "Discounts";
            this.discountsBindingSource.DataSource = this.dispansery2DataSetBindingSource;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.dispansery2DataSetBindingSource;
            // 
            // tableName_label
            // 
            this.tableName_label.AutoSize = true;
            this.tableName_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableName_label.Location = new System.Drawing.Point(658, 136);
            this.tableName_label.Name = "tableName_label";
            this.tableName_label.Size = new System.Drawing.Size(68, 20);
            this.tableName_label.TabIndex = 15;
            this.tableName_label.Text = "Clients";
            // 
            // filter_comboBox
            // 
            this.filter_comboBox.FormattingEnabled = true;
            this.filter_comboBox.Items.AddRange(new object[] {
            "ClientID",
            "Surname",
            "Name",
            "Patronymic",
            "DateOfBirth",
            "Sex",
            "Address",
            "PhoneNumber",
            "Citizenship",
            "PassportNumber",
            "Email"});
            this.filter_comboBox.Location = new System.Drawing.Point(43, 247);
            this.filter_comboBox.Name = "filter_comboBox";
            this.filter_comboBox.Size = new System.Drawing.Size(121, 24);
            this.filter_comboBox.TabIndex = 16;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // habitationsTableAdapter
            // 
            this.habitationsTableAdapter.ClearBeforeFill = true;
            // 
            // habitationsBindingSource
            // 
            this.habitationsBindingSource.DataMember = "Habitations";
            this.habitationsBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // room_typesTableAdapter
            // 
            this.room_typesTableAdapter.ClearBeforeFill = true;
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
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dispansery2DataSet;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // getCheck_button
            // 
            this.getCheck_button.Location = new System.Drawing.Point(60, 448);
            this.getCheck_button.Name = "getCheck_button";
            this.getCheck_button.Size = new System.Drawing.Size(91, 44);
            this.getCheck_button.TabIndex = 17;
            this.getCheck_button.Text = "Get check";
            this.getCheck_button.UseVisualStyleBackColor = true;
            this.getCheck_button.Click += new System.EventHandler(this.getCheck_button_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Report for last month";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ascending_radioButton
            // 
            this.ascending_radioButton.AutoSize = true;
            this.ascending_radioButton.Location = new System.Drawing.Point(1060, 126);
            this.ascending_radioButton.Name = "ascending_radioButton";
            this.ascending_radioButton.Size = new System.Drawing.Size(95, 21);
            this.ascending_radioButton.TabIndex = 21;
            this.ascending_radioButton.TabStop = true;
            this.ascending_radioButton.Text = "Ascending";
            this.ascending_radioButton.UseVisualStyleBackColor = true;
            this.ascending_radioButton.CheckedChanged += new System.EventHandler(this.ascending_radioButton_CheckedChanged);
            // 
            // descending_radioButton
            // 
            this.descending_radioButton.AutoSize = true;
            this.descending_radioButton.Location = new System.Drawing.Point(1060, 148);
            this.descending_radioButton.Name = "descending_radioButton";
            this.descending_radioButton.Size = new System.Drawing.Size(104, 21);
            this.descending_radioButton.TabIndex = 22;
            this.descending_radioButton.TabStop = true;
            this.descending_radioButton.Text = "Descending";
            this.descending_radioButton.UseVisualStyleBackColor = true;
            this.descending_radioButton.CheckedChanged += new System.EventHandler(this.descending_radioButton_CheckedChanged);
            // 
            // columns_comboBox
            // 
            this.columns_comboBox.FormattingEnabled = true;
            this.columns_comboBox.Items.AddRange(new object[] {
            "ClientID",
            "Surname",
            "Name",
            "Patronymic",
            "DateOfBirth",
            "Sex",
            "Address",
            "PhoneNumber",
            "Citizenship",
            "PassportNumber",
            "Email"});
            this.columns_comboBox.Location = new System.Drawing.Point(933, 143);
            this.columns_comboBox.Name = "columns_comboBox";
            this.columns_comboBox.Size = new System.Drawing.Size(121, 24);
            this.columns_comboBox.TabIndex = 23;
            this.columns_comboBox.Text = "ClientID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(969, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Column";
            // 
            // filter_checkedListBox
            // 
            this.filter_checkedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.filter_checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filter_checkedListBox.CheckOnClick = true;
            this.filter_checkedListBox.FormattingEnabled = true;
            this.filter_checkedListBox.Items.AddRange(new object[] {
            "Patronymic",
            "DateOfBirth",
            "Sex",
            "Address",
            "PhoneNumber",
            "Citizenship",
            "PassportNumber",
            "Email"});
            this.filter_checkedListBox.Location = new System.Drawing.Point(43, 289);
            this.filter_checkedListBox.Name = "filter_checkedListBox";
            this.filter_checkedListBox.Size = new System.Drawing.Size(121, 136);
            this.filter_checkedListBox.TabIndex = 25;
            this.filter_checkedListBox.SelectedIndexChanged += new System.EventHandler(this.filter_checkedListBox_SelectedIndexChanged);
            // 
            // ViewingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 608);
            this.Controls.Add(this.filter_checkedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.columns_comboBox);
            this.Controls.Add(this.descending_radioButton);
            this.Controls.Add(this.ascending_radioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getCheck_button);
            this.Controls.Add(this.filter_comboBox);
            this.Controls.Add(this.tableName_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.roomTypes_button);
            this.Controls.Add(this.rooms_button);
            this.Controls.Add(this.discounts_button);
            this.Controls.Add(this.habitations_button);
            this.Controls.Add(this.account_button);
            this.Controls.Add(this.clients_button);
            this.Controls.Add(this.selectedServices_button);
            this.Controls.Add(this.treatment_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableView_dataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewingForm";
            this.Text = "View";
            this.Load += new System.EventHandler(this.ViewingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableView_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispansery2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispansery2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableView_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button treatment_button;
        private System.Windows.Forms.Button selectedServices_button;
        private System.Windows.Forms.Button clients_button;
        private System.Windows.Forms.Button account_button;
        private System.Windows.Forms.Button habitations_button;
        private System.Windows.Forms.Button discounts_button;
        private System.Windows.Forms.Button rooms_button;
        private System.Windows.Forms.Button roomTypes_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dispansery2DataSetBindingSource;
        private Dispansery2DataSet dispansery2DataSet;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private Dispansery2DataSetTableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private Dispansery2DataSetTableAdapters.DiscountsTableAdapter discountsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Dispansery2DataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomTypesBindingSource;
        private Dispansery2DataSetTableAdapters.Room_typesTableAdapter room_typesTableAdapter;
        private System.Windows.Forms.Label tableName_label;
        private System.Windows.Forms.ComboBox filter_comboBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Dispansery2DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource habitationsBindingSource;
        private Dispansery2DataSetTableAdapters.HabitationsTableAdapter habitationsTableAdapter;
        private System.Windows.Forms.BindingSource selectedServicesBindingSource;
        private Dispansery2DataSetTableAdapters.Selected_servicesTableAdapter selected_servicesTableAdapter;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Dispansery2DataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
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
        private System.Windows.Forms.Button getCheck_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ascending_radioButton;
        private System.Windows.Forms.RadioButton descending_radioButton;
        private System.Windows.Forms.ComboBox columns_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox filter_checkedListBox;
    }
}