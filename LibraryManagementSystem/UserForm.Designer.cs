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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.searchText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField14 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField13 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField12 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField11 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField10 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton12 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 44);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 109);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(776, 713);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.materialRaisedButton8);
            this.tabPage1.Controls.Add(this.materialRaisedButton7);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.searchText);
            this.tabPage1.Controls.Add(this.searchCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图书查阅";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(213, 399);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(496, 120);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(213, 250);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(496, 120);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(213, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(496, 120);
            this.textBox1.TabIndex = 8;
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
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(634, 20);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 30);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "搜索";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "我的借阅";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(3, 3);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(762, 562);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "题名";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "责任者";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "借阅日期";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "应还日期";
            this.columnHeader5.Width = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialRaisedButton12);
            this.tabPage3.Controls.Add(this.materialLabel17);
            this.tabPage3.Controls.Add(this.materialLabel16);
            this.tabPage3.Controls.Add(this.materialLabel15);
            this.tabPage3.Controls.Add(this.materialLabel14);
            this.tabPage3.Controls.Add(this.materialLabel13);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField14);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField13);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField12);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField11);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField10);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField3);
            this.tabPage3.Controls.Add(this.materialLabel12);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "我的资料";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialRaisedButton6);
            this.tabPage4.Controls.Add(this.materialRaisedButton5);
            this.tabPage4.Controls.Add(this.materialRaisedButton4);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialRaisedButton3);
            this.tabPage4.Controls.Add(this.materialRaisedButton2);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 568);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "主题设置";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.materialLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 70);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 20);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "更换配色";
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
            this.materialLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 20);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "更换主题";
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
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(164, 46);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(54, 20);
            this.materialLabel12.TabIndex = 1;
            this.materialLabel12.Text = "用户ID";
            // 
            // materialSingleLineTextField14
            // 
            this.materialSingleLineTextField14.Depth = 0;
            this.materialSingleLineTextField14.Hint = "";
            this.materialSingleLineTextField14.Location = new System.Drawing.Point(261, 241);
            this.materialSingleLineTextField14.MaxLength = 32767;
            this.materialSingleLineTextField14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField14.Name = "materialSingleLineTextField14";
            this.materialSingleLineTextField14.PasswordChar = '\0';
            this.materialSingleLineTextField14.SelectedText = "";
            this.materialSingleLineTextField14.SelectionLength = 0;
            this.materialSingleLineTextField14.SelectionStart = 0;
            this.materialSingleLineTextField14.Size = new System.Drawing.Size(255, 25);
            this.materialSingleLineTextField14.TabIndex = 18;
            this.materialSingleLineTextField14.TabStop = false;
            this.materialSingleLineTextField14.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField13
            // 
            this.materialSingleLineTextField13.Depth = 0;
            this.materialSingleLineTextField13.Hint = "";
            this.materialSingleLineTextField13.Location = new System.Drawing.Point(261, 201);
            this.materialSingleLineTextField13.MaxLength = 32767;
            this.materialSingleLineTextField13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField13.Name = "materialSingleLineTextField13";
            this.materialSingleLineTextField13.PasswordChar = '\0';
            this.materialSingleLineTextField13.SelectedText = "";
            this.materialSingleLineTextField13.SelectionLength = 0;
            this.materialSingleLineTextField13.SelectionStart = 0;
            this.materialSingleLineTextField13.Size = new System.Drawing.Size(255, 25);
            this.materialSingleLineTextField13.TabIndex = 17;
            this.materialSingleLineTextField13.TabStop = false;
            this.materialSingleLineTextField13.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField12
            // 
            this.materialSingleLineTextField12.Depth = 0;
            this.materialSingleLineTextField12.Hint = "";
            this.materialSingleLineTextField12.Location = new System.Drawing.Point(261, 161);
            this.materialSingleLineTextField12.MaxLength = 32767;
            this.materialSingleLineTextField12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField12.Name = "materialSingleLineTextField12";
            this.materialSingleLineTextField12.PasswordChar = '\0';
            this.materialSingleLineTextField12.SelectedText = "";
            this.materialSingleLineTextField12.SelectionLength = 0;
            this.materialSingleLineTextField12.SelectionStart = 0;
            this.materialSingleLineTextField12.Size = new System.Drawing.Size(255, 25);
            this.materialSingleLineTextField12.TabIndex = 16;
            this.materialSingleLineTextField12.TabStop = false;
            this.materialSingleLineTextField12.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField11
            // 
            this.materialSingleLineTextField11.Depth = 0;
            this.materialSingleLineTextField11.Hint = "";
            this.materialSingleLineTextField11.Location = new System.Drawing.Point(261, 121);
            this.materialSingleLineTextField11.MaxLength = 32767;
            this.materialSingleLineTextField11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField11.Name = "materialSingleLineTextField11";
            this.materialSingleLineTextField11.PasswordChar = '\0';
            this.materialSingleLineTextField11.SelectedText = "";
            this.materialSingleLineTextField11.SelectionLength = 0;
            this.materialSingleLineTextField11.SelectionStart = 0;
            this.materialSingleLineTextField11.Size = new System.Drawing.Size(255, 25);
            this.materialSingleLineTextField11.TabIndex = 15;
            this.materialSingleLineTextField11.TabStop = false;
            this.materialSingleLineTextField11.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField10
            // 
            this.materialSingleLineTextField10.Depth = 0;
            this.materialSingleLineTextField10.Hint = "";
            this.materialSingleLineTextField10.Location = new System.Drawing.Point(261, 81);
            this.materialSingleLineTextField10.MaxLength = 32767;
            this.materialSingleLineTextField10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField10.Name = "materialSingleLineTextField10";
            this.materialSingleLineTextField10.PasswordChar = '\0';
            this.materialSingleLineTextField10.SelectedText = "";
            this.materialSingleLineTextField10.SelectionLength = 0;
            this.materialSingleLineTextField10.SelectionStart = 0;
            this.materialSingleLineTextField10.Size = new System.Drawing.Size(255, 25);
            this.materialSingleLineTextField10.TabIndex = 14;
            this.materialSingleLineTextField10.TabStop = false;
            this.materialSingleLineTextField10.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(261, 41);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(255, 25);
            this.materialSingleLineTextField3.TabIndex = 13;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(179, 246);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(39, 20);
            this.materialLabel17.TabIndex = 24;
            this.materialLabel17.Text = "类型";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(179, 166);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(39, 20);
            this.materialLabel16.TabIndex = 23;
            this.materialLabel16.Text = "地址";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(179, 206);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(39, 20);
            this.materialLabel15.TabIndex = 22;
            this.materialLabel15.Text = "密码";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(179, 126);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(39, 20);
            this.materialLabel14.TabIndex = 21;
            this.materialLabel14.Text = "性别";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(164, 86);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(54, 20);
            this.materialLabel13.TabIndex = 20;
            this.materialLabel13.Text = "用户名";
            // 
            // materialRaisedButton12
            // 
            this.materialRaisedButton12.Depth = 0;
            this.materialRaisedButton12.Location = new System.Drawing.Point(305, 315);
            this.materialRaisedButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton12.Name = "materialRaisedButton12";
            this.materialRaisedButton12.Primary = true;
            this.materialRaisedButton12.Size = new System.Drawing.Size(75, 30);
            this.materialRaisedButton12.TabIndex = 25;
            this.materialRaisedButton12.Text = "更新";
            this.materialRaisedButton12.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(241, 542);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton7.TabIndex = 11;
            this.materialRaisedButton7.Text = "上一页";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Visible = false;
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(429, 542);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton8.TabIndex = 12;
            this.materialRaisedButton8.Text = "下一页";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            this.materialRaisedButton8.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(361, 545);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 16);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "1/5";
            this.textBox5.Visible = false;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.Text = "图书馆管理系统-用户模式";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchText;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox4;
        private MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TabPage tabPage4;
        private MaterialLabel materialLabel1;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialRaisedButton materialRaisedButton3;
        private MaterialLabel materialLabel2;
        private MaterialRaisedButton materialRaisedButton4;
        private MaterialRaisedButton materialRaisedButton5;
        private MaterialRaisedButton materialRaisedButton6;
        private MaterialLabel materialLabel12;
        private MaterialSingleLineTextField materialSingleLineTextField14;
        private MaterialSingleLineTextField materialSingleLineTextField13;
        private MaterialSingleLineTextField materialSingleLineTextField12;
        private MaterialSingleLineTextField materialSingleLineTextField11;
        private MaterialSingleLineTextField materialSingleLineTextField10;
        private MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialLabel materialLabel17;
        private MaterialLabel materialLabel16;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel14;
        private MaterialLabel materialLabel13;
        private MaterialRaisedButton materialRaisedButton12;
        private TextBox textBox5;
        private MaterialRaisedButton materialRaisedButton8;
        private MaterialRaisedButton materialRaisedButton7;
    }
}

