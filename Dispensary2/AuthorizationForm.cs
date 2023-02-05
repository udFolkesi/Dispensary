using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispensary2
{
    public partial class AuthorizationForm : Form
    {
        bool vis = true;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(logIn_textbox.Text == "admin" && password_textbox.Text == "admin")
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("Неправильно введно логін або пароль");
            }
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            if(vis == true)
            {
                password_textbox.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = true;
                vis = true;
            }
        }
    }
}
