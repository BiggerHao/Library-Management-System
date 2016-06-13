using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SQLite;

namespace LibraryManagementSystem
{
    public partial class LoginForm : MaterialForm
    {
        public static SQLiteConnection conn;

        public LoginForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
        
            // Connect to the database
            conn = new SQLiteConnection("Data Source = ..//..//SQL.db");
            conn.Open();
        
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginPwText_Enter(object sender, EventArgs e)
        {
            loginButton_Click(sender, e);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginNameText.Text.Equals("user") &&
                loginPwText.Text.Equals("user"))
            {
                Hide();
                new UserForm().Show();
            }
            else if (loginNameText.Text.Equals("root") &&
                loginPwText.Text.Equals("root"))
            {
                Hide();
                new AdminForm().Show();
            }
        }

        private void loginPwText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (loginNameText.Text.Equals("user") &&
                loginPwText.Text.Equals("user"))
                {
                    Hide();
                    new UserForm().Show();
                }
                else if (loginNameText.Text.Equals("root") &&
                loginPwText.Text.Equals("root"))
                {
                    Hide();
                    new AdminForm().Show();
                }
            }
        }
    }
}
