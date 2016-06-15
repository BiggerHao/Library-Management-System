using MaterialSkin.Controls;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class AdminForm
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.bookBorrowReturnTab = new System.Windows.Forms.TabPage();
            this.status_page1 = new MaterialSkin.Controls.MaterialLabel();
            this.runButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bookEPCText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bookEPCLAbel = new MaterialSkin.Controls.MaterialLabel();
            this.userIDText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userIDLabel = new MaterialSkin.Controls.MaterialLabel();
            this.returnRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.borrowRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.borrowTypeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bookManTab = new System.Windows.Forms.TabPage();
            this.bookEPCRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.bookInfoRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.bookUpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bookDeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.yearText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.publisherText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.authorText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.typeText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.optionalText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ISBNLabelText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.optionalLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.optionalLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.optionalLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.optionalLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.optionalLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ISBNLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bookSearchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.status_page2 = new MaterialSkin.Controls.MaterialLabel();
            this.userManTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.readerRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.girlRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.boyRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.usrUpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usrDeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usrSearchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usrPwText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usrAddressText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usrNameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usrIDText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.status_page3 = new MaterialSkin.Controls.MaterialLabel();
            this.shelfManTab = new System.Windows.Forms.TabPage();
            this.inventoryText = new System.Windows.Forms.TextBox();
            this.statisticsButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.status_page4 = new MaterialSkin.Controls.MaterialLabel();
            this.unitEPCText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.unitText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.shelfText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.bookcaseText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.roomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.floorText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.shelfUpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.shelfDeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.shelfSearchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.statusTab = new System.Windows.Forms.TabPage();
            this.borrowReturnList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.organizingTab = new System.Windows.Forms.TabPage();
            this.inventoryListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.setTheme = new System.Windows.Forms.TabPage();
            this.adminModeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chMode = new MaterialSkin.Controls.MaterialLabel();
            this.bluegreySchemeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.greenSchemeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.blueSchemeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.nightModeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dayModeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.bookBorrowReturnTab.SuspendLayout();
            this.bookManTab.SuspendLayout();
            this.userManTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.shelfManTab.SuspendLayout();
            this.statusTab.SuspendLayout();
            this.organizingTab.SuspendLayout();
            this.setTheme.SuspendLayout();
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
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.bookBorrowReturnTab);
            this.materialTabControl1.Controls.Add(this.bookManTab);
            this.materialTabControl1.Controls.Add(this.userManTab);
            this.materialTabControl1.Controls.Add(this.shelfManTab);
            this.materialTabControl1.Controls.Add(this.statusTab);
            this.materialTabControl1.Controls.Add(this.organizingTab);
            this.materialTabControl1.Controls.Add(this.setTheme);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 109);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(776, 379);
            this.materialTabControl1.TabIndex = 18;
            // 
            // bookBorrowReturnTab
            // 
            this.bookBorrowReturnTab.BackColor = System.Drawing.Color.White;
            this.bookBorrowReturnTab.Controls.Add(this.status_page1);
            this.bookBorrowReturnTab.Controls.Add(this.runButton);
            this.bookBorrowReturnTab.Controls.Add(this.bookEPCText);
            this.bookBorrowReturnTab.Controls.Add(this.bookEPCLAbel);
            this.bookBorrowReturnTab.Controls.Add(this.userIDText);
            this.bookBorrowReturnTab.Controls.Add(this.userIDLabel);
            this.bookBorrowReturnTab.Controls.Add(this.returnRadioButton);
            this.bookBorrowReturnTab.Controls.Add(this.borrowRadioButton);
            this.bookBorrowReturnTab.Controls.Add(this.borrowTypeLabel);
            this.bookBorrowReturnTab.Location = new System.Drawing.Point(4, 26);
            this.bookBorrowReturnTab.Name = "bookBorrowReturnTab";
            this.bookBorrowReturnTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookBorrowReturnTab.Size = new System.Drawing.Size(768, 349);
            this.bookBorrowReturnTab.TabIndex = 0;
            this.bookBorrowReturnTab.Text = "图书借还";
            // 
            // status_page1
            // 
            this.status_page1.Depth = 0;
            this.status_page1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.status_page1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status_page1.Location = new System.Drawing.Point(3, 313);
            this.status_page1.MouseState = MaterialSkin.MouseState.HOVER;
            this.status_page1.Name = "status_page1";
            this.status_page1.Size = new System.Drawing.Size(762, 36);
            this.status_page1.TabIndex = 11;
            this.status_page1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Depth = 0;
            this.runButton.Location = new System.Drawing.Point(360, 224);
            this.runButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.runButton.Name = "runButton";
            this.runButton.Primary = true;
            this.runButton.Size = new System.Drawing.Size(80, 30);
            this.runButton.TabIndex = 10;
            this.runButton.Text = "执行";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // bookEPCText
            // 
            this.bookEPCText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bookEPCText.Depth = 0;
            this.bookEPCText.Hint = "请输入图书EPC";
            this.bookEPCText.Location = new System.Drawing.Point(314, 169);
            this.bookEPCText.MaxLength = 32767;
            this.bookEPCText.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookEPCText.Name = "bookEPCText";
            this.bookEPCText.PasswordChar = '\0';
            this.bookEPCText.SelectedText = "";
            this.bookEPCText.SelectionLength = 0;
            this.bookEPCText.SelectionStart = 0;
            this.bookEPCText.Size = new System.Drawing.Size(232, 25);
            this.bookEPCText.TabIndex = 9;
            this.bookEPCText.TabStop = false;
            this.bookEPCText.Text = "000047020000749C0000184D";
            this.bookEPCText.UseSystemPasswordChar = false;
            // 
            // bookEPCLAbel
            // 
            this.bookEPCLAbel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bookEPCLAbel.AutoSize = true;
            this.bookEPCLAbel.Depth = 0;
            this.bookEPCLAbel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.bookEPCLAbel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookEPCLAbel.Location = new System.Drawing.Point(237, 169);
            this.bookEPCLAbel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookEPCLAbel.Name = "bookEPCLAbel";
            this.bookEPCLAbel.Size = new System.Drawing.Size(66, 20);
            this.bookEPCLAbel.TabIndex = 8;
            this.bookEPCLAbel.Text = "图书EPC";
            // 
            // userIDText
            // 
            this.userIDText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userIDText.Depth = 0;
            this.userIDText.Hint = "请输入用户ID";
            this.userIDText.Location = new System.Drawing.Point(314, 119);
            this.userIDText.MaxLength = 32767;
            this.userIDText.MouseState = MaterialSkin.MouseState.HOVER;
            this.userIDText.Name = "userIDText";
            this.userIDText.PasswordChar = '\0';
            this.userIDText.SelectedText = "";
            this.userIDText.SelectionLength = 0;
            this.userIDText.SelectionStart = 0;
            this.userIDText.Size = new System.Drawing.Size(162, 25);
            this.userIDText.TabIndex = 7;
            this.userIDText.TabStop = false;
            this.userIDText.Text = "13061190";
            this.userIDText.UseSystemPasswordChar = false;
            // 
            // userIDLabel
            // 
            this.userIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Depth = 0;
            this.userIDLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.userIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userIDLabel.Location = new System.Drawing.Point(237, 119);
            this.userIDLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(54, 20);
            this.userIDLabel.TabIndex = 6;
            this.userIDLabel.Text = "用户ID";
            // 
            // returnRadioButton
            // 
            this.returnRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.returnRadioButton.AutoSize = true;
            this.returnRadioButton.Depth = 0;
            this.returnRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.returnRadioButton.Location = new System.Drawing.Point(379, 64);
            this.returnRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.returnRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.returnRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.returnRadioButton.Name = "returnRadioButton";
            this.returnRadioButton.Ripple = true;
            this.returnRadioButton.Size = new System.Drawing.Size(56, 30);
            this.returnRadioButton.TabIndex = 5;
            this.returnRadioButton.TabStop = true;
            this.returnRadioButton.Text = "还书";
            this.returnRadioButton.UseVisualStyleBackColor = true;
            // 
            // borrowRadioButton
            // 
            this.borrowRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowRadioButton.AutoSize = true;
            this.borrowRadioButton.Checked = true;
            this.borrowRadioButton.Depth = 0;
            this.borrowRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.borrowRadioButton.Location = new System.Drawing.Point(294, 64);
            this.borrowRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.borrowRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.borrowRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.borrowRadioButton.Name = "borrowRadioButton";
            this.borrowRadioButton.Ripple = true;
            this.borrowRadioButton.Size = new System.Drawing.Size(56, 30);
            this.borrowRadioButton.TabIndex = 4;
            this.borrowRadioButton.TabStop = true;
            this.borrowRadioButton.Text = "借书";
            this.borrowRadioButton.UseVisualStyleBackColor = true;
            // 
            // borrowTypeLabel
            // 
            this.borrowTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowTypeLabel.AutoSize = true;
            this.borrowTypeLabel.Depth = 0;
            this.borrowTypeLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.borrowTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.borrowTypeLabel.Location = new System.Drawing.Point(237, 69);
            this.borrowTypeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.borrowTypeLabel.Name = "borrowTypeLabel";
            this.borrowTypeLabel.Size = new System.Drawing.Size(39, 20);
            this.borrowTypeLabel.TabIndex = 3;
            this.borrowTypeLabel.Text = "类型";
            // 
            // bookManTab
            // 
            this.bookManTab.BackColor = System.Drawing.Color.White;
            this.bookManTab.Controls.Add(this.bookEPCRadioButton);
            this.bookManTab.Controls.Add(this.bookInfoRadioButton);
            this.bookManTab.Controls.Add(this.bookUpdateButton);
            this.bookManTab.Controls.Add(this.bookDeleteButton);
            this.bookManTab.Controls.Add(this.yearText);
            this.bookManTab.Controls.Add(this.publisherText);
            this.bookManTab.Controls.Add(this.authorText);
            this.bookManTab.Controls.Add(this.typeText);
            this.bookManTab.Controls.Add(this.optionalText);
            this.bookManTab.Controls.Add(this.ISBNLabelText);
            this.bookManTab.Controls.Add(this.optionalLabel5);
            this.bookManTab.Controls.Add(this.optionalLabel4);
            this.bookManTab.Controls.Add(this.optionalLabel3);
            this.bookManTab.Controls.Add(this.optionalLabel2);
            this.bookManTab.Controls.Add(this.optionalLabel1);
            this.bookManTab.Controls.Add(this.ISBNLabel);
            this.bookManTab.Controls.Add(this.bookSearchButton);
            this.bookManTab.Controls.Add(this.status_page2);
            this.bookManTab.Location = new System.Drawing.Point(4, 26);
            this.bookManTab.Name = "bookManTab";
            this.bookManTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookManTab.Size = new System.Drawing.Size(768, 349);
            this.bookManTab.TabIndex = 1;
            this.bookManTab.Text = "图书管理";
            // 
            // bookEPCRadioButton
            // 
            this.bookEPCRadioButton.AutoSize = true;
            this.bookEPCRadioButton.Depth = 0;
            this.bookEPCRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bookEPCRadioButton.Location = new System.Drawing.Point(402, 3);
            this.bookEPCRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.bookEPCRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bookEPCRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookEPCRadioButton.Name = "bookEPCRadioButton";
            this.bookEPCRadioButton.Ripple = true;
            this.bookEPCRadioButton.Size = new System.Drawing.Size(111, 30);
            this.bookEPCRadioButton.TabIndex = 18;
            this.bookEPCRadioButton.Text = "图书标签管理";
            this.bookEPCRadioButton.UseVisualStyleBackColor = true;
            this.bookEPCRadioButton.CheckedChanged += new System.EventHandler(this.bookEPCRadioButton_CheckedChanged);
            // 
            // bookInfoRadioButton
            // 
            this.bookInfoRadioButton.AutoSize = true;
            this.bookInfoRadioButton.Checked = true;
            this.bookInfoRadioButton.Depth = 0;
            this.bookInfoRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bookInfoRadioButton.Location = new System.Drawing.Point(258, 3);
            this.bookInfoRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.bookInfoRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bookInfoRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookInfoRadioButton.Name = "bookInfoRadioButton";
            this.bookInfoRadioButton.Ripple = true;
            this.bookInfoRadioButton.Size = new System.Drawing.Size(111, 30);
            this.bookInfoRadioButton.TabIndex = 17;
            this.bookInfoRadioButton.TabStop = true;
            this.bookInfoRadioButton.Text = "基本信息管理";
            this.bookInfoRadioButton.UseVisualStyleBackColor = true;
            this.bookInfoRadioButton.CheckedChanged += new System.EventHandler(this.bookInfoRadioButton_CheckedChanged);
            // 
            // bookUpdateButton
            // 
            this.bookUpdateButton.Depth = 0;
            this.bookUpdateButton.Location = new System.Drawing.Point(438, 285);
            this.bookUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookUpdateButton.Name = "bookUpdateButton";
            this.bookUpdateButton.Primary = true;
            this.bookUpdateButton.Size = new System.Drawing.Size(75, 30);
            this.bookUpdateButton.TabIndex = 16;
            this.bookUpdateButton.Text = "更新";
            this.bookUpdateButton.UseVisualStyleBackColor = true;
            this.bookUpdateButton.Click += new System.EventHandler(this.bookUpdateButton_Click);
            // 
            // bookDeleteButton
            // 
            this.bookDeleteButton.Depth = 0;
            this.bookDeleteButton.Location = new System.Drawing.Point(258, 285);
            this.bookDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookDeleteButton.Name = "bookDeleteButton";
            this.bookDeleteButton.Primary = true;
            this.bookDeleteButton.Size = new System.Drawing.Size(75, 30);
            this.bookDeleteButton.TabIndex = 15;
            this.bookDeleteButton.Text = "删除";
            this.bookDeleteButton.UseVisualStyleBackColor = true;
            this.bookDeleteButton.Click += new System.EventHandler(this.bookDeleteButton_Click);
            // 
            // yearText
            // 
            this.yearText.Depth = 0;
            this.yearText.Hint = "";
            this.yearText.Location = new System.Drawing.Point(258, 242);
            this.yearText.MaxLength = 32767;
            this.yearText.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearText.Name = "yearText";
            this.yearText.PasswordChar = '\0';
            this.yearText.SelectedText = "";
            this.yearText.SelectionLength = 0;
            this.yearText.SelectionStart = 0;
            this.yearText.Size = new System.Drawing.Size(255, 25);
            this.yearText.TabIndex = 14;
            this.yearText.TabStop = false;
            this.yearText.UseSystemPasswordChar = false;
            // 
            // publisherText
            // 
            this.publisherText.Depth = 0;
            this.publisherText.Hint = "";
            this.publisherText.Location = new System.Drawing.Point(258, 202);
            this.publisherText.MaxLength = 32767;
            this.publisherText.MouseState = MaterialSkin.MouseState.HOVER;
            this.publisherText.Name = "publisherText";
            this.publisherText.PasswordChar = '\0';
            this.publisherText.SelectedText = "";
            this.publisherText.SelectionLength = 0;
            this.publisherText.SelectionStart = 0;
            this.publisherText.Size = new System.Drawing.Size(255, 25);
            this.publisherText.TabIndex = 13;
            this.publisherText.TabStop = false;
            this.publisherText.UseSystemPasswordChar = false;
            // 
            // authorText
            // 
            this.authorText.Depth = 0;
            this.authorText.Hint = "";
            this.authorText.Location = new System.Drawing.Point(258, 162);
            this.authorText.MaxLength = 32767;
            this.authorText.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorText.Name = "authorText";
            this.authorText.PasswordChar = '\0';
            this.authorText.SelectedText = "";
            this.authorText.SelectionLength = 0;
            this.authorText.SelectionStart = 0;
            this.authorText.Size = new System.Drawing.Size(255, 25);
            this.authorText.TabIndex = 12;
            this.authorText.TabStop = false;
            this.authorText.UseSystemPasswordChar = false;
            // 
            // typeText
            // 
            this.typeText.Depth = 0;
            this.typeText.Hint = "";
            this.typeText.Location = new System.Drawing.Point(258, 122);
            this.typeText.MaxLength = 32767;
            this.typeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.typeText.Name = "typeText";
            this.typeText.PasswordChar = '\0';
            this.typeText.SelectedText = "";
            this.typeText.SelectionLength = 0;
            this.typeText.SelectionStart = 0;
            this.typeText.Size = new System.Drawing.Size(255, 25);
            this.typeText.TabIndex = 11;
            this.typeText.TabStop = false;
            this.typeText.UseSystemPasswordChar = false;
            // 
            // optionalText
            // 
            this.optionalText.Depth = 0;
            this.optionalText.Hint = "";
            this.optionalText.Location = new System.Drawing.Point(258, 82);
            this.optionalText.MaxLength = 32767;
            this.optionalText.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionalText.Name = "optionalText";
            this.optionalText.PasswordChar = '\0';
            this.optionalText.SelectedText = "";
            this.optionalText.SelectionLength = 0;
            this.optionalText.SelectionStart = 0;
            this.optionalText.Size = new System.Drawing.Size(255, 25);
            this.optionalText.TabIndex = 10;
            this.optionalText.TabStop = false;
            this.optionalText.UseSystemPasswordChar = false;
            // 
            // ISBNLabelText
            // 
            this.ISBNLabelText.Depth = 0;
            this.ISBNLabelText.Hint = "";
            this.ISBNLabelText.Location = new System.Drawing.Point(258, 42);
            this.ISBNLabelText.MaxLength = 32767;
            this.ISBNLabelText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ISBNLabelText.Name = "ISBNLabelText";
            this.ISBNLabelText.PasswordChar = '\0';
            this.ISBNLabelText.SelectedText = "";
            this.ISBNLabelText.SelectionLength = 0;
            this.ISBNLabelText.SelectionStart = 0;
            this.ISBNLabelText.Size = new System.Drawing.Size(255, 25);
            this.ISBNLabelText.TabIndex = 9;
            this.ISBNLabelText.TabStop = false;
            this.ISBNLabelText.Text = "978-7-5133-1292-9";
            this.ISBNLabelText.UseSystemPasswordChar = false;
            // 
            // optionalLabel5
            // 
            this.optionalLabel5.AutoSize = true;
            this.optionalLabel5.Depth = 0;
            this.optionalLabel5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.optionalLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optionalLabel5.Location = new System.Drawing.Point(162, 242);
            this.optionalLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionalLabel5.Name = "optionalLabel5";
            this.optionalLabel5.Size = new System.Drawing.Size(69, 20);
            this.optionalLabel5.TabIndex = 8;
            this.optionalLabel5.Text = "出版年份";
            // 
            // optionalLabel4
            // 
            this.optionalLabel4.AutoSize = true;
            this.optionalLabel4.Depth = 0;
            this.optionalLabel4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.optionalLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optionalLabel4.Location = new System.Drawing.Point(177, 202);
            this.optionalLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionalLabel4.Name = "optionalLabel4";
            this.optionalLabel4.Size = new System.Drawing.Size(54, 20);
            this.optionalLabel4.TabIndex = 7;
            this.optionalLabel4.Text = "出版社";
            // 
            // optionalLabel3
            // 
            this.optionalLabel3.AutoSize = true;
            this.optionalLabel3.Depth = 0;
            this.optionalLabel3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.optionalLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optionalLabel3.Location = new System.Drawing.Point(192, 162);
            this.optionalLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionalLabel3.Name = "optionalLabel3";
            this.optionalLabel3.Size = new System.Drawing.Size(39, 20);
            this.optionalLabel3.TabIndex = 6;
            this.optionalLabel3.Text = "作者";
            // 
            // optionalLabel2
            // 
            this.optionalLabel2.AutoSize = true;
            this.optionalLabel2.Depth = 0;
            this.optionalLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.optionalLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optionalLabel2.Location = new System.Drawing.Point(192, 122);
            this.optionalLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionalLabel2.Name = "optionalLabel2";
            this.optionalLabel2.Size = new System.Drawing.Size(39, 20);
            this.optionalLabel2.TabIndex = 5;
            this.optionalLabel2.Text = "类型";
            // 
            // optionalLabel1
            // 
            this.optionalLabel1.AutoSize = true;
            this.optionalLabel1.Depth = 0;
            this.optionalLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.optionalLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optionalLabel1.Location = new System.Drawing.Point(185, 82);
            this.optionalLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionalLabel1.Name = "optionalLabel1";
            this.optionalLabel1.Size = new System.Drawing.Size(46, 20);
            this.optionalLabel1.TabIndex = 4;
            this.optionalLabel1.Text = "*题名";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Depth = 0;
            this.ISBNLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.ISBNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ISBNLabel.Location = new System.Drawing.Point(181, 42);
            this.ISBNLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(50, 20);
            this.ISBNLabel.TabIndex = 3;
            this.ISBNLabel.Text = "*ISBN";
            // 
            // bookSearchButton
            // 
            this.bookSearchButton.Depth = 0;
            this.bookSearchButton.Location = new System.Drawing.Point(555, 38);
            this.bookSearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookSearchButton.Name = "bookSearchButton";
            this.bookSearchButton.Primary = true;
            this.bookSearchButton.Size = new System.Drawing.Size(75, 30);
            this.bookSearchButton.TabIndex = 2;
            this.bookSearchButton.Text = "搜索";
            this.bookSearchButton.UseVisualStyleBackColor = true;
            this.bookSearchButton.Click += new System.EventHandler(this.bookSearchButton_Click);
            // 
            // status_page2
            // 
            this.status_page2.Depth = 0;
            this.status_page2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.status_page2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status_page2.Location = new System.Drawing.Point(3, 313);
            this.status_page2.MouseState = MaterialSkin.MouseState.HOVER;
            this.status_page2.Name = "status_page2";
            this.status_page2.Size = new System.Drawing.Size(762, 36);
            this.status_page2.TabIndex = 17;
            this.status_page2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userManTab
            // 
            this.userManTab.BackColor = System.Drawing.Color.White;
            this.userManTab.Controls.Add(this.panel2);
            this.userManTab.Controls.Add(this.panel1);
            this.userManTab.Controls.Add(this.usrUpdateButton);
            this.userManTab.Controls.Add(this.usrDeleteButton);
            this.userManTab.Controls.Add(this.usrSearchButton);
            this.userManTab.Controls.Add(this.usrPwText);
            this.userManTab.Controls.Add(this.usrAddressText);
            this.userManTab.Controls.Add(this.usrNameText);
            this.userManTab.Controls.Add(this.usrIDText);
            this.userManTab.Controls.Add(this.materialLabel17);
            this.userManTab.Controls.Add(this.materialLabel16);
            this.userManTab.Controls.Add(this.materialLabel15);
            this.userManTab.Controls.Add(this.materialLabel14);
            this.userManTab.Controls.Add(this.materialLabel13);
            this.userManTab.Controls.Add(this.materialLabel12);
            this.userManTab.Controls.Add(this.status_page3);
            this.userManTab.Location = new System.Drawing.Point(4, 26);
            this.userManTab.Name = "userManTab";
            this.userManTab.Size = new System.Drawing.Size(768, 349);
            this.userManTab.TabIndex = 2;
            this.userManTab.Text = "用户管理";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adminRadioButton);
            this.panel2.Controls.Add(this.readerRadioButton);
            this.panel2.Location = new System.Drawing.Point(258, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 43);
            this.panel2.TabIndex = 28;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Depth = 0;
            this.adminRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.adminRadioButton.Location = new System.Drawing.Point(112, 4);
            this.adminRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.adminRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.adminRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Ripple = true;
            this.adminRadioButton.Size = new System.Drawing.Size(70, 30);
            this.adminRadioButton.TabIndex = 2;
            this.adminRadioButton.Text = "管理员";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // readerRadioButton
            // 
            this.readerRadioButton.AutoSize = true;
            this.readerRadioButton.Checked = true;
            this.readerRadioButton.Depth = 0;
            this.readerRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.readerRadioButton.Location = new System.Drawing.Point(6, 4);
            this.readerRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.readerRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.readerRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.readerRadioButton.Name = "readerRadioButton";
            this.readerRadioButton.Ripple = true;
            this.readerRadioButton.Size = new System.Drawing.Size(56, 30);
            this.readerRadioButton.TabIndex = 1;
            this.readerRadioButton.TabStop = true;
            this.readerRadioButton.Text = "读者";
            this.readerRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.girlRadioButton);
            this.panel1.Controls.Add(this.boyRadioButton);
            this.panel1.Location = new System.Drawing.Point(258, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 43);
            this.panel1.TabIndex = 27;
            // 
            // girlRadioButton
            // 
            this.girlRadioButton.AutoSize = true;
            this.girlRadioButton.Depth = 0;
            this.girlRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.girlRadioButton.Location = new System.Drawing.Point(112, 4);
            this.girlRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.girlRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.girlRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.girlRadioButton.Name = "girlRadioButton";
            this.girlRadioButton.Ripple = true;
            this.girlRadioButton.Size = new System.Drawing.Size(43, 30);
            this.girlRadioButton.TabIndex = 1;
            this.girlRadioButton.Text = "女";
            this.girlRadioButton.UseVisualStyleBackColor = true;
            // 
            // boyRadioButton
            // 
            this.boyRadioButton.AutoSize = true;
            this.boyRadioButton.Checked = true;
            this.boyRadioButton.Depth = 0;
            this.boyRadioButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.boyRadioButton.Location = new System.Drawing.Point(6, 4);
            this.boyRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.boyRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.boyRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.boyRadioButton.Name = "boyRadioButton";
            this.boyRadioButton.Ripple = true;
            this.boyRadioButton.Size = new System.Drawing.Size(43, 30);
            this.boyRadioButton.TabIndex = 0;
            this.boyRadioButton.TabStop = true;
            this.boyRadioButton.Text = "男";
            this.boyRadioButton.UseVisualStyleBackColor = true;
            // 
            // usrUpdateButton
            // 
            this.usrUpdateButton.Depth = 0;
            this.usrUpdateButton.Location = new System.Drawing.Point(438, 285);
            this.usrUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrUpdateButton.Name = "usrUpdateButton";
            this.usrUpdateButton.Primary = true;
            this.usrUpdateButton.Size = new System.Drawing.Size(75, 30);
            this.usrUpdateButton.TabIndex = 14;
            this.usrUpdateButton.Text = "更新";
            this.usrUpdateButton.UseVisualStyleBackColor = true;
            this.usrUpdateButton.Click += new System.EventHandler(this.usrUpdateButton_Click);
            // 
            // usrDeleteButton
            // 
            this.usrDeleteButton.Depth = 0;
            this.usrDeleteButton.Location = new System.Drawing.Point(258, 285);
            this.usrDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrDeleteButton.Name = "usrDeleteButton";
            this.usrDeleteButton.Primary = true;
            this.usrDeleteButton.Size = new System.Drawing.Size(75, 30);
            this.usrDeleteButton.TabIndex = 13;
            this.usrDeleteButton.Text = "删除";
            this.usrDeleteButton.UseVisualStyleBackColor = true;
            this.usrDeleteButton.Click += new System.EventHandler(this.usrDeleteButton_Click);
            // 
            // usrSearchButton
            // 
            this.usrSearchButton.Depth = 0;
            this.usrSearchButton.Location = new System.Drawing.Point(555, 38);
            this.usrSearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrSearchButton.Name = "usrSearchButton";
            this.usrSearchButton.Primary = true;
            this.usrSearchButton.Size = new System.Drawing.Size(75, 30);
            this.usrSearchButton.TabIndex = 12;
            this.usrSearchButton.Text = "搜索";
            this.usrSearchButton.UseVisualStyleBackColor = true;
            this.usrSearchButton.Click += new System.EventHandler(this.usrSearchButton_Click);
            // 
            // usrPwText
            // 
            this.usrPwText.Depth = 0;
            this.usrPwText.Hint = "";
            this.usrPwText.Location = new System.Drawing.Point(258, 202);
            this.usrPwText.MaxLength = 32767;
            this.usrPwText.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrPwText.Name = "usrPwText";
            this.usrPwText.PasswordChar = '\0';
            this.usrPwText.SelectedText = "";
            this.usrPwText.SelectionLength = 0;
            this.usrPwText.SelectionStart = 0;
            this.usrPwText.Size = new System.Drawing.Size(255, 25);
            this.usrPwText.TabIndex = 10;
            this.usrPwText.TabStop = false;
            this.usrPwText.UseSystemPasswordChar = false;
            // 
            // usrAddressText
            // 
            this.usrAddressText.Depth = 0;
            this.usrAddressText.Hint = "";
            this.usrAddressText.Location = new System.Drawing.Point(258, 162);
            this.usrAddressText.MaxLength = 32767;
            this.usrAddressText.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrAddressText.Name = "usrAddressText";
            this.usrAddressText.PasswordChar = '\0';
            this.usrAddressText.SelectedText = "";
            this.usrAddressText.SelectionLength = 0;
            this.usrAddressText.SelectionStart = 0;
            this.usrAddressText.Size = new System.Drawing.Size(255, 25);
            this.usrAddressText.TabIndex = 9;
            this.usrAddressText.TabStop = false;
            this.usrAddressText.UseSystemPasswordChar = false;
            // 
            // usrNameText
            // 
            this.usrNameText.Depth = 0;
            this.usrNameText.Hint = "";
            this.usrNameText.Location = new System.Drawing.Point(258, 82);
            this.usrNameText.MaxLength = 32767;
            this.usrNameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrNameText.Name = "usrNameText";
            this.usrNameText.PasswordChar = '\0';
            this.usrNameText.SelectedText = "";
            this.usrNameText.SelectionLength = 0;
            this.usrNameText.SelectionStart = 0;
            this.usrNameText.Size = new System.Drawing.Size(255, 25);
            this.usrNameText.TabIndex = 7;
            this.usrNameText.TabStop = false;
            this.usrNameText.UseSystemPasswordChar = false;
            // 
            // usrIDText
            // 
            this.usrIDText.Depth = 0;
            this.usrIDText.Hint = "";
            this.usrIDText.Location = new System.Drawing.Point(258, 42);
            this.usrIDText.MaxLength = 32767;
            this.usrIDText.MouseState = MaterialSkin.MouseState.HOVER;
            this.usrIDText.Name = "usrIDText";
            this.usrIDText.PasswordChar = '\0';
            this.usrIDText.SelectedText = "";
            this.usrIDText.SelectionLength = 0;
            this.usrIDText.SelectionStart = 0;
            this.usrIDText.Size = new System.Drawing.Size(255, 25);
            this.usrIDText.TabIndex = 6;
            this.usrIDText.TabStop = false;
            this.usrIDText.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(186, 242);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(46, 20);
            this.materialLabel17.TabIndex = 5;
            this.materialLabel17.Text = "*类型";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(193, 162);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(39, 20);
            this.materialLabel16.TabIndex = 4;
            this.materialLabel16.Text = "地址";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(186, 202);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(46, 20);
            this.materialLabel15.TabIndex = 3;
            this.materialLabel15.Text = "*密码";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(186, 122);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(46, 20);
            this.materialLabel14.TabIndex = 2;
            this.materialLabel14.Text = "*性别";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(171, 82);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(61, 20);
            this.materialLabel13.TabIndex = 1;
            this.materialLabel13.Text = "*用户名";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(171, 42);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(61, 20);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "*用户ID";
            // 
            // status_page3
            // 
            this.status_page3.Depth = 0;
            this.status_page3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.status_page3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status_page3.Location = new System.Drawing.Point(3, 313);
            this.status_page3.MouseState = MaterialSkin.MouseState.HOVER;
            this.status_page3.Name = "status_page3";
            this.status_page3.Size = new System.Drawing.Size(762, 36);
            this.status_page3.TabIndex = 18;
            this.status_page3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shelfManTab
            // 
            this.shelfManTab.BackColor = System.Drawing.Color.White;
            this.shelfManTab.Controls.Add(this.inventoryText);
            this.shelfManTab.Controls.Add(this.statisticsButton);
            this.shelfManTab.Controls.Add(this.status_page4);
            this.shelfManTab.Controls.Add(this.unitEPCText);
            this.shelfManTab.Controls.Add(this.unitText);
            this.shelfManTab.Controls.Add(this.materialLabel3);
            this.shelfManTab.Controls.Add(this.shelfText);
            this.shelfManTab.Controls.Add(this.materialLabel6);
            this.shelfManTab.Controls.Add(this.bookcaseText);
            this.shelfManTab.Controls.Add(this.materialLabel5);
            this.shelfManTab.Controls.Add(this.roomText);
            this.shelfManTab.Controls.Add(this.materialLabel4);
            this.shelfManTab.Controls.Add(this.floorText);
            this.shelfManTab.Controls.Add(this.shelfUpdateButton);
            this.shelfManTab.Controls.Add(this.shelfDeleteButton);
            this.shelfManTab.Controls.Add(this.shelfSearchButton);
            this.shelfManTab.Controls.Add(this.materialLabel19);
            this.shelfManTab.Controls.Add(this.materialLabel18);
            this.shelfManTab.Location = new System.Drawing.Point(4, 26);
            this.shelfManTab.Name = "shelfManTab";
            this.shelfManTab.Size = new System.Drawing.Size(768, 349);
            this.shelfManTab.TabIndex = 4;
            this.shelfManTab.Text = "书架管理";
            // 
            // inventoryText
            // 
            this.inventoryText.Location = new System.Drawing.Point(182, 178);
            this.inventoryText.Multiline = true;
            this.inventoryText.Name = "inventoryText";
            this.inventoryText.Size = new System.Drawing.Size(436, 143);
            this.inventoryText.TabIndex = 21;
            this.inventoryText.Text = "盘点结果";
            // 
            // statisticsButton
            // 
            this.statisticsButton.Depth = 0;
            this.statisticsButton.Location = new System.Drawing.Point(650, 38);
            this.statisticsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Primary = true;
            this.statisticsButton.Size = new System.Drawing.Size(75, 30);
            this.statisticsButton.TabIndex = 20;
            this.statisticsButton.Text = "盘点";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // status_page4
            // 
            this.status_page4.Depth = 0;
            this.status_page4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.status_page4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status_page4.Location = new System.Drawing.Point(3, 313);
            this.status_page4.MouseState = MaterialSkin.MouseState.HOVER;
            this.status_page4.Name = "status_page4";
            this.status_page4.Size = new System.Drawing.Size(762, 36);
            this.status_page4.TabIndex = 18;
            this.status_page4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitEPCText
            // 
            this.unitEPCText.Depth = 0;
            this.unitEPCText.Hint = "";
            this.unitEPCText.Location = new System.Drawing.Point(258, 82);
            this.unitEPCText.MaxLength = 32767;
            this.unitEPCText.MouseState = MaterialSkin.MouseState.HOVER;
            this.unitEPCText.Name = "unitEPCText";
            this.unitEPCText.PasswordChar = '\0';
            this.unitEPCText.SelectedText = "";
            this.unitEPCText.SelectionLength = 0;
            this.unitEPCText.SelectionStart = 0;
            this.unitEPCText.Size = new System.Drawing.Size(255, 25);
            this.unitEPCText.TabIndex = 18;
            this.unitEPCText.TabStop = false;
            this.unitEPCText.UseSystemPasswordChar = false;
            // 
            // unitText
            // 
            this.unitText.Depth = 0;
            this.unitText.Hint = "单元";
            this.unitText.Location = new System.Drawing.Point(490, 41);
            this.unitText.MaxLength = 32767;
            this.unitText.MouseState = MaterialSkin.MouseState.HOVER;
            this.unitText.Name = "unitText";
            this.unitText.PasswordChar = '\0';
            this.unitText.SelectedText = "";
            this.unitText.SelectionLength = 0;
            this.unitText.SelectionStart = 0;
            this.unitText.Size = new System.Drawing.Size(31, 25);
            this.unitText.TabIndex = 17;
            this.unitText.TabStop = false;
            this.unitText.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(469, 42);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(15, 20);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "-";
            // 
            // shelfText
            // 
            this.shelfText.Depth = 0;
            this.shelfText.Hint = "层数";
            this.shelfText.Location = new System.Drawing.Point(432, 41);
            this.shelfText.MaxLength = 32767;
            this.shelfText.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfText.Name = "shelfText";
            this.shelfText.PasswordChar = '\0';
            this.shelfText.SelectedText = "";
            this.shelfText.SelectionLength = 0;
            this.shelfText.SelectionStart = 0;
            this.shelfText.Size = new System.Drawing.Size(31, 25);
            this.shelfText.TabIndex = 14;
            this.shelfText.TabStop = false;
            this.shelfText.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(411, 41);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(15, 20);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "-";
            // 
            // bookcaseText
            // 
            this.bookcaseText.Depth = 0;
            this.bookcaseText.Hint = "书架";
            this.bookcaseText.Location = new System.Drawing.Point(374, 41);
            this.bookcaseText.MaxLength = 32767;
            this.bookcaseText.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookcaseText.Name = "bookcaseText";
            this.bookcaseText.PasswordChar = '\0';
            this.bookcaseText.SelectedText = "";
            this.bookcaseText.SelectionLength = 0;
            this.bookcaseText.SelectionStart = 0;
            this.bookcaseText.Size = new System.Drawing.Size(31, 25);
            this.bookcaseText.TabIndex = 12;
            this.bookcaseText.TabStop = false;
            this.bookcaseText.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(353, 42);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(15, 20);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "-";
            // 
            // roomText
            // 
            this.roomText.Depth = 0;
            this.roomText.Hint = "房间";
            this.roomText.Location = new System.Drawing.Point(316, 41);
            this.roomText.MaxLength = 32767;
            this.roomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomText.Name = "roomText";
            this.roomText.PasswordChar = '\0';
            this.roomText.SelectedText = "";
            this.roomText.SelectionLength = 0;
            this.roomText.SelectionStart = 0;
            this.roomText.Size = new System.Drawing.Size(31, 25);
            this.roomText.TabIndex = 10;
            this.roomText.TabStop = false;
            this.roomText.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(295, 41);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(15, 20);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "-";
            // 
            // floorText
            // 
            this.floorText.Depth = 0;
            this.floorText.Hint = "楼层";
            this.floorText.Location = new System.Drawing.Point(258, 42);
            this.floorText.MaxLength = 32767;
            this.floorText.MouseState = MaterialSkin.MouseState.HOVER;
            this.floorText.Name = "floorText";
            this.floorText.PasswordChar = '\0';
            this.floorText.SelectedText = "";
            this.floorText.SelectionLength = 0;
            this.floorText.SelectionStart = 0;
            this.floorText.Size = new System.Drawing.Size(31, 25);
            this.floorText.TabIndex = 8;
            this.floorText.TabStop = false;
            this.floorText.UseSystemPasswordChar = false;
            // 
            // shelfUpdateButton
            // 
            this.shelfUpdateButton.Depth = 0;
            this.shelfUpdateButton.Location = new System.Drawing.Point(438, 127);
            this.shelfUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfUpdateButton.Name = "shelfUpdateButton";
            this.shelfUpdateButton.Primary = true;
            this.shelfUpdateButton.Size = new System.Drawing.Size(75, 30);
            this.shelfUpdateButton.TabIndex = 6;
            this.shelfUpdateButton.Text = "更新";
            this.shelfUpdateButton.UseVisualStyleBackColor = true;
            this.shelfUpdateButton.Click += new System.EventHandler(this.shelfUpdateButton_Click);
            // 
            // shelfDeleteButton
            // 
            this.shelfDeleteButton.Depth = 0;
            this.shelfDeleteButton.Location = new System.Drawing.Point(258, 127);
            this.shelfDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfDeleteButton.Name = "shelfDeleteButton";
            this.shelfDeleteButton.Primary = true;
            this.shelfDeleteButton.Size = new System.Drawing.Size(75, 30);
            this.shelfDeleteButton.TabIndex = 5;
            this.shelfDeleteButton.Text = "删除";
            this.shelfDeleteButton.UseVisualStyleBackColor = true;
            this.shelfDeleteButton.Click += new System.EventHandler(this.shelfDeleteButton_Click);
            // 
            // shelfSearchButton
            // 
            this.shelfSearchButton.Depth = 0;
            this.shelfSearchButton.Location = new System.Drawing.Point(555, 38);
            this.shelfSearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.shelfSearchButton.Name = "shelfSearchButton";
            this.shelfSearchButton.Primary = true;
            this.shelfSearchButton.Size = new System.Drawing.Size(75, 30);
            this.shelfSearchButton.TabIndex = 4;
            this.shelfSearchButton.Text = "搜索";
            this.shelfSearchButton.UseVisualStyleBackColor = true;
            this.shelfSearchButton.Click += new System.EventHandler(this.shelfSearchButton_Click);
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(193, 87);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(36, 20);
            this.materialLabel19.TabIndex = 1;
            this.materialLabel19.Text = "EPC";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(178, 42);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(54, 20);
            this.materialLabel18.TabIndex = 0;
            this.materialLabel18.Text = "书架ID";
            // 
            // statusTab
            // 
            this.statusTab.BackColor = System.Drawing.Color.White;
            this.statusTab.Controls.Add(this.borrowReturnList);
            this.statusTab.Location = new System.Drawing.Point(4, 26);
            this.statusTab.Name = "statusTab";
            this.statusTab.Size = new System.Drawing.Size(768, 349);
            this.statusTab.TabIndex = 5;
            this.statusTab.Text = "实时借还状态";
            // 
            // borrowReturnList
            // 
            this.borrowReturnList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowReturnList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.borrowReturnList.Depth = 0;
            this.borrowReturnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowReturnList.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.borrowReturnList.FullRowSelect = true;
            this.borrowReturnList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.borrowReturnList.Location = new System.Drawing.Point(0, 0);
            this.borrowReturnList.MouseLocation = new System.Drawing.Point(0, 0);
            this.borrowReturnList.MouseState = MaterialSkin.MouseState.HOVER;
            this.borrowReturnList.Name = "borrowReturnList";
            this.borrowReturnList.OwnerDraw = true;
            this.borrowReturnList.Size = new System.Drawing.Size(768, 349);
            this.borrowReturnList.TabIndex = 0;
            this.borrowReturnList.UseCompatibleStateImageBehavior = false;
            this.borrowReturnList.View = System.Windows.Forms.View.Details;
            this.borrowReturnList.SelectedIndexChanged += new System.EventHandler(this.borrowReturnList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户ID";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "图书ISBN";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "方式";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "时间";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "借/还";
            this.columnHeader5.Width = 70;
            // 
            // organizingTab
            // 
            this.organizingTab.Controls.Add(this.inventoryListView);
            this.organizingTab.Location = new System.Drawing.Point(4, 26);
            this.organizingTab.Name = "organizingTab";
            this.organizingTab.Size = new System.Drawing.Size(768, 349);
            this.organizingTab.TabIndex = 7;
            this.organizingTab.Text = "图书整理";
            this.organizingTab.UseVisualStyleBackColor = true;
            // 
            // inventoryListView
            // 
            this.inventoryListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.inventoryListView.Depth = 0;
            this.inventoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryListView.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.inventoryListView.FullRowSelect = true;
            this.inventoryListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.inventoryListView.Location = new System.Drawing.Point(0, 0);
            this.inventoryListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.inventoryListView.MouseState = MaterialSkin.MouseState.OUT;
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.OwnerDraw = true;
            this.inventoryListView.Size = new System.Drawing.Size(768, 349);
            this.inventoryListView.TabIndex = 2;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.Details;
            this.inventoryListView.SelectedIndexChanged += new System.EventHandler(this.inventoryListView_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "图书ISBN";
            this.columnHeader6.Width = 178;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "应放位置";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "实放位置";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 150;
            // 
            // setTheme
            // 
            this.setTheme.BackColor = System.Drawing.Color.White;
            this.setTheme.Controls.Add(this.adminModeButton);
            this.setTheme.Controls.Add(this.chMode);
            this.setTheme.Controls.Add(this.bluegreySchemeButton);
            this.setTheme.Controls.Add(this.greenSchemeButton);
            this.setTheme.Controls.Add(this.blueSchemeButton);
            this.setTheme.Controls.Add(this.materialLabel2);
            this.setTheme.Controls.Add(this.nightModeButton);
            this.setTheme.Controls.Add(this.materialLabel1);
            this.setTheme.Controls.Add(this.dayModeButton);
            this.setTheme.Location = new System.Drawing.Point(4, 26);
            this.setTheme.Name = "setTheme";
            this.setTheme.Size = new System.Drawing.Size(768, 349);
            this.setTheme.TabIndex = 6;
            this.setTheme.Text = "其他设置";
            // 
            // adminModeButton
            // 
            this.adminModeButton.Depth = 0;
            this.adminModeButton.Location = new System.Drawing.Point(100, 117);
            this.adminModeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminModeButton.Name = "adminModeButton";
            this.adminModeButton.Primary = true;
            this.adminModeButton.Size = new System.Drawing.Size(130, 40);
            this.adminModeButton.TabIndex = 13;
            this.adminModeButton.Text = "用户模式";
            this.adminModeButton.UseVisualStyleBackColor = true;
            this.adminModeButton.Click += new System.EventHandler(this.adminModeButton_Click);
            // 
            // chMode
            // 
            this.chMode.AutoSize = true;
            this.chMode.Depth = 0;
            this.chMode.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.chMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chMode.Location = new System.Drawing.Point(14, 126);
            this.chMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.chMode.Name = "chMode";
            this.chMode.Size = new System.Drawing.Size(69, 20);
            this.chMode.TabIndex = 12;
            this.chMode.Text = "切换模式";
            // 
            // bluegreySchemeButton
            // 
            this.bluegreySchemeButton.Depth = 0;
            this.bluegreySchemeButton.Location = new System.Drawing.Point(410, 60);
            this.bluegreySchemeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bluegreySchemeButton.Name = "bluegreySchemeButton";
            this.bluegreySchemeButton.Primary = true;
            this.bluegreySchemeButton.Size = new System.Drawing.Size(130, 40);
            this.bluegreySchemeButton.TabIndex = 7;
            this.bluegreySchemeButton.Text = "蓝灰色";
            this.bluegreySchemeButton.UseVisualStyleBackColor = true;
            this.bluegreySchemeButton.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // greenSchemeButton
            // 
            this.greenSchemeButton.Depth = 0;
            this.greenSchemeButton.Location = new System.Drawing.Point(255, 60);
            this.greenSchemeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.greenSchemeButton.Name = "greenSchemeButton";
            this.greenSchemeButton.Primary = true;
            this.greenSchemeButton.Size = new System.Drawing.Size(130, 40);
            this.greenSchemeButton.TabIndex = 6;
            this.greenSchemeButton.Text = "绿色";
            this.greenSchemeButton.UseVisualStyleBackColor = true;
            this.greenSchemeButton.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // blueSchemeButton
            // 
            this.blueSchemeButton.Depth = 0;
            this.blueSchemeButton.Location = new System.Drawing.Point(100, 60);
            this.blueSchemeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.blueSchemeButton.Name = "blueSchemeButton";
            this.blueSchemeButton.Primary = true;
            this.blueSchemeButton.Size = new System.Drawing.Size(130, 40);
            this.blueSchemeButton.TabIndex = 5;
            this.blueSchemeButton.Text = "蓝色";
            this.blueSchemeButton.UseVisualStyleBackColor = true;
            this.blueSchemeButton.Click += new System.EventHandler(this.materialRaisedButton3_Click);
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
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "更换配色";
            // 
            // nightModeButton
            // 
            this.nightModeButton.Depth = 0;
            this.nightModeButton.Location = new System.Drawing.Point(255, 5);
            this.nightModeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nightModeButton.Name = "nightModeButton";
            this.nightModeButton.Primary = true;
            this.nightModeButton.Size = new System.Drawing.Size(130, 40);
            this.nightModeButton.TabIndex = 3;
            this.nightModeButton.Text = "夜间模式";
            this.nightModeButton.UseVisualStyleBackColor = true;
            this.nightModeButton.Click += new System.EventHandler(this.materialRaisedButton2_Click);
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
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "更换主题";
            // 
            // dayModeButton
            // 
            this.dayModeButton.Depth = 0;
            this.dayModeButton.Location = new System.Drawing.Point(100, 5);
            this.dayModeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.dayModeButton.Name = "dayModeButton";
            this.dayModeButton.Primary = true;
            this.dayModeButton.Size = new System.Drawing.Size(130, 40);
            this.dayModeButton.TabIndex = 0;
            this.dayModeButton.Text = "日间模式";
            this.dayModeButton.UseVisualStyleBackColor = true;
            this.dayModeButton.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "图书馆管理系统-管理员模式";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.materialTabControl1.ResumeLayout(false);
            this.bookBorrowReturnTab.ResumeLayout(false);
            this.bookBorrowReturnTab.PerformLayout();
            this.bookManTab.ResumeLayout(false);
            this.bookManTab.PerformLayout();
            this.userManTab.ResumeLayout(false);
            this.userManTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.shelfManTab.ResumeLayout(false);
            this.shelfManTab.PerformLayout();
            this.statusTab.ResumeLayout(false);
            this.organizingTab.ResumeLayout(false);
            this.setTheme.ResumeLayout(false);
            this.setTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage bookBorrowReturnTab;
        private System.Windows.Forms.TabPage bookManTab;
        private System.Windows.Forms.TabPage userManTab;
        private System.Windows.Forms.TabPage shelfManTab;
        private System.Windows.Forms.TabPage statusTab;
        private System.Windows.Forms.TabPage setTheme;
        private MaterialSkin.Controls.MaterialRaisedButton dayModeButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton nightModeButton;
        private MaterialSkin.Controls.MaterialRaisedButton greenSchemeButton;
        private MaterialSkin.Controls.MaterialRaisedButton blueSchemeButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton bluegreySchemeButton;
        private MaterialSkin.Controls.MaterialLabel borrowTypeLabel;
        private MaterialSkin.Controls.MaterialRadioButton borrowRadioButton;
        private MaterialSkin.Controls.MaterialLabel userIDLabel;
        private MaterialSkin.Controls.MaterialRadioButton returnRadioButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField userIDText;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookEPCText;
        private MaterialSkin.Controls.MaterialLabel bookEPCLAbel;
        private MaterialSkin.Controls.MaterialRaisedButton runButton;
        private MaterialSkin.Controls.MaterialRaisedButton bookSearchButton;
        private MaterialSkin.Controls.MaterialLabel optionalLabel2;
        private MaterialSkin.Controls.MaterialLabel optionalLabel1;
        private MaterialSkin.Controls.MaterialLabel ISBNLabel;
        private MaterialSkin.Controls.MaterialLabel optionalLabel5;
        private MaterialSkin.Controls.MaterialLabel optionalLabel4;
        private MaterialSkin.Controls.MaterialLabel optionalLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField yearText;
        private MaterialSkin.Controls.MaterialSingleLineTextField publisherText;
        private MaterialSkin.Controls.MaterialSingleLineTextField authorText;
        private MaterialSkin.Controls.MaterialSingleLineTextField typeText;
        private MaterialSkin.Controls.MaterialSingleLineTextField optionalText;
        private MaterialSkin.Controls.MaterialSingleLineTextField ISBNLabelText;
        private MaterialSkin.Controls.MaterialRaisedButton bookUpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton bookDeleteButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField usrIDText;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialRaisedButton usrUpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton usrDeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton usrSearchButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField usrPwText;
        private MaterialSkin.Controls.MaterialSingleLineTextField usrAddressText;
        private MaterialSkin.Controls.MaterialSingleLineTextField usrNameText;
        private MaterialSkin.Controls.MaterialRaisedButton shelfUpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton shelfDeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton shelfSearchButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialListView borrowReturnList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private MaterialLabel status_page1;
        private MaterialLabel status_page2;
        private MaterialLabel status_page3;
        private Panel panel2;
        private MaterialRadioButton adminRadioButton;
        private MaterialRadioButton readerRadioButton;
        private Panel panel1;
        private MaterialRadioButton girlRadioButton;
        private MaterialRadioButton boyRadioButton;
        private MaterialRadioButton bookInfoRadioButton;
        private MaterialRadioButton bookEPCRadioButton;
        private MaterialSingleLineTextField bookcaseText;
        private MaterialLabel materialLabel5;
        private MaterialSingleLineTextField roomText;
        private MaterialLabel materialLabel4;
        private MaterialSingleLineTextField floorText;
        private MaterialSingleLineTextField shelfText;
        private MaterialLabel materialLabel6;
        private MaterialSingleLineTextField unitText;
        private MaterialLabel materialLabel3;
        private MaterialSingleLineTextField unitEPCText;
        private MaterialLabel status_page4;
        private TextBox inventoryText;
        private MaterialRaisedButton statisticsButton;
        private TabPage organizingTab;
        private MaterialListView inventoryListView;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader5;
        private MaterialRaisedButton adminModeButton;
        private MaterialLabel chMode;
    }
}

