
namespace Dispensary2
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomTypes_button = new System.Windows.Forms.Button();
            this.medicalSrevices_button = new System.Windows.Forms.Button();
            this.discoutTypes_button = new System.Windows.Forms.Button();
            this.treatmentAccounts_button = new System.Windows.Forms.Button();
            this.statisticsName_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-13, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1245, 131);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "STATISTICS";
            // 
            // roomTypes_button
            // 
            this.roomTypes_button.BackColor = System.Drawing.Color.SkyBlue;
            this.roomTypes_button.FlatAppearance.BorderSize = 0;
            this.roomTypes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomTypes_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomTypes_button.ForeColor = System.Drawing.Color.Black;
            this.roomTypes_button.Location = new System.Drawing.Point(291, 44);
            this.roomTypes_button.Name = "roomTypes_button";
            this.roomTypes_button.Size = new System.Drawing.Size(157, 64);
            this.roomTypes_button.TabIndex = 22;
            this.roomTypes_button.Text = "The most popular room types";
            this.roomTypes_button.UseVisualStyleBackColor = false;
            this.roomTypes_button.Click += new System.EventHandler(this.roomTypes_button_Click);
            // 
            // medicalSrevices_button
            // 
            this.medicalSrevices_button.BackColor = System.Drawing.Color.SkyBlue;
            this.medicalSrevices_button.FlatAppearance.BorderSize = 0;
            this.medicalSrevices_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicalSrevices_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicalSrevices_button.ForeColor = System.Drawing.Color.Black;
            this.medicalSrevices_button.Location = new System.Drawing.Point(465, 44);
            this.medicalSrevices_button.Name = "medicalSrevices_button";
            this.medicalSrevices_button.Size = new System.Drawing.Size(157, 64);
            this.medicalSrevices_button.TabIndex = 23;
            this.medicalSrevices_button.Text = "The most popular medical services";
            this.medicalSrevices_button.UseVisualStyleBackColor = false;
            this.medicalSrevices_button.Click += new System.EventHandler(this.medicalServices_button_Click);
            // 
            // discoutTypes_button
            // 
            this.discoutTypes_button.BackColor = System.Drawing.Color.SkyBlue;
            this.discoutTypes_button.FlatAppearance.BorderSize = 0;
            this.discoutTypes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discoutTypes_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discoutTypes_button.ForeColor = System.Drawing.Color.Black;
            this.discoutTypes_button.Location = new System.Drawing.Point(635, 44);
            this.discoutTypes_button.Name = "discoutTypes_button";
            this.discoutTypes_button.Size = new System.Drawing.Size(157, 64);
            this.discoutTypes_button.TabIndex = 24;
            this.discoutTypes_button.Text = "The most popular discount types";
            this.discoutTypes_button.UseVisualStyleBackColor = false;
            this.discoutTypes_button.Click += new System.EventHandler(this.discountTypes_button_Click);
            // 
            // treatmentAccounts_button
            // 
            this.treatmentAccounts_button.BackColor = System.Drawing.Color.SkyBlue;
            this.treatmentAccounts_button.FlatAppearance.BorderSize = 0;
            this.treatmentAccounts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treatmentAccounts_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treatmentAccounts_button.ForeColor = System.Drawing.Color.Black;
            this.treatmentAccounts_button.Location = new System.Drawing.Point(805, 44);
            this.treatmentAccounts_button.Name = "treatmentAccounts_button";
            this.treatmentAccounts_button.Size = new System.Drawing.Size(157, 64);
            this.treatmentAccounts_button.TabIndex = 25;
            this.treatmentAccounts_button.Text = "The largest treatment accounts";
            this.treatmentAccounts_button.UseVisualStyleBackColor = false;
            this.treatmentAccounts_button.Click += new System.EventHandler(this.treatmentAccounts_button_Click);
            // 
            // statisticsName_label
            // 
            this.statisticsName_label.AutoSize = true;
            this.statisticsName_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsName_label.Location = new System.Drawing.Point(482, 152);
            this.statisticsName_label.Name = "statisticsName_label";
            this.statisticsName_label.Size = new System.Drawing.Size(0, 20);
            this.statisticsName_label.TabIndex = 26;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 608);
            this.Controls.Add(this.statisticsName_label);
            this.Controls.Add(this.treatmentAccounts_button);
            this.Controls.Add(this.discoutTypes_button);
            this.Controls.Add(this.medicalSrevices_button);
            this.Controls.Add(this.roomTypes_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roomTypes_button;
        private System.Windows.Forms.Button medicalSrevices_button;
        private System.Windows.Forms.Button discoutTypes_button;
        private System.Windows.Forms.Button treatmentAccounts_button;
        private System.Windows.Forms.Label statisticsName_label;
    }
}