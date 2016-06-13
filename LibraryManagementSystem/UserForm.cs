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

namespace LibraryManagementSystem
{
    public partial class UserForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public UserForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            searchButton.Enabled = false;
            materialRaisedButton2.Enabled = false;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton4.Enabled = false;

            // Add dummy data to the listview
            seedListView();
        }

        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"C1798399", "程序设计与算法语言:C++程序设计基础", "孔丽英, 夏艳, 徐勇编著", "2015-07-06", "2015-08-06"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                borrowmentList.Items.Add(item);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            lastPageButton.Visible = true;
            nextPageButton.Visible = true;
            showPageInfoText.Visible = true;
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialRaisedButton2.Enabled = false;
            materialRaisedButton3.Enabled = true;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialRaisedButton2.Enabled = true;
            materialRaisedButton3.Enabled = false;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton4.Enabled = false;
            materialRaisedButton5.Enabled = true;
            materialRaisedButton6.Enabled = true;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            materialRaisedButton4.Enabled = true;
            materialRaisedButton5.Enabled = false;
            materialRaisedButton6.Enabled = true;
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton4.Enabled = true;
            materialRaisedButton5.Enabled = true;
            materialRaisedButton6.Enabled = false;
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
    }
}
