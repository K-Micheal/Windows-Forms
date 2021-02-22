namespace BankApp
{
    partial class Reg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.btnRegEnter = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblIsLogined = new System.Windows.Forms.Label();
            this.cbPasswordTabReg = new System.Windows.Forms.CheckBox();
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageReg = new System.Windows.Forms.TabPage();
            this.cbHideTabLogin = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPasswordTabPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbLoginTabLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCloseLogin = new System.Windows.Forms.Label();
            this.lblHaeding = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIsLogined1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.MaskedTextBox();
            this.tbRegPin = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCloseReg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSingUp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNotFound = new System.Windows.Forms.Label();
            this.tabLogin.SuspendLayout();
            this.tabPageReg.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegEnter
            // 
            this.btnRegEnter.BackColor = System.Drawing.Color.Maroon;
            this.btnRegEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEnter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegEnter.ForeColor = System.Drawing.Color.White;
            this.btnRegEnter.Location = new System.Drawing.Point(94, 275);
            this.btnRegEnter.Name = "btnRegEnter";
            this.btnRegEnter.Size = new System.Drawing.Size(104, 28);
            this.btnRegEnter.TabIndex = 0;
            this.btnRegEnter.Text = "Reg";
            this.btnRegEnter.UseVisualStyleBackColor = false;
            this.btnRegEnter.Click += new System.EventHandler(this.btnRegEnter_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(56, 220);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(104, 15);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "passwoed";
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(56, 173);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(104, 15);
            this.tbLogin.TabIndex = 5;
            this.tbLogin.Text = "login";
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
            // 
            // lblIsLogined
            // 
            this.lblIsLogined.AutoSize = true;
            this.lblIsLogined.Location = new System.Drawing.Point(49, 15);
            this.lblIsLogined.Name = "lblIsLogined";
            this.lblIsLogined.Size = new System.Drawing.Size(10, 13);
            this.lblIsLogined.TabIndex = 7;
            this.lblIsLogined.Text = "-";
            this.lblIsLogined.Visible = false;
            // 
            // cbPasswordTabReg
            // 
            this.cbPasswordTabReg.AutoSize = true;
            this.cbPasswordTabReg.Checked = true;
            this.cbPasswordTabReg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPasswordTabReg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPasswordTabReg.Location = new System.Drawing.Point(90, 248);
            this.cbPasswordTabReg.Name = "cbPasswordTabReg";
            this.cbPasswordTabReg.Size = new System.Drawing.Size(108, 19);
            this.cbPasswordTabReg.TabIndex = 8;
            this.cbPasswordTabReg.Text = "hide password";
            this.cbPasswordTabReg.UseVisualStyleBackColor = true;
            this.cbPasswordTabReg.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tabPageLogin);
            this.tabLogin.Controls.Add(this.tabPageReg);
            this.tabLogin.Location = new System.Drawing.Point(742, 160);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(174, 274);
            this.tabLogin.TabIndex = 9;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(166, 248);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            this.tabPageLogin.Click += new System.EventHandler(this.tabPageLogin_Click);
            // 
            // tabPageReg
            // 
            this.tabPageReg.Controls.Add(this.lblIsLogined);
            this.tabPageReg.Location = new System.Drawing.Point(4, 22);
            this.tabPageReg.Name = "tabPageReg";
            this.tabPageReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReg.Size = new System.Drawing.Size(166, 248);
            this.tabPageReg.TabIndex = 1;
            this.tabPageReg.Text = "Reg";
            this.tabPageReg.UseVisualStyleBackColor = true;
            this.tabPageReg.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbHideTabLogin
            // 
            this.cbHideTabLogin.AutoSize = true;
            this.cbHideTabLogin.Checked = true;
            this.cbHideTabLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHideTabLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbHideTabLogin.Location = new System.Drawing.Point(98, 248);
            this.cbHideTabLogin.Name = "cbHideTabLogin";
            this.cbHideTabLogin.Size = new System.Drawing.Size(108, 19);
            this.cbHideTabLogin.TabIndex = 14;
            this.cbHideTabLogin.Text = "hide password";
            this.cbHideTabLogin.UseVisualStyleBackColor = true;
            this.cbHideTabLogin.CheckedChanged += new System.EventHandler(this.cbHideTabLogin_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnLogin.Location = new System.Drawing.Point(99, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 28);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPasswordTabPassword
            // 
            this.tbPasswordTabPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPasswordTabPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordTabPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordTabPassword.Location = new System.Drawing.Point(99, 203);
            this.tbPasswordTabPassword.Name = "tbPasswordTabPassword";
            this.tbPasswordTabPassword.PasswordChar = '*';
            this.tbPasswordTabPassword.Size = new System.Drawing.Size(104, 18);
            this.tbPasswordTabPassword.TabIndex = 10;
            this.tbPasswordTabPassword.Text = "password";
            this.tbPasswordTabPassword.Click += new System.EventHandler(this.tbPasswordTabPassword_Click);
            // 
            // tbLoginTabLogin
            // 
            this.tbLoginTabLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginTabLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginTabLogin.Location = new System.Drawing.Point(98, 145);
            this.tbLoginTabLogin.Name = "tbLoginTabLogin";
            this.tbLoginTabLogin.Size = new System.Drawing.Size(104, 18);
            this.tbLoginTabLogin.TabIndex = 9;
            this.tbLoginTabLogin.Text = "login";
            this.tbLoginTabLogin.Click += new System.EventHandler(this.tbLoginTabLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNotFound);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblCloseLogin);
            this.panel1.Controls.Add(this.lblHaeding);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbHideTabLogin);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbLoginTabLogin);
            this.panel1.Controls.Add(this.tbPasswordTabPassword);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 317);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "fast_log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCloseLogin
            // 
            this.lblCloseLogin.AutoSize = true;
            this.lblCloseLogin.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloseLogin.Location = new System.Drawing.Point(258, 3);
            this.lblCloseLogin.Name = "lblCloseLogin";
            this.lblCloseLogin.Size = new System.Drawing.Size(19, 17);
            this.lblCloseLogin.TabIndex = 22;
            this.lblCloseLogin.Text = "x";
            this.lblCloseLogin.Click += new System.EventHandler(this.lblCloseLogin_Click);
            // 
            // lblHaeding
            // 
            this.lblHaeding.AutoSize = true;
            this.lblHaeding.BackColor = System.Drawing.Color.Transparent;
            this.lblHaeding.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaeding.Location = new System.Drawing.Point(88, 95);
            this.lblHaeding.Name = "lblHaeding";
            this.lblHaeding.Size = new System.Drawing.Size(110, 26);
            this.lblHaeding.TabIndex = 21;
            this.lblHaeding.Text = "ClickBank";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(89, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 92);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(94, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 2);
            this.panel5.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(94, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 2);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(94, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblIsLogined1);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.tbRegPin);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.lblCloseReg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.cbPasswordTabReg);
            this.panel2.Controls.Add(this.tbLogin);
            this.panel2.Controls.Add(this.btnRegEnter);
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 317);
            this.panel2.TabIndex = 11;
            // 
            // lblIsLogined1
            // 
            this.lblIsLogined1.AutoSize = true;
            this.lblIsLogined1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIsLogined1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsLogined1.ForeColor = System.Drawing.Color.Red;
            this.lblIsLogined1.Location = new System.Drawing.Point(91, 110);
            this.lblIsLogined1.Name = "lblIsLogined1";
            this.lblIsLogined1.Size = new System.Drawing.Size(48, 18);
            this.lblIsLogined1.TabIndex = 13;
            this.lblIsLogined1.Text = "exists";
            this.lblIsLogined1.Visible = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic);
            this.tbName.Location = new System.Drawing.Point(56, 131);
            this.tbName.Mask = "0000-0000-0000-0000";
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(139, 15);
            this.tbName.TabIndex = 31;
            // 
            // tbRegPin
            // 
            this.tbRegPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegPin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegPin.Location = new System.Drawing.Point(212, 222);
            this.tbRegPin.Name = "tbRegPin";
            this.tbRegPin.Size = new System.Drawing.Size(65, 15);
            this.tbRegPin.TabIndex = 30;
            this.tbRegPin.Text = "pin-code";
            this.tbRegPin.Click += new System.EventHandler(this.tbRegPin_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(212, 236);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(50, 2);
            this.panel9.TabIndex = 29;
            // 
            // lblCloseReg
            // 
            this.lblCloseReg.AutoSize = true;
            this.lblCloseReg.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloseReg.Location = new System.Drawing.Point(258, 3);
            this.lblCloseReg.Name = "lblCloseReg";
            this.lblCloseReg.Size = new System.Drawing.Size(19, 17);
            this.lblCloseReg.TabIndex = 27;
            this.lblCloseReg.Text = "x";
            this.lblCloseReg.Click += new System.EventHandler(this.lblCloseReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "ClickBank";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(86, -8);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(118, 92);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 116);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 162);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(56, 236);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(125, 2);
            this.panel8.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(56, 191);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(125, 2);
            this.panel7.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(56, 147);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 2);
            this.panel6.TabIndex = 19;
            // 
            // lblSingUp
            // 
            this.lblSingUp.AutoSize = true;
            this.lblSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSingUp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSingUp.Location = new System.Drawing.Point(219, 321);
            this.lblSingUp.Name = "lblSingUp";
            this.lblSingUp.Size = new System.Drawing.Size(49, 15);
            this.lblSingUp.TabIndex = 12;
            this.lblSingUp.Text = "Sign up";
            this.lblSingUp.Click += new System.EventHandler(this.lblSingUp_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNotFound.Location = new System.Drawing.Point(115, 121);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(64, 13);
            this.lblNotFound.TabIndex = 24;
            this.lblNotFound.Text = "lblNotFound";
            this.lblNotFound.Visible = false;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 342);
            this.Controls.Add(this.lblSingUp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reg";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.tabLogin.ResumeLayout(false);
            this.tabPageReg.ResumeLayout(false);
            this.tabPageReg.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegEnter;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblIsLogined;
        private System.Windows.Forms.CheckBox cbPasswordTabReg;
        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageReg;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MaskedTextBox tbPasswordTabPassword;
        private System.Windows.Forms.TextBox tbLoginTabLogin;
        private System.Windows.Forms.CheckBox cbHideTabLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSingUp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHaeding;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCloseLogin;
        private System.Windows.Forms.Label lblCloseReg;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbRegPin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tbName;
        private System.Windows.Forms.Label lblIsLogined1;
        private System.Windows.Forms.Label lblNotFound;
    }
}