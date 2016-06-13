namespace LibraryManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pwLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loginNameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginPwText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Depth = 0;
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(46, 109);
            this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "账号";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Depth = 0;
            this.pwLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.pwLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pwLabel.Location = new System.Drawing.Point(46, 174);
            this.pwLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(39, 20);
            this.pwLabel.TabIndex = 1;
            this.pwLabel.Text = "密码";
            // 
            // loginNameText
            // 
            this.loginNameText.Depth = 0;
            this.loginNameText.Hint = "请输入账号";
            this.loginNameText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.loginNameText.Location = new System.Drawing.Point(91, 109);
            this.loginNameText.MaxLength = 32767;
            this.loginNameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginNameText.Name = "loginNameText";
            this.loginNameText.PasswordChar = '\0';
            this.loginNameText.SelectedText = "";
            this.loginNameText.SelectionLength = 0;
            this.loginNameText.SelectionStart = 0;
            this.loginNameText.Size = new System.Drawing.Size(150, 25);
            this.loginNameText.TabIndex = 2;
            this.loginNameText.TabStop = false;
            this.loginNameText.UseSystemPasswordChar = false;
            this.loginNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginNameText_KeyDown);
            // 
            // loginPwText
            // 
            this.loginPwText.Depth = 0;
            this.loginPwText.Hint = "请输入密码";
            this.loginPwText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.loginPwText.Location = new System.Drawing.Point(91, 174);
            this.loginPwText.MaxLength = 32767;
            this.loginPwText.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginPwText.Name = "loginPwText";
            this.loginPwText.PasswordChar = '·';
            this.loginPwText.SelectedText = "";
            this.loginPwText.SelectionLength = 0;
            this.loginPwText.SelectionStart = 0;
            this.loginPwText.Size = new System.Drawing.Size(150, 25);
            this.loginPwText.TabIndex = 3;
            this.loginPwText.TabStop = false;
            this.loginPwText.UseSystemPasswordChar = false;
            this.loginPwText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginPwText_KeyDown);
            // 
            // loginButton
            // 
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(110, 237);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(80, 32);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登陆";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPwText);
            this.Controls.Add(this.loginNameText);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "用户登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private MaterialSkin.Controls.MaterialLabel pwLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginNameText;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginPwText;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
    }
}