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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = loginNameText.Text;
            string pwd = loginPwText.Text;
            string name = null;
            string type = null;

            SQLiteCommand comm = new SQLiteCommand("select user_name, user_type from User where user_id = '" +
                id + "' and user_pwd = '" + pwd + "';", conn);
            SQLiteDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                name = read["user_name"].ToString();
                type = read["user_type"].ToString();
            }

            comm.Dispose();
            read.Dispose();

            if (name != null)
            {
                if (type.Equals("管理员")) { Hide(); new AdminForm().Show(); }
                else if (type.Equals("读者")) { Hide(); new UserForm().Show(); }
            }
            else
                MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void loginPwText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) loginButton_Click(null, null);
        }

        private void loginNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }
    }
}
