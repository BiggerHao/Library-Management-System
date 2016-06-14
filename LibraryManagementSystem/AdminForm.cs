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
    public partial class AdminForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public AdminForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialRaisedButton1.Enabled = false;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton3.Enabled = false;

            // Add dummy data to the listview
            seedListView();
        }

        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"13061050", "C1798399", "管理员前台", "2016-06-13 19:55:20"},
                new []{"13066666", "C6666666", "大门门禁", "2016-06-13 20:01:48"}
            };

            //SQLiteCommand comm = new SQLiteCommand("select * from Book, BookEpc where ");




            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                borrowReturnList.Items.Add(item);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialRaisedButton1.Enabled = false;
            materialRaisedButton2.Enabled = true;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialRaisedButton1.Enabled = true;
            materialRaisedButton2.Enabled = false;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton3.Enabled = false;
            materialRaisedButton4.Enabled = true;
            materialRaisedButton5.Enabled = true;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            materialRaisedButton3.Enabled = true;
            materialRaisedButton4.Enabled = false;
            materialRaisedButton5.Enabled = true;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton3.Enabled = true;
            materialRaisedButton4.Enabled = true;
            materialRaisedButton5.Enabled = false;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            status_page1.Text = "";
            
            bool isBorrow = borrowRadioButton.Checked ? true : false;

            string user_id = userIDText.Text;
            string book_epc = bookEPCText.Text;
            if (user_id.Equals("") || book_epc.Equals(""))
            {
                status_page1.Text = "请完整填写信息";
                return;
            }

            if (isBorrow)
            {
                // Check user ID
                SQLiteCommand comm = new SQLiteCommand("select * from User where user_id = '"
                    + user_id + "'", LoginForm.conn);
                SQLiteDataReader read = comm.ExecuteReader();
                bool valid = false;
                while (read.Read()) valid = true;
                if (!valid)
                {
                    status_page1.Text = "无效的用户ID";
                    comm.Dispose();
                    read.Dispose();
                    return;
                }
                comm.Dispose();
                read.Dispose();

                // Check book EPC
                comm = new SQLiteCommand("select * from BookEPC where book_epc = '" + book_epc
                    + "'", LoginForm.conn);
                read = comm.ExecuteReader();
                valid = false;
                while (read.Read())
                {
                    int isBorrowed = (int)read["isBorrowed"];
                    if (isBorrowed == 1)
                    {
                        status_page1.Text = "图书已借出";
                        comm.Dispose();
                        read.Dispose();
                        return;
                    }
                    valid = true;
                }
                if (!valid)
                {
                    status_page1.Text = "无效的图书EPC";
                    comm.Dispose();
                    read.Dispose();
                    return;
                }
                comm.Dispose();
                read.Dispose();

                // Borrow book
                DateTime dt = DateTime.Now;
                DateTime due = dt.AddDays(20);
                string borrow_time = dt.ToString("yyyy-MM-dd");
                string due_time = due.ToString("yyyy-MM-dd");
                string borrow_way = dt.Second % 2 == 0 ? "门禁" : "借换台";
                comm = new SQLiteCommand("insert into BorrowRecord values ('" + user_id + "', '"
                    + book_epc + "', '" + borrow_time + "', '" + due_time + "', null, '" + borrow_way
                    + "')", LoginForm.conn);
                int result = comm.ExecuteNonQuery();
                comm.Dispose();
                comm = new SQLiteCommand("update BookEPC set isBorrowed = 1 where book_epc = '"
                    + book_epc + "'", LoginForm.conn);
                result += comm.ExecuteNonQuery();
                if (result == 2) status_page1.Text = "借阅成功";
                else status_page1.Text = "借阅失败";
                comm.Dispose();
            }
            else
            {
                // Check record existence
                SQLiteCommand comm = new SQLiteCommand("select due_time, return_time from BorrowRecord where user_id = '"
                    + user_id + "' and book_epc = '" + book_epc + "'", LoginForm.conn);
                SQLiteDataReader read = comm.ExecuteReader();
                string return_time = null;
                string due_time = null;
                while (read.Read())
                {
                    return_time = read["return_time"].ToString();
                    due_time = read["due_time"].ToString();
                }
                comm.Dispose();
                read.Dispose();
                
                // No record
                if (due_time == null || !return_time.Equals(""))
                {
                    status_page1.Text = "无借阅信息";
                    return;
                }

                // Return book
                DateTime dt = DateTime.Now;
                comm = new SQLiteCommand("update BorrowRecord set return_time = '" + dt.ToString("yyyy-MM-dd")
                    + "' where book_epc = '" + book_epc + "'", LoginForm.conn);
                int result = comm.ExecuteNonQuery();
                comm.Dispose();
                comm = new SQLiteCommand("update BookEPC set isBorrowed = 0 where book_epc = '" + book_epc + "'",
                    LoginForm.conn);
                result += comm.ExecuteNonQuery();
                comm.Dispose();
                string[] ymd = due_time.Split('-');
                DateTime due = new DateTime(Int32.Parse(ymd[0]), Int32.Parse(ymd[1]), Int32.Parse(ymd[2]));
                if (result == 2) status_page1.Text = "归还成功";
                if (DateTime.Compare(dt, due) > 0) status_page1.Text += "，超期请交罚款";
            }
        }

        private void bookSearchButton_Click(object sender, EventArgs e)
        {
            status_page1.Text = "";
            string isbn = ISBNLabelText.Text;
            if (isbn.Equals(""))
            {
                status_page2.Text = "查询请输入ISBN";
                return;
            }

            SQLiteCommand comm = new SQLiteCommand("select * from Book where book_id = '"
                + isbn + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            bool hasFound = false;

            while (read.Read())
            {
                optinalText.Text = read["book_name"].ToString();
                typeText.Text = read["book_type"].ToString();
                authorText.Text = read["book_author"].ToString();
                publisherText.Text = read["book_pub"].ToString();
                yearText.Text = read["book_pubdate"].ToString();

                hasFound = true;
                status_page2.Text = "查询成功";
            }

            if (!hasFound) status_page2.Text = "未找到书籍";

            comm.Dispose();
            read.Dispose();
        }

        private void bookDeleteButton_Click(object sender, EventArgs e)
        {
            status_page1.Text = "";
            string isbn = ISBNLabelText.Text;
            if (isbn.Equals(""))
            {
                status_page2.Text = "删除请输入ISBN";
                return;
            }

            SQLiteCommand comm = new SQLiteCommand("select * from Book where book_id = '"
                + isbn + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            bool hasFound = false;

            while (read.Read())
            {
                optinalText.Text = read["book_name"].ToString();
                typeText.Text = read["book_type"].ToString();
                authorText.Text = read["book_author"].ToString();
                publisherText.Text = read["book_pub"].ToString();
                yearText.Text = read["book_pubdate"].ToString();

                hasFound = true;
            }

            if (!hasFound) status_page2.Text = "删除失败，未找到书籍";
            else
            {
                comm = new SQLiteCommand("delete from Book, BookEpc where book_id = '"
                    + isbn + "'", LoginForm.conn);
                comm.ExecuteNonQuery();

            }

            comm.Dispose();
            read.Dispose();

        }

        private void bookUpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void usrSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void usrDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void usrUpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void bookInfoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            optionalLabel1.Text = "题名";

            optionalLabel2.Visible = true;
            optionalLabel3.Visible = true;
            optionalLabel4.Visible = true;
            optionalLabel5.Visible = true;

            typeText.Visible = true;
            authorText.Visible = true;
            publisherText.Visible = true;
            yearText.Visible = true;
        }

        private void bookEPCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            optionalLabel1.Text = "EPC";

            optionalLabel2.Visible = false;
            optionalLabel3.Visible = false;
            optionalLabel4.Visible = false;
            optionalLabel5.Visible = false;

            typeText.Visible = false;
            authorText.Visible = false;
            publisherText.Visible = false;
            yearText.Visible = false;
        }
    }
}
