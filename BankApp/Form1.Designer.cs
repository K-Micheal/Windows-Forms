namespace BankApp
{
    partial class BankForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
            this.btnLoginBank = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenuChoese = new System.Windows.Forms.Panel();
            this.btnMenuSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuTransfer = new System.Windows.Forms.Button();
            this.btnMenuDeposit = new System.Windows.Forms.Button();
            this.btnMenuHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginBank
            // 
            this.btnLoginBank.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoginBank.FlatAppearance.BorderSize = 0;
            this.btnLoginBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginBank.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginBank.ForeColor = System.Drawing.Color.White;
            this.btnLoginBank.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginBank.Image")));
            this.btnLoginBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginBank.Location = new System.Drawing.Point(0, 468);
            this.btnLoginBank.Name = "btnLoginBank";
            this.btnLoginBank.Size = new System.Drawing.Size(171, 49);
            this.btnLoginBank.TabIndex = 8;
            this.btnLoginBank.Text = "Login";
            this.btnLoginBank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginBank.UseVisualStyleBackColor = false;
            this.btnLoginBank.Click += new System.EventHandler(this.btnLoginBank_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panelMenuChoese);
            this.panelMenu.Controls.Add(this.btnMenuSettings);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnMenuTransfer);
            this.panelMenu.Controls.Add(this.btnMenuDeposit);
            this.panelMenu.Controls.Add(this.btnMenuHome);
            this.panelMenu.Controls.Add(this.btnLoginBank);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(171, 517);
            this.panelMenu.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(170, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 408);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // panelMenuChoese
            // 
            this.panelMenuChoese.BackColor = System.Drawing.Color.DarkRed;
            this.panelMenuChoese.Location = new System.Drawing.Point(0, 131);
            this.panelMenuChoese.Name = "panelMenuChoese";
            this.panelMenuChoese.Size = new System.Drawing.Size(10, 49);
            this.panelMenuChoese.TabIndex = 11;
            this.panelMenuChoese.Visible = false;
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuSettings.FlatAppearance.BorderSize = 0;
            this.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSettings.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenuSettings.ForeColor = System.Drawing.Color.White;
            this.btnMenuSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSettings.Image")));
            this.btnMenuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSettings.Location = new System.Drawing.Point(10, 275);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Size = new System.Drawing.Size(161, 49);
            this.btnMenuSettings.TabIndex = 13;
            this.btnMenuSettings.Text = "Settings";
            this.btnMenuSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSettings.UseVisualStyleBackColor = false;
            this.btnMenuSettings.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuTransfer
            // 
            this.btnMenuTransfer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuTransfer.FlatAppearance.BorderSize = 0;
            this.btnMenuTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTransfer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenuTransfer.ForeColor = System.Drawing.Color.White;
            this.btnMenuTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuTransfer.Image")));
            this.btnMenuTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTransfer.Location = new System.Drawing.Point(10, 180);
            this.btnMenuTransfer.Name = "btnMenuTransfer";
            this.btnMenuTransfer.Size = new System.Drawing.Size(161, 49);
            this.btnMenuTransfer.TabIndex = 13;
            this.btnMenuTransfer.Text = "Transfer";
            this.btnMenuTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuTransfer.UseVisualStyleBackColor = false;
            this.btnMenuTransfer.Visible = false;
            this.btnMenuTransfer.Click += new System.EventHandler(this.btnMenuTransfer_Click);
            // 
            // btnMenuDeposit
            // 
            this.btnMenuDeposit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuDeposit.FlatAppearance.BorderSize = 0;
            this.btnMenuDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDeposit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenuDeposit.ForeColor = System.Drawing.Color.White;
            this.btnMenuDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuDeposit.Image")));
            this.btnMenuDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDeposit.Location = new System.Drawing.Point(10, 229);
            this.btnMenuDeposit.Name = "btnMenuDeposit";
            this.btnMenuDeposit.Size = new System.Drawing.Size(161, 49);
            this.btnMenuDeposit.TabIndex = 12;
            this.btnMenuDeposit.Text = "Deposit";
            this.btnMenuDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuDeposit.UseVisualStyleBackColor = false;
            this.btnMenuDeposit.Visible = false;
            // 
            // btnMenuHome
            // 
            this.btnMenuHome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuHome.FlatAppearance.BorderSize = 0;
            this.btnMenuHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuHome.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenuHome.ForeColor = System.Drawing.Color.White;
            this.btnMenuHome.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuHome.Image")));
            this.btnMenuHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHome.Location = new System.Drawing.Point(10, 131);
            this.btnMenuHome.Name = "btnMenuHome";
            this.btnMenuHome.Size = new System.Drawing.Size(161, 49);
            this.btnMenuHome.TabIndex = 11;
            this.btnMenuHome.Text = "Home";
            this.btnMenuHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuHome.UseVisualStyleBackColor = false;
            this.btnMenuHome.Visible = false;
            this.btnMenuHome.Click += new System.EventHandler(this.btnMenuHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(931, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(901, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 21);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(870, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 21);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 517);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoginBank;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenuHome;
        private System.Windows.Forms.Button btnMenuTransfer;
        private System.Windows.Forms.Button btnMenuDeposit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuSettings;
        private System.Windows.Forms.Panel panelMenuChoese;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

