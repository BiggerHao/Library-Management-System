using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LibraryManagementSystem
{
    partial class UserForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.userTab = new MaterialSkin.Controls.MaterialTabControl();
            this.bookQuery = new System.Windows.Forms.TabPage();
            this.showPageInfoText = new System.Windows.Forms.TextBox();
            this.nextPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lastPageButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bookInfo3 = new System.Windows.Forms.TextBox();
            this.bookInfo2 = new System.Windows.Forms.TextBox();
            this.bookInfo1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.searchText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.myBorrow = new System.Windows.Forms.TabPage();
            this.borrowmentList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myProfile = new System.Windows.Forms.TabPage();
            this.updateProfileButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.userTypeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.userAddressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.userPwLabel = new MaterialSkin.Controls.MaterialLabel();
            this.userGenderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.userNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.userTypeText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userPwText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userAddressText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userGenderText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userNameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userIDText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userIdLabel = new MaterialSkin.Controls.MaterialLabel();
            this.setTheme = new System.Windows.Forms.TabPage();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.userTab.SuspendLayout();
            this.bookQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.myBorrow.SuspendLayout();
            this.myProfile.SuspendLayout();
            this.setTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.userTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 44);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // userTab
            // 
            this.userTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTab.Controls.Add(this.bookQuery);
            this.userTab.Controls.Add(this.myBorrow);
            this.userTab.Controls.Add(this.myProfile);
            this.userTab.Controls.Add(this.setTheme);
            this.userTab.Depth = 0;
            this.userTab.Location = new System.Drawing.Point(14, 109);
            this.userTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.userTab.Name = "userTab";
            this.userTab.SelectedIndex = 0;
            this.userTab.Size = new System.Drawing.Size(776, 713);
            this.userTab.TabIndex = 18;
            this.userTab.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // bookQuery
            // 
            this.bookQuery.BackColor = System.Drawing.Color.White;
            this.bookQuery.Controls.Add(this.showPageInfoText);
            this.bookQuery.Controls.Add(this.nextPageButton);
            this.bookQuery.Controls.Add(this.lastPageButton);
            this.bookQuery.Controls.Add(this.bookInfo3);
            this.bookQuery.Controls.Add(this.bookInfo2);
            this.bookQuery.Controls.Add(this.bookInfo1);
            this.bookQuery.Controls.Add(this.pictureBox2);
            this.bookQuery.Controls.Add(this.pictureBox4);
            this.bookQuery.Controls.Add(this.pictureBox1);
            this.bookQuery.Controls.Add(this.searchButton);
            this.bookQuery.Controls.Add(this.searchText);
            this.bookQuery.Controls.Add(this.searchCombo);
            this.bookQuery.Location = new System.Drawing.Point(4, 26);
            this.bookQuery.Name = "bookQuery";
            this.bookQuery.Padding = new System.Windows.Forms.Padding(3);
            this.bookQuery.Size = new System.Drawing.Size(768, 683);
            this.bookQuery.TabIndex = 0;
            this.bookQuery.Text = "图书查阅";
            this.bookQuery.Click += new System.EventHandler(this.bookQuery_Click);
            // 
            // showPageInfoText
            // 
            this.showPageInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showPageInfoText.Location = new System.Drawing.Point(361, 545);
            this.showPageInfoText.Name = "showPageInfoText";
            this.showPageInfoText.Size = new System.Drawing.Size(30, 16);
            this.showPageInfoText.TabIndex = 13;
            this.showPageInfoText.Text = "1/5";
            this.showPageInfoText.Visible = false;
            this.showPageInfoText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Depth = 0;
            this.nextPageButton.Location = new System.Drawing.Point(429, 542);
            this.nextPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Primary = true;
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 12;
            this.nextPageButton.Text = "下一页";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Visible = false;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // lastPageButton
            // 
            this.lastPageButton.Depth = 0;
            this.lastPageButton.Location = new System.Drawing.Point(241, 542);
            this.lastPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastPageButton.Name = "lastPageButton";
            this.lastPageButton.Primary = true;
            this.lastPageButton.Size = new System.Drawing.Size(75, 23);
            this.lastPageButton.TabIndex = 11;
            this.lastPageButton.Text = "上一页";
            this.lastPageButton.UseVisualStyleBackColor = true;
            this.lastPageButton.Visible = false;
            this.lastPageButton.Click += new System.EventHandler(this.lastPageButton_Click);
            // 
            // bookInfo3
            // 
            this.bookInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookInfo3.Enabled = false;
            this.bookInfo3.Location = new System.Drawing.Point(213, 399);
            this.bookInfo3.Multiline = true;
            this.bookInfo3.Name = "bookInfo3";
            this.bookInfo3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookInfo3.Size = new System.Drawing.Size(496, 120);
            this.bookInfo3.TabIndex = 10;
            this.bookInfo3.TextChanged += new System.EventHandler(this.bookInfo3_TextChanged);
            // 
            // bookInfo2
            // 
            this.bookInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookInfo2.Enabled = false;
            this.bookInfo2.Location = new System.Drawing.Point(213, 250);
            this.bookInfo2.Multiline = true;
            this.bookInfo2.Name = "bookInfo2";
            this.bookInfo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookInfo2.Size = new System.Drawing.Size(496, 120);
            this.bookInfo2.TabIndex = 9;
            this.bookInfo2.TextChanged += new System.EventHandler(this.bookInfo2_TextChanged);
            // 
            // bookInfo1
            // 
            this.bookInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookInfo1.Enabled = false;
            this.bookInfo1.Location = new System.Drawing.Point(213, 98);
            this.bookInfo1.Multiline = true;
            this.bookInfo1.Name = "bookInfo1";
            this.bookInfo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookInfo1.Size = new System.Drawing.Size(496, 120);
            this.bookInfo1.TabIndex = 8;
            this.bookInfo1.TextChanged += new System.EventHandler(this.bookInfo1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(31, 250);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Depth = 0;
            this.searchButton.Location = new System.Drawing.Point(634, 20);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.Primary = true;
            this.searchButton.Size = new System.Drawing.Size(75, 30);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Depth = 0;
            this.searchText.Hint = "";
            this.searchText.Location = new System.Drawing.Point(213, 24);
            this.searchText.MaxLength = 32767;
            this.searchText.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.SelectedText = "";
            this.searchText.SelectionLength = 0;
            this.searchText.SelectionStart = 0;
            this.searchText.Size = new System.Drawing.Size(415, 25);
            this.searchText.TabIndex = 1;
            this.searchText.TabStop = false;
            this.searchText.Text = "请输入关键字";
            this.searchText.UseSystemPasswordChar = false;
            this.searchText.Click += new System.EventHandler(this.searchText_Click);
            // 
            // searchCombo
            // 
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "题名",
            "作者",
            "ISBN"});
            this.searchCombo.Location = new System.Drawing.Point(31, 24);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(121, 25);
            this.searchCombo.TabIndex = 0;
            this.searchCombo.Text = "请选择";
            this.searchCombo.SelectedIndexChanged += new System.EventHandler(this.searchCombo_SelectedIndexChanged);
            // 
            // myBorrow
            // 
            this.myBorrow.Controls.Add(this.borrowmentList);
            this.myBorrow.Location = new System.Drawing.Point(4, 26);
            this.myBorrow.Name = "myBorrow";
            this.myBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.myBorrow.Size = new System.Drawing.Size(768, 683);
            this.myBorrow.TabIndex = 1;
            this.myBorrow.Text = "我的借阅";
            this.myBorrow.UseVisualStyleBackColor = true;
            this.myBorrow.Click += new System.EventHandler(this.myBorrow_Click);
            // 
            // borrowmentList
            // 
            this.borrowmentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowmentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.borrowmentList.Depth = 0;
            this.borrowmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowmentList.Font = new System.Drawing.Font("Microsoft YaHei", 24F);
            this.borrowmentList.FullRowSelect = true;
            this.borrowmentList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.borrowmentList.Location = new System.Drawing.Point(3, 3);
            this.borrowmentList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.borrowmentList.MouseState = MaterialSkin.MouseState.OUT;
            this.borrowmentList.Name = "borrowmentList";
            this.borrowmentList.OwnerDraw = true;
            this.borrowmentList.Size = new System.Drawing.Size(762, 677);
            this.borrowmentList.TabIndex = 0;
            this.borrowmentList.UseCompatibleStateImageBehavior = false;
            this.borrowmentList.View = System.Windows.Forms.View.Details;
            this.borrowmentList.SelectedIndexChanged += new System.EventHandler(this.borrowmentList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "题名";
            this.columnHeader2.Width = 246;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "借阅日期";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "应还日期";
            this.columnHeader4.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "借还状态";
            this.columnHeader5.Width = 143;
            // 
            // myProfile
            // 
            this.myProfile.BackColor = System.Drawing.Color.White;
            this.myProfile.Controls.Add(this.updateProfileButton);
            this.myProfile.Controls.Add(this.userTypeLabel);
            this.myProfile.Controls.Add(this.userAddressLabel);
            this.myProfile.Controls.Add(this.userPwLabel);
            this.myProfile.Controls.Add(this.userGenderLabel);
            this.myProfile.Controls.Add(this.userNameLabel);
            this.myProfile.Controls.Add(this.userTypeText);
            this.myProfile.Controls.Add(this.userPwText);
            this.myProfile.Controls.Add(this.userAddressText);
            this.myProfile.Controls.Add(this.userGenderText);
            this.myProfile.Controls.Add(this.userNameText);
            this.myProfile.Controls.Add(this.userIDText);
            this.myProfile.Controls.Add(this.userIdLabel);
            this.myProfile.Location = new System.Drawing.Point(4, 26);
            this.myProfile.Name = "myProfile";
            this.myProfile.Size = new System.Drawing.Size(768, 683);
            this.myProfile.TabIndex = 2;
            this.myProfile.Text = "我的资料";
            this.myProfile.Click += new System.EventHandler(this.myProfile_Click);
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.Depth = 0;
            this.updateProfileButton.Location = new System.Drawing.Point(305, 315);
            this.updateProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Primary = true;
            this.updateProfileButton.Size = new System.Drawing.Size(75, 30);
            this.updateProfileButton.TabIndex = 25;
            this.updateProfileButton.Text = "更新";
            this.updateProfileButton.UseVisualStyleBackColor = true;
            this.updateProfileButton.Click += new System.EventHandler(this.materialRaisedButton12_Click);
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Depth = 0;
            this.userTypeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.userTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userTypeLabel.Location = new System.Drawing.Point(179, 246);
            this.userTypeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(39, 20);
            this.userTypeLabel.TabIndex = 24;
            this.userTypeLabel.Text = "类型";
            this.userTypeLabel.Click += new System.EventHandler(this.userTypeLabel_Click);
            // 
            // userAddressLabel
            // 
            this.userAddressLabel.AutoSize = true;
            this.userAddressLabel.Depth = 0;
            this.userAddressLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.userAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userAddressLabel.Location = new System.Drawing.Point(179, 166);
            this.userAddressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userAddressLabel.Name = "userAddressLabel";
            this.userAddressLabel.Size = new System.Drawing.Size(39, 20);
            this.userAddressLabel.TabIndex = 23;
            this.userAddressLabel.Text = "地址";
            this.userAddressLabel.Click += new System.EventHandler(this.userAddressLabel_Click);
            // 
            // userPwLabel
            // 
            this.userPwLabel.AutoSize = true;
            this.userPwLabel.Depth = 0;
            this.userPwLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.userPwLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userPwLabel.Location = new System.Drawing.Point(179, 206);
            this.userPwLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userPwLabel.Name = "userPwLabel";
            this.userPwLabel.Size = new System.Drawing.Size(39, 20);
            this.userPwLabel.TabIndex = 22;
            this.userPwLabel.Text = "密码";
            this.userPwLabel.Click += new System.EventHandler(this.userPwLabel_Click);
            // 
            // userGenderLabel
            // 
            this.userGenderLabel.AutoSize = true;
            this.userGenderLabel.Depth = 0;
            this.userGenderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.userGenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userGenderLabel.Location = new System.Drawing.Point(179, 126);
            this.userGenderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userGenderLabel.Name = "userGenderLabel";
            this.userGenderLabel.Size = new System.Drawing.Size(39, 20);
            this.userGenderLabel.TabIndex = 21;
            this.userGenderLabel.Text = "性别";
            this.userGenderLabel.Click += new System.EventHandler(this.userGenderLabel_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Depth = 0;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userNameLabel.Location = new System.Drawing.Point(164, 86);
            this.userNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(54, 20);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "用户名";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // userTypeText
            // 
            this.userTypeText.Depth = 0;
            this.userTypeText.Hint = "";
            this.userTypeText.Location = new System.Drawing.Point(261, 241);
            this.userTypeText.MaxLength = 32767;
            this.userTypeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.userTypeText.Name = "userTypeText";
            this.userTypeText.PasswordChar = '\0';
            this.userTypeText.SelectedText = "";
            this.userTypeText.SelectionLength = 0;
            this.userTypeText.SelectionStart = 0;
            this.userTypeText.Size = new System.Drawing.Size(255, 25);
            this.userTypeText.TabIndex = 18;
            this.userTypeText.TabStop = false;
            this.userTypeText.UseSystemPasswordChar = false;
            this.userTypeText.Click += new System.EventHandler(this.userTypeText_Click);
            // 
            // userPwText
            // 
            this.userPwText.Depth = 0;
            this.userPwText.Hint = "";
            this.userPwText.Location = new System.Drawing.Point(261, 201);
            this.userPwText.MaxLength = 32767;
            this.userPwText.MouseState = MaterialSkin.MouseState.HOVER;
            this.userPwText.Name = "userPwText";
            this.userPwText.PasswordChar = '\0';
            this.userPwText.SelectedText = "";
            this.userPwText.SelectionLength = 0;
            this.userPwText.SelectionStart = 0;
            this.userPwText.Size = new System.Drawing.Size(255, 25);
            this.userPwText.TabIndex = 17;
            this.userPwText.TabStop = false;
            this.userPwText.UseSystemPasswordChar = false;
            this.userPwText.Click += new System.EventHandler(this.userPwText_Click);
            // 
            // userAddressText
            // 
            this.userAddressText.Depth = 0;
            this.userAddressText.Hint = "";
            this.userAddressText.Location = new System.Drawing.Point(261, 161);
            this.userAddressText.MaxLength = 32767;
            this.userAddressText.MouseState = MaterialSkin.MouseState.HOVER;
            this.userAddressText.Name = "userAddressText";
            this.userAddressText.PasswordChar = '\0';
            this.userAddressText.SelectedText = "";
            this.userAddressText.SelectionLength = 0;
            this.userAddressText.SelectionStart = 0;
            this.userAddressText.Size = new System.Drawing.Size(255, 25);
            this.userAddressText.TabIndex = 16;
            this.userAddressText.TabStop = false;
            this.userAddressText.UseSystemPasswordChar = false;
            this.userAddressText.Click += new System.EventHandler(this.userAddressText_Click);
            // 
            // userGenderText
            // 
            this.userGenderText.Depth = 0;
            this.userGenderText.Hint = "";
            this.userGenderText.Location = new System.Drawing.Point(261, 121);
            this.userGenderText.MaxLength = 32767;
            this.userGenderText.MouseState = MaterialSkin.MouseState.HOVER;
            this.userGenderText.Name = "userGenderText";
            this.userGenderText.PasswordChar = '\0';
            this.userGenderText.SelectedText = "";
            this.userGenderText.SelectionLength = 0;
            this.userGenderText.SelectionStart = 0;
            this.userGenderText.Size = new System.Drawing.Size(255, 25);
            this.userGenderText.TabIndex = 15;
            this.userGenderText.TabStop = false;
            this.userGenderText.UseSystemPasswordChar = false;
            this.userGenderText.Click += new System.EventHandler(this.userGenderText_Click);
            // 
            // userNameText
            // 
            this.userNameText.Depth = 0;
            this.userNameText.Hint = "";
            this.userNameText.Location = new System.Drawing.Point(261, 81);
            this.userNameText.MaxLength = 32767;
            this.userNameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameText.Name = "userNameText";
            this.userNameText.PasswordChar = '\0';
            this.userNameText.SelectedText = "";
            this.userNameText.SelectionLength = 0;
            this.userNameText.SelectionStart = 0;
            this.userNameText.Size = new System.Drawing.Size(255, 25);
            this.userNameText.TabIndex = 14;
            this.userNameText.TabStop = false;
            this.userNameText.UseSystemPasswordChar = false;
            this.userNameText.Click += new System.EventHandler(this.materialSingleLineTextField10_Click);
            // 
            // userIDText
            // 
            this.userIDText.Depth = 0;
            this.userIDText.Hint = "";
            this.userIDText.Location = new System.Drawing.Point(261, 41);
            this.userIDText.MaxLength = 32767;
            this.userIDText.MouseState = MaterialSkin.MouseState.HOVER;
            this.userIDText.Name = "userIDText";
            this.userIDText.PasswordChar = '\0';
            this.userIDText.SelectedText = "";
            this.userIDText.SelectionLength = 0;
            this.userIDText.SelectionStart = 0;
            this.userIDText.Size = new System.Drawing.Size(255, 25);
            this.userIDText.TabIndex = 13;
            this.userIDText.TabStop = false;
            this.userIDText.UseSystemPasswordChar = false;
            this.userIDText.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Depth = 0;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.userIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userIdLabel.Location = new System.Drawing.Point(164, 46);
            this.userIdLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(54, 20);
            this.userIdLabel.TabIndex = 1;
            this.userIdLabel.Text = "用户ID";
            this.userIdLabel.Click += new System.EventHandler(this.userIdLabel_Click);
            // 
            // setTheme
            // 
            this.setTheme.Controls.Add(this.materialRaisedButton6);
            this.setTheme.Controls.Add(this.materialRaisedButton5);
            this.setTheme.Controls.Add(this.materialRaisedButton4);
            this.setTheme.Controls.Add(this.materialLabel2);
            this.setTheme.Controls.Add(this.materialRaisedButton3);
            this.setTheme.Controls.Add(this.materialRaisedButton2);
            this.setTheme.Controls.Add(this.materialLabel1);
            this.setTheme.Location = new System.Drawing.Point(4, 26);
            this.setTheme.Name = "setTheme";
            this.setTheme.Size = new System.Drawing.Size(768, 683);
            this.setTheme.TabIndex = 3;
            this.setTheme.Text = "主题设置";
            this.setTheme.UseVisualStyleBackColor = true;
            this.setTheme.Click += new System.EventHandler(this.setTheme_Click);
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(410, 60);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(130, 40);
            this.materialRaisedButton6.TabIndex = 9;
            this.materialRaisedButton6.Text = "蓝灰色";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(255, 60);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(130, 40);
            this.materialRaisedButton5.TabIndex = 8;
            this.materialRaisedButton5.Text = "绿色";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(100, 60);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(130, 40);
            this.materialRaisedButton4.TabIndex = 7;
            this.materialRaisedButton4.Text = "蓝色";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 70);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 20);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "更换配色";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(255, 5);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(130, 40);
            this.materialRaisedButton3.TabIndex = 5;
            this.materialRaisedButton3.Text = "夜间模式";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(100, 5);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(130, 40);
            this.materialRaisedButton2.TabIndex = 4;
            this.materialRaisedButton2.Text = "日间模式";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 20);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "更换主题";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(23, 22);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(724, 513);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.userTab);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.Text = "图书馆管理系统-用户模式";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.userTab.ResumeLayout(false);
            this.bookQuery.ResumeLayout(false);
            this.bookQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.myBorrow.ResumeLayout(false);
            this.myProfile.ResumeLayout(false);
            this.myProfile.PerformLayout();
            this.setTheme.ResumeLayout(false);
            this.setTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl userTab;
        private System.Windows.Forms.TabPage bookQuery;
        private System.Windows.Forms.TabPage myBorrow;
        private System.Windows.Forms.TabPage myProfile;
        private MaterialSkin.Controls.MaterialRaisedButton searchButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchText;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox bookInfo3;
        private System.Windows.Forms.TextBox bookInfo2;
        private System.Windows.Forms.TextBox bookInfo1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox4;
        private MaterialListView borrowmentList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TabPage setTheme;
        private MaterialLabel materialLabel1;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialRaisedButton materialRaisedButton3;
        private MaterialLabel materialLabel2;
        private MaterialRaisedButton materialRaisedButton4;
        private MaterialRaisedButton materialRaisedButton5;
        private MaterialRaisedButton materialRaisedButton6;
        private MaterialLabel userIdLabel;
        private MaterialSingleLineTextField userTypeText;
        private MaterialSingleLineTextField userPwText;
        private MaterialSingleLineTextField userAddressText;
        private MaterialSingleLineTextField userGenderText;
        private MaterialSingleLineTextField userNameText;
        private MaterialSingleLineTextField userIDText;
        private MaterialLabel userTypeLabel;
        private MaterialLabel userAddressLabel;
        private MaterialLabel userPwLabel;
        private MaterialLabel userGenderLabel;
        private MaterialLabel userNameLabel;
        private MaterialRaisedButton updateProfileButton;
        private TextBox showPageInfoText;
        private MaterialRaisedButton nextPageButton;
        private MaterialRaisedButton lastPageButton;
        private ColumnHeader columnHeader5;
    }
}

