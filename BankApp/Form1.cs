using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class BankForm : Form
    {
        public User userGlobal { get; set; }
        
        public BankForm()
        {
            InitializeComponent();

           
        }

     

        private void btnLoginBank_Click(object sender, EventArgs e)
        {
            if (btnLoginBank.Text == "Login")
            {
                Reg Login = new Reg();
                Login.Show();
                Login.onLogined += Login_onLogined;
            }
            else if (btnLoginBank.Text == "Unlogin")
            {
                userGlobal = null;
                panelMenuChoese.Visible = false;
                btnMenuDeposit.Visible = false;
                btnMenuHome.Visible = false;
                btnMenuSettings.Visible = false;
                btnMenuTransfer.Visible = false;
                btnLoginBank.Text = "Login";


                UCHides ucHide = new UCHides();
                Controls.Add(ucHide);
                ucHide.Location = new Point(171, 109);
                ucHide.BringToFront();
            }
           
        }

        

        private void Login_onLogined(User user)
        {
            userGlobal = user;
            panelMenuChoese.Visible = true;
            btnMenuDeposit.Visible = true;
            btnMenuHome.Visible = true;
            btnMenuSettings.Visible = true;
            btnMenuTransfer.Visible = true;
            if (userGlobal != null)
            {
                btnLoginBank.Text = "Unlogin";
                UserControHome ucHome = new UserControHome(userGlobal);
                Controls.Add(ucHome);
                ucHome.Location = new Point(171, 109);
                ucHome.BringToFront();
            }
        }

        private void BankForm_Load(object sender, EventArgs e)
        {
            panelMenu.BackColor = Color.FromArgb(34, 36, 49);

            btnMenuHome.BackColor = Color.FromArgb(34, 36, 49);
            btnLoginBank.BackColor = Color.FromArgb(34, 36, 49);
            btnMenuTransfer.BackColor = Color.FromArgb(34, 36, 49);
            btnMenuDeposit.BackColor = Color.FromArgb(34, 36, 49);
            btnMenuSettings.BackColor = Color.FromArgb(34, 36, 49);
            panelMenuChoese.BackColor = Color.FromArgb(0, 255, 255);
        }

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            panelMenuChoese.Height = btnMenuHome.Height;
            panelMenuChoese.Top = btnMenuHome.Top;

            UserControHome ucHome = new UserControHome(userGlobal);
            Controls.Add(ucHome);
            ucHome.Location = new Point(171, 109);
            ucHome.BringToFront();
        }

        private void btnMenuTransfer_Click(object sender, EventArgs e)
        {
            panelMenuChoese.Height = btnMenuTransfer.Height;
            panelMenuChoese.Top = btnMenuTransfer.Top;

            UCTransfer ucTransfer = new UCTransfer(userGlobal);
            Controls.Add(ucTransfer);
            ucTransfer.Location = new Point(171, 109);
            ucTransfer.BringToFront();
        }

       

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
