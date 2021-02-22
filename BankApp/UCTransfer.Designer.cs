namespace BankApp
{
    partial class UCTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTransfer));
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tbSumTrabsfer = new System.Windows.Forms.TextBox();
            this.mtbTransgerCardNuber = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UAH = new System.Windows.Forms.Label();
            this.lblBalanseCard = new System.Windows.Forms.Label();
            this.tbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransfer.Location = new System.Drawing.Point(112, 341);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(135, 33);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // tbSumTrabsfer
            // 
            this.tbSumTrabsfer.BackColor = System.Drawing.SystemColors.Control;
            this.tbSumTrabsfer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSumTrabsfer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic);
            this.tbSumTrabsfer.Location = new System.Drawing.Point(110, 278);
            this.tbSumTrabsfer.Name = "tbSumTrabsfer";
            this.tbSumTrabsfer.Size = new System.Drawing.Size(66, 18);
            this.tbSumTrabsfer.TabIndex = 5;
            // 
            // mtbTransgerCardNuber
            // 
            this.mtbTransgerCardNuber.BackColor = System.Drawing.SystemColors.Control;
            this.mtbTransgerCardNuber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbTransgerCardNuber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.mtbTransgerCardNuber.Location = new System.Drawing.Point(110, 221);
            this.mtbTransgerCardNuber.Mask = "0000-0000-0000-0000";
            this.mtbTransgerCardNuber.Name = "mtbTransgerCardNuber";
            this.mtbTransgerCardNuber.Size = new System.Drawing.Size(208, 20);
            this.mtbTransgerCardNuber.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(109, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 1);
            this.panel1.TabIndex = 9;
            // 
            // UAH
            // 
            this.UAH.AutoSize = true;
            this.UAH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UAH.Location = new System.Drawing.Point(218, 109);
            this.UAH.Name = "UAH";
            this.UAH.Size = new System.Drawing.Size(18, 18);
            this.UAH.TabIndex = 13;
            this.UAH.Text = "$";
            // 
            // lblBalanseCard
            // 
            this.lblBalanseCard.AutoSize = true;
            this.lblBalanseCard.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanseCard.Location = new System.Drawing.Point(165, 104);
            this.lblBalanseCard.Name = "lblBalanseCard";
            this.lblBalanseCard.Size = new System.Drawing.Size(56, 28);
            this.lblBalanseCard.TabIndex = 12;
            this.lblBalanseCard.Text = "2500";
            this.lblBalanseCard.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCardNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCardNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCardNumber.Location = new System.Drawing.Point(77, 67);
            this.tbCardNumber.Mask = "0000-0000-0000-0000";
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(211, 20);
            this.tbCardNumber.TabIndex = 11;
            this.tbCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, -62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 227);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 46);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(144, 176);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 37);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Location = new System.Drawing.Point(135, 322);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(35, 13);
            this.lblSuccess.TabIndex = 17;
            this.lblSuccess.Text = "label1";
            this.lblSuccess.Visible = false;
            // 
            // UCTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UAH);
            this.Controls.Add(this.lblBalanseCard);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtbTransgerCardNuber);
            this.Controls.Add(this.tbSumTrabsfer);
            this.Controls.Add(this.btnTransfer);
            this.Name = "UCTransfer";
            this.Size = new System.Drawing.Size(786, 408);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox tbSumTrabsfer;
        private System.Windows.Forms.MaskedTextBox mtbTransgerCardNuber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UAH;
        private System.Windows.Forms.Label lblBalanseCard;
        private System.Windows.Forms.MaskedTextBox tbCardNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblSuccess;
    }
}
