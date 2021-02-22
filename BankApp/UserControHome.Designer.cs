namespace BankApp
{
    partial class UserControHome
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControHome));
            this.HomeUser = new System.Windows.Forms.Label();
            this.lblHomeLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblBalanseCard = new System.Windows.Forms.Label();
            this.UAH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeUser
            // 
            this.HomeUser.AutoSize = true;
            this.HomeUser.Location = new System.Drawing.Point(78, 10);
            this.HomeUser.Name = "HomeUser";
            this.HomeUser.Size = new System.Drawing.Size(29, 13);
            this.HomeUser.TabIndex = 0;
            this.HomeUser.Text = "User";
            // 
            // lblHomeLogin
            // 
            this.lblHomeLogin.AutoSize = true;
            this.lblHomeLogin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHomeLogin.Location = new System.Drawing.Point(78, 30);
            this.lblHomeLogin.Name = "lblHomeLogin";
            this.lblHomeLogin.Size = new System.Drawing.Size(54, 22);
            this.lblHomeLogin.TabIndex = 2;
            this.lblHomeLogin.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(258, -62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 227);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCardNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCardNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCardNumber.Location = new System.Drawing.Point(282, 67);
            this.tbCardNumber.Mask = "0000-0000-0000-0000";
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(211, 20);
            this.tbCardNumber.TabIndex = 7;
            this.tbCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBalanseCard
            // 
            this.lblBalanseCard.AutoSize = true;
            this.lblBalanseCard.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanseCard.Location = new System.Drawing.Point(370, 104);
            this.lblBalanseCard.Name = "lblBalanseCard";
            this.lblBalanseCard.Size = new System.Drawing.Size(56, 28);
            this.lblBalanseCard.TabIndex = 8;
            this.lblBalanseCard.Text = "2500";
            // 
            // UAH
            // 
            this.UAH.AutoSize = true;
            this.UAH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UAH.Location = new System.Drawing.Point(432, 111);
            this.UAH.Name = "UAH";
            this.UAH.Size = new System.Drawing.Size(18, 18);
            this.UAH.TabIndex = 9;
            this.UAH.Text = "$";
            // 
            // UserControHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.UAH);
            this.Controls.Add(this.lblBalanseCard);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHomeLogin);
            this.Controls.Add(this.HomeUser);
            this.Name = "UserControHome";
            this.Size = new System.Drawing.Size(786, 408);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeUser;
        private System.Windows.Forms.Label lblHomeLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox tbCardNumber;
        private System.Windows.Forms.Label lblBalanseCard;
        private System.Windows.Forms.Label UAH;
    }
}
