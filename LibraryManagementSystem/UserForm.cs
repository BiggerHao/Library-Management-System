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
    public partial class UserForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string user_id;
        private AdminForm adminForm = null;

        public void setAdminForm(AdminForm adminForm)
        {
            this.adminForm = adminForm;
            adminModeButton.Enabled = true;
        }

        public void set_user_id(string user_id)
        {
            this.user_id = user_id;
            seedListView();
        }
        public UserForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dayModeButton.Enabled = false;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            blueSchemeButton.Enabled = false;

            // Add dummy data to the listview
            
        }

        private void seedListView()
        {
            //借阅信息表
            //SQLiteCommand comm = new SQLiteCommand("select * from BorrowRecord where user_id = '" + user_id +"';", LoginForm.conn);

            SQLiteCommand comm = new SQLiteCommand("select * from BorrowRecord, BookEPC, Book where BorrowRecord.user_id = '" + user_id + "'and BorrowRecord.book_epc = BookEPC.book_epc and BookEPC.book_id = Book.book_id;", LoginForm.conn);
            SQLiteDataReader read = comm.ExecuteReader();
            List<string[]> list = new List<string[]>();
            int num = 1;
            while (read.Read())
            {

                /* string name = read["user_id"].ToString();//sdf
                 string bokk = read["book_id"].ToString();
                 string time1 = read["borrow_time"].ToString();
                 string time2 = read["due_time"].ToString();*/

                /*string time2 = read["return_time"].ToString();

                string aa = read["book_name"].ToString();*/
               
                this.borrowmentList.BeginUpdate();
                if (read["return_time"].ToString()=="")
                {
                    string[] ss = { num.ToString(),read["book_name"].ToString(), read["borrow_time"].ToString(),
                                  read["due_time"].ToString(),"No"};
                    list.Add(ss);
                }
                else
                {
                    string[] ss = { num.ToString(),read["book_name"].ToString(), read["borrow_time"].ToString(),
                                  read["due_time"].ToString(),"Yes"};
                    list.Add(ss);
                }
                num++;
            }
            comm.Dispose();
            read.Dispose();
            foreach (string[] ss in list)
            {
                ListViewItem item = new ListViewItem(ss);
                borrowmentList.Items.Add(item);
            }
            this.borrowmentList.EndUpdate();

            //我的资料表
            comm = new SQLiteCommand("select * from User where user_id = '" + user_id + "';",
                   LoginForm.conn);
            read = comm.ExecuteReader();

            if(read.Read())
            {
                userIDText.Text = read["user_id"].ToString();
                userNameText.Text = read["user_name"].ToString();
                userGenderText.Text = read["user_gender"].ToString() == "0" ? "女":"男" ;
                userTypeText.Text = read["user_type"].ToString();

            }
            comm.Dispose();
            read.Dispose();

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchText.Text = "ha";
            lastPageButton.Visible = true;
            nextPageButton.Visible = true;
            showPageInfoText.Visible = true;
            int i = 0;
            string keyword = searchText.Text;
            if(searchCombo.Text=="题名")
            {
                
            }
            else if(searchCombo.Text == "作者")
            {
                i = 10;
            }
            else if(searchCombo.Text == "ISBN")
            {

            }
            else
            {

            }

        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            dayModeButton.Enabled = false;
            nightModeButton.Enabled = true;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            dayModeButton.Enabled = true;
            nightModeButton.Enabled = false;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            blueSchemeButton.Enabled = false;
            greenSchemeButton.Enabled = true;
            bluegreySchemeButton.Enabled = true;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            blueSchemeButton.Enabled = true;
            greenSchemeButton.Enabled = false;
            bluegreySchemeButton.Enabled = true;
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            blueSchemeButton.Enabled = true;
            greenSchemeButton.Enabled = true;
            bluegreySchemeButton.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void myProfile_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookQuery_Click(object sender, EventArgs e)
        {

        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {

        }

        private void lastPageButton_Click(object sender, EventArgs e)
        {

        }

        private void bookInfo3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookInfo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookInfo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchText_Click(object sender, EventArgs e)
        {

        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myBorrow_Click(object sender, EventArgs e)
        {

        }

        private void borrowmentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField10_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {

        }

        private void userTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void userAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void userPwLabel_Click(object sender, EventArgs e)
        {

        }

        private void userGenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userTypeText_Click(object sender, EventArgs e)
        {

        }

        private void userPwText_Click(object sender, EventArgs e)
        {

        }

        private void userAddressText_Click(object sender, EventArgs e)
        {

        }

        private void userGenderText_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void userIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void setTheme_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminModeButton_Click(object sender, EventArgs e)
        {
            Hide();
            adminForm.Show();
        }
    }
}
