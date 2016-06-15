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
        private string user_id;
        private UserForm userForm = null;

        public void set_user_id(string user_id)
        {
            this.user_id = user_id;
        }

        public AdminForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dayModeButton.Enabled = false;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            blueSchemeButton.Enabled = false;

            // Add dummy data to the listview
            seedListView();
        }

        private void seedListView()
        {
            // Define
            var data = new[]
            {
                new []{"13061093", "978-7-5133-1292-9", "门禁", "2016-06-10 19:55:20", "借"},
                new []{"13061214", "7-302-07475-5", "门禁", "2016-06-13 20:01:48", "还"}
            };

            // Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                borrowReturnList.Items.Add(item);
            }

            // Inventory
            SQLiteCommand comm = new SQLiteCommand("select * from Placement", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            List<string[]> list = new List<string[]>();
            while (read.Read())
            {
                string[] ss = { read["book_id"].ToString(), read["local"].ToString(),
                                  read["real_local"].ToString() };
                list.Add(ss);
            }

            foreach (string[] ss in list)
            {
                ListViewItem item = new ListViewItem(ss);
                inventoryListView.Items.Add(item);
            }
            comm.Dispose();
            read.Dispose();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dayModeButton.Enabled = false;
            nightModeButton.Enabled = true;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            dayModeButton.Enabled = true;
            nightModeButton.Enabled = false;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            blueSchemeButton.Enabled = false;
            greenSchemeButton.Enabled = true;
            bluegreySchemeButton.Enabled = true;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            blueSchemeButton.Enabled = true;
            greenSchemeButton.Enabled = false;
            bluegreySchemeButton.Enabled = true;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            blueSchemeButton.Enabled = true;
            greenSchemeButton.Enabled = true;
            bluegreySchemeButton.Enabled = false;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                string book_id = null;
                while (read.Read())
                {
                    int isBorrowed = Int32.Parse(read["isBorrowed"].ToString());
                    if (isBorrowed == 1)
                    {
                        status_page1.Text = "图书已借出";
                        comm.Dispose();
                        read.Dispose();
                        return;
                    }
                    book_id = read["book_id"].ToString();
                }
                if (book_id == null)
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
                string borrow_way = dt.Second % 2 == 0 ? "门禁" : "借还台";
                comm = new SQLiteCommand("insert into BorrowRecord (number, user_id, book_epc, borrow_time, due_time,"
                    + " borrow_way) values (null, '" + user_id + "', '" + book_epc + "', '" + borrow_time + "', '"
                    + due_time + "', '" + borrow_way + "')", LoginForm.conn);
                int result = comm.ExecuteNonQuery();
                comm.Dispose();
                comm = new SQLiteCommand("update BookEPC set isBorrowed = 1 where book_epc = '"
                    + book_epc + "'", LoginForm.conn);
                result += comm.ExecuteNonQuery();
                if (result == 2)
                {
                    status_page1.Text = "借阅成功";
                    string[] ss = { user_id, book_id, borrow_way,
                                      dt.GetDateTimeFormats('s')[0].ToString().Replace('T', ' '), "借" };
                    borrowReturnList.Items.Add(new ListViewItem(ss));
                }
                else status_page1.Text = "借阅失败";
                comm.Dispose();
            }
            else
            {
                // Check record existence
                SQLiteCommand comm = new SQLiteCommand("select * from BorrowRecord where user_id = '"
                    + user_id + "' and book_epc = '" + book_epc + "' ORDER BY number DESC", LoginForm.conn);
                SQLiteDataReader read = comm.ExecuteReader();
                string return_time = null;
                string due_time = null;
                string borrow_way = null;
                int number = -1;
                while (read.Read())
                {
                    return_time = read["return_time"].ToString();
                    due_time = read["due_time"].ToString();
                    borrow_way = read["borrow_way"].ToString();
                    number = Int32.Parse(read["number"].ToString());
                    break;
                }
                comm.Dispose();
                read.Dispose();

                comm = new SQLiteCommand("select book_id from BookEPC where book_epc = '" + book_epc + "'",
                    LoginForm.conn);
                read = comm.ExecuteReader();
                string book_id = null;
                while (read.Read()) book_id = read["book_id"].ToString();
                comm.Dispose();
                read.Dispose();
                
                // No record
                if (due_time == null || book_id == null || !return_time.Equals(""))
                {
                    status_page1.Text = "无借阅信息";
                    return;
                }

                // Return book
                DateTime dt = DateTime.Now;
                comm = new SQLiteCommand("update BorrowRecord set return_time = '" + dt.ToString("yyyy-MM-dd")
                    + "' where book_epc = '" + book_epc + "' and number = " + number, LoginForm.conn);
                int result = comm.ExecuteNonQuery();
                comm.Dispose();
                comm = new SQLiteCommand("update BookEPC set isBorrowed = 0 where book_epc = '" + book_epc + "'",
                    LoginForm.conn);
                result += comm.ExecuteNonQuery();
                comm.Dispose();
                string[] ymd = due_time.Split(new string[] { "/", " " }, StringSplitOptions.RemoveEmptyEntries);
                DateTime due = new DateTime(Int32.Parse(ymd[0]), Int32.Parse(ymd[1]), Int32.Parse(ymd[2]));
                if (result == 2)
                {
                    status_page1.Text = "归还成功";
                    string[] ss = { user_id, book_id, borrow_way,
                                      dt.GetDateTimeFormats('s')[0].ToString().Replace('T', ' '), "还" };
                    borrowReturnList.Items.Add(new ListViewItem(ss));
                }
                if (DateTime.Compare(dt, due) > 0) status_page1.Text += "，超期请交罚款";
            }
        }

        private void bookSearchButton_Click(object sender, EventArgs e)
        {
            status_page2.Text = "";
            string isbn = ISBNLabelText.Text;

            SQLiteCommand comm = new SQLiteCommand("select * from Book where book_id = '"
                + isbn + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            bool hasFound = false;

            while (read.Read())
            {
                optionalText.Text = read["book_name"].ToString();
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
            status_page2.Text = "";
            string isbn = ISBNLabelText.Text;

            if (bookInfoRadioButton.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand("select * from Book where book_id = '"
                    + isbn + "'", LoginForm.conn);
                SQLiteDataReader read = comm.ExecuteReader();
                bool hasFound = false;

                while (read.Read())
                {
                    optionalText.Text = read["book_name"].ToString();
                    typeText.Text = read["book_type"].ToString();
                    authorText.Text = read["book_author"].ToString();
                    publisherText.Text = read["book_pub"].ToString();
                    yearText.Text = read["book_pubdate"].ToString();

                    hasFound = true;
                }

                if (!hasFound) status_page2.Text = "删除失败，未找到书籍，请检查ISBN信息";
                else
                {
                    comm = new SQLiteCommand("delete from Book, BookEpc where book_id = '"
                        + isbn + "'", LoginForm.conn);
                    comm.ExecuteNonQuery();
                }

                comm.Dispose();
                read.Dispose();
            }
            else
            {
                string book_epc = optionalText.Text;
                SQLiteCommand comm = new SQLiteCommand("delete from BookEPC where book_id = '"
                    + isbn + "' and book_epc = '" + book_epc + "'", LoginForm.conn);
                int result = comm.ExecuteNonQuery();
                comm.Dispose();

                if (result == 1) status_page2.Text = "删除成功";
                else status_page2.Text = "删除失败，为找到对应关系";
            }

        }

        private void bookUpdateButton_Click(object sender, EventArgs e)
        {
            status_page2.Text = "";
            string isbn = ISBNLabelText.Text;
            string optinal = optionalText.Text;

            if (optinal.Equals(""))
            {
                status_page2.Text = "请将信息填写完整";
                return;
            }

            if (bookInfoRadioButton.Checked)
            {
                SQLiteCommand comm = new SQLiteCommand("select * from Book where book_id = '"
                    + isbn + "'", LoginForm.conn);
                SQLiteDataReader read = comm.ExecuteReader();
                bool hasFound = false;
                while (read.Read()) hasFound = true;
                comm.Dispose();
                read.Dispose();

                string type = typeText.Text;
                string author = authorText.Text;
                string publisher = publisherText.Text;
                int year = 0;
                try
                {
                    year = Int32.Parse(yearText.Text);
                }
                catch (Exception exc)
                {
                    status_page2.Text = "信息有误，请检查";
                    return;
                }

                // Update
                if (hasFound)
                {
                    comm = new SQLiteCommand("update Book set book_name = '" + optinal
                        + "', book_type = '" + type + "', book_author = '" + author
                        + "', book_pub = '" + publisher + "', book_pubdate = " + year
                        + " where book_id = '" + isbn + "'", LoginForm.conn);
                    comm.ExecuteNonQuery();
                    comm.Dispose();

                    status_page2.Text = "修改成功";
                }
                // Insert
                else
                {
                    comm = new SQLiteCommand("insert into Book values ('" + isbn + "', '"
                        + optinal + "', '" + type + "', '" + author + "', '" + publisher
                        + "', " + year + ")", LoginForm.conn);
                    comm.ExecuteNonQuery();
                    comm.Dispose();

                    status_page2.Text = "添加成功";
                }
            }
            else
            {
                SQLiteCommand comm = new SQLiteCommand("select * from Book where book_id = '"
                    + isbn + "'", LoginForm.conn);
                SQLiteDataReader read = comm.ExecuteReader();
                bool hasFound = false;
                while (read.Read()) hasFound = true;
                comm.Dispose();
                read.Dispose();

                if (!hasFound)
                {
                    status_page2.Text = "ISBN有误，请检查";
                    return;
                }

                comm = new SQLiteCommand("insert into BookEPC values ('" + isbn + "', '"
                    + optinal + "', 0)", LoginForm.conn);
                comm.ExecuteNonQuery();
                status_page2.Text = "添加成功";
            }
        }

        private void usrSearchButton_Click(object sender, EventArgs e)
        {
            status_page3.Text = "";
            string user_id = usrIDText.Text;

            SQLiteCommand comm = new SQLiteCommand("select * from User where user_id = '"
                + user_id + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            bool hasFound = false;

            while (read.Read())
            {
                usrNameText.Text = read["user_name"].ToString();
                if (Int32.Parse(read["user_gender"].ToString()) == 0) girlRadioButton.Checked = true;
                else boyRadioButton.Checked = true;
                usrPwText.Text = read["user_pwd"].ToString();
                if (read["user_type"].ToString().Equals("读者")) readerRadioButton.Checked = true;
                else adminRadioButton.Checked = true;

                hasFound = true;
                status_page3.Text = "查询成功";
            }

            if (!hasFound) status_page3.Text = "未找到用户";

            comm.Dispose();
            read.Dispose();
        }

        private void usrDeleteButton_Click(object sender, EventArgs e)
        {
            status_page3.Text = "";
            string user_id = usrIDText.Text;

            SQLiteCommand comm = new SQLiteCommand("select * from User where user_id = '"
                + user_id + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            bool hasFound = false;

            while (read.Read())
            {
                usrNameText.Text = read["user_name"].ToString();
                if ((int)read["user_gender"] == 0) girlRadioButton.Checked = true;
                else boyRadioButton.Checked = true;
                usrPwText.Text = read["book_pwd"].ToString();
                if (read["user_type"].ToString().Equals("读者")) readerRadioButton.Checked = true;
                else adminRadioButton.Checked = true;

                hasFound = true;
            }

            if (!hasFound) status_page3.Text = "删除失败，未找到用户，请检查用户ID";
            else
            {
                comm = new SQLiteCommand("delete from User where user_id = '"
                    + user_id + "'", LoginForm.conn);
                comm.ExecuteNonQuery();
                status_page3.Text = "删除成功";
            }

            comm.Dispose();
            read.Dispose();
        }

        private void usrUpdateButton_Click(object sender, EventArgs e)
        {
            status_page3.Text = "";
            string user_id = usrIDText.Text;
            string user_name = usrNameText.Text;
            int user_gender = boyRadioButton.Checked ? 1 : 0;
            string user_pwd = usrPwText.Text;
            string user_type = readerRadioButton.Checked ? "读者" : "管理员";

            if (user_name.Equals("") || user_pwd.Equals(""))
            {
                status_page3.Text = "请将信息填写完整";
                return;
            }

            // Search unit epc
            SQLiteCommand comm = new SQLiteCommand("select * from User where user_id = '"
                + user_id + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            bool hasFound = false;
            while (read.Read()) hasFound = true;
            comm.Dispose();
            read.Dispose();
            
            // Update
            if (hasFound)
            {
                comm = new SQLiteCommand("update User set user_name = '" + user_name
                    + "', user_gender = " + user_gender + ", user_pwd = '" + user_pwd
                    + "', user_type = '" + user_type + "' where user_id = '" + user_id
                    + "'", LoginForm.conn);
                comm.ExecuteNonQuery();
                comm.Dispose();
                status_page3.Text = "修改成功";
            }
            // Insert
            else
            {
                comm = new SQLiteCommand("insert into User values ('" + user_id + "', '"
                    + user_name + "', '" + user_type + "', '" + user_pwd + "', " + user_gender
                    + ", null)", LoginForm.conn);
                comm.ExecuteNonQuery();
                comm.Dispose();
                status_page3.Text = "添加成功";
            }

        }

        private void shelfSearchButton_Click(object sender, EventArgs e)
        {
            status_page4.Text = "";

            string location = floorText.Text + "-" + roomText.Text + "-" + bookcaseText.Text
                + "-" + shelfText.Text + "-" + unitText.Text;
            string unit_epc = null;
            
            // Search unit epc
            SQLiteCommand comm = new SQLiteCommand("select * from UnitEPC where unit_id = '"
                + location + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            while (read.Read()) unit_epc = read["unit_epc"].ToString();
            comm.Dispose();
            read.Dispose();

            if (unit_epc == null)
            {
                unitEPCText.Text = "";
                status_page4.Text = "未找到对应的EPC";
            }
            else
            {
                unitEPCText.Text = unit_epc;
                status_page4.Text = "查询成功";
            }
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            status_page4.Text = "";

            string location = floorText.Text + "-" + roomText.Text + "-" + bookcaseText.Text
                + "-" + shelfText.Text + "-" + unitText.Text;

            SQLiteCommand comm = new SQLiteCommand("select book_id from Placement where real_local = '"
                + location + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            List<string> results = new List<string>();
            while (read.Read()) results.Add(read["book_id"].ToString());
            comm.Dispose();
            read.Dispose();

            if (results.Count == 0) inventoryText.Text = "该书架未找到图书";
            else
            {
                inventoryText.Text = "在该书架上找到" + results.Count + "种书";
                foreach (string id in results) inventoryText.Text += "\r\n" + id;
            }
        }

        private void shelfDeleteButton_Click(object sender, EventArgs e)
        {
            status_page4.Text = "";

            if (floorText.Text.Equals("") || roomText.Text.Equals("") || bookcaseText.Text.Equals("")
                || shelfText.Text.Equals("") || unitText.Text.Equals(""))
            {
                status_page4.Text = "请输入完整的书架ID";
                return;
            }

            string location = floorText.Text + "-" + roomText.Text + "-" + bookcaseText.Text
                + "-" + shelfText.Text + "-" + unitText.Text;
            string unit_epc = null;

            // Search unit epc
            SQLiteCommand comm = new SQLiteCommand("select * from UnitEPC where unit_id = '"
                + location + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            while (read.Read()) unit_epc = read["unit_epc"].ToString();
            comm.Dispose();
            read.Dispose();

            if (unit_epc == null) status_page4.Text = "删除失败，无书架ID对应的记录";
            else
            {
                unitEPCText.Text = unit_epc;
                comm = new SQLiteCommand("delete from UnitEPC where unit_id = '" + location + "'",
                    LoginForm.conn);
                comm.ExecuteNonQuery();
                comm.Dispose();
                status_page4.Text = "删除成功";
            }
        }

        private void shelfUpdateButton_Click(object sender, EventArgs e)
        {
            status_page4.Text = "";

            if (floorText.Text.Equals("") || roomText.Text.Equals("") || bookcaseText.Text.Equals("")
                || shelfText.Text.Equals("") || unitText.Text.Equals("") || unitEPCText.Text.Equals(""))
            {
                status_page4.Text = "请输入完整的书架ID和EPC";
                return;
            }

            string location = floorText.Text + "-" + roomText.Text + "-" + bookcaseText.Text
                + "-" + shelfText.Text + "-" + unitText.Text;
            string unit_epc = unitEPCText.Text;

            // Search unit epc
            SQLiteCommand comm = new SQLiteCommand("select * from UnitEPC where unit_id = '"
                + location + "'", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            bool hasFound = false;
            while (read.Read()) hasFound = true;
            comm.Dispose();
            read.Dispose();

            // Update
            if (hasFound)
            {
                comm = new SQLiteCommand("update UnitEPC set unit_epc = '" + unit_epc + "' where unit_id = '"
                + location + "'", LoginForm.conn);
                comm.ExecuteNonQuery();
                comm.Dispose();

                status_page4.Text = "修改成功";
            }
            // Insert
            else
            {
                comm = new SQLiteCommand("insert into UnitEPC values ('" + location + "', '" + unit_epc + "')",
                    LoginForm.conn);
                comm.ExecuteNonQuery();
                comm.Dispose();

                status_page4.Text = "添加成功";
            }
            
        }

        private void bookInfoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            optionalLabel1.Text = "*题名";
            optionalText.Text = "";

            optionalLabel2.Visible = true;
            optionalLabel3.Visible = true;
            optionalLabel4.Visible = true;
            optionalLabel5.Visible = true;

            typeText.Visible = true;
            authorText.Visible = true;
            publisherText.Visible = true;
            yearText.Visible = true;

            bookSearchButton.Visible = true;
        }

        private void bookEPCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            optionalLabel1.Text = "*EPC";
            optionalText.Text = "";
            typeText.Text = "";
            authorText.Text = "";
            publisherText.Text = "";
            yearText.Text = "";

            optionalLabel2.Visible = false;
            optionalLabel3.Visible = false;
            optionalLabel4.Visible = false;
            optionalLabel5.Visible = false;

            typeText.Visible = false;
            authorText.Visible = false;
            publisherText.Visible = false;
            yearText.Visible = false;

            bookSearchButton.Visible = false;
        }

        private void borrowReturnList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inventoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminModeButton_Click(object sender, EventArgs e)
        {
            if (userForm == null)
            {
                userForm = new UserForm();
                userForm.set_user_id(user_id);
                userForm.setAdminForm(this);
            }
            Hide();
            userForm.Show();
        }
    }
}
