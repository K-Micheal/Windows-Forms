using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;

namespace BankApp
{
    public partial class Reg : Form
    {
        public delegate void UserLogined(User user);
        public event UserLogined onLogined;
        UserContext db = new UserContext();
        public Reg()
        {
            InitializeComponent();
        }

        private void btnRegEnter_Click(object sender, EventArgs e)
        {
            //List<User> users = new List<User>();

            //if (!File.Exists("client.json"))
            //{
            //    File.Create("client.json");
            //}

            //users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("client.json"));
            //users.AddRange(db.Users);

            var users = db.Users;

            User user_reg = new User();
            bool exists = false;

            foreach (User u in users)
            {
                string s = tbName.Text;
                string s1;
                s1 = s.Remove(4, 1);
                s = s1.Remove(8, 1);
                s1 = s.Remove(12, 1);
                if (s1.Length != 16 || tbLogin.Text.Length < 6 || tbPassword.Text.Length < 6 || tbPassword.Text == "passwoed" || tbRegPin.Text.Length != 4)
                {
                    lblIsLogined1.Text = "few characters";
                    lblIsLogined1.Visible = true;
                    exists = true;
                    break;
                }
                else if (tbName.Text == u.card_namber)
                {
                    lblIsLogined1.Text = "exists";
                    lblIsLogined1.Visible = true;
                    exists = true;
                    break;
                }
                else if (tbLogin.Text == u.login)
                {
                        if (tbPassword.Text == u.password)
                        {
                            lblIsLogined1.Text = "exists";
                            lblIsLogined1.Visible = true;
                            exists = true;
                            break;

                        }
                }
                
            }

            if (exists==false)
            {
                user_reg.login = tbLogin.Text;
                user_reg.card_namber = tbName.Text;
                user_reg.password = tbPassword.Text;
                user_reg.pin = tbRegPin.Text;

                //users.Add(user_reg);
                db.Users.Add(user_reg);
                db.SaveChanges();
                //File.WriteAllText("client.json", JsonConvert.SerializeObject(users));
                lblIsLogined.Text = "done";
                lblIsLogined.Visible = true;
                Close();
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPasswordTabReg.Checked == false)
            {
                tbPassword.PasswordChar = default;
            }
            else 
            {
                tbPassword.PasswordChar = '\u002a';
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //    List<User> users = new List<User>();

            //    if (!File.Exists("client.json"))
            //    {
            //        File.Create("client.json");
            //    }

            //    users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("client.json"));
            //    User user = new User();
            //    bool exists = false;

            //    foreach (User u in users)
            //    {

            //        if (tbLogin.Text == u.login)
            //        {
            //            if (tbPassword.Text == u.password)
            //            {
            //                lblIsLogined.Text = "exists";
            //                lblIsLogined.Visible = true;
            //                exists = true;
            //                break;

            //            }
            //        }
            //    }

            //    if (exists == false)
            //    {
            //        user.login = tbLogin.Text;
            //        user.name = tbName.Text;
            //        user.password = tbPassword.Text;

            //        users.Add(user);
            //        File.WriteAllText("client.json", JsonConvert.SerializeObject(users));
            //        lblIsLogined.Text = "done";
            //        lblIsLogined.Visible = true;
            //    }
        }

        private void tabPageLogin_Click(object sender, EventArgs e)
        {
            //string login = tbLogin.Text;
            //string password = tbPassword.Text;
            //List<User> users = new List<User>();


            //if (!File.Exists("client.json"))
            //{
            //    File.Create("client.json");
            //}

            //users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("client.json"));
            //bool is_exists = false;


            //foreach (User u in users)
            //{

            //    if (login == u.login)
            //    {
            //        if (password == u.password)
            //        {
            //            lblIsLogined.Visible = true;
            //            lblIsLogined.Text = "hi " + u.name;
            //            is_exists = true;
            //            break;

            //        }
            //    }
            //}

            //if (is_exists == false)
            //{
            //    lblIsLogined.Visible = true;
            //    lblIsLogined.Text = "pshel nah";
            //}
        }

        private void cbHideTabLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHideTabLogin.Checked == false)
            {
                tbPasswordTabPassword.PasswordChar = default;
            }
            else
            {
                tbPasswordTabPassword.PasswordChar = '\u002a';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string ah = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            //User user1 = new User { balanse = "2500", card_namber = "0980406591", login = "lol", password = "kek", pin = "1111" };
            //UserContext db = new UserContext();            
            //db.Users.Add(user1);
            //db.SaveChanges();

            string login = tbLoginTabLogin.Text;
            string password = tbPasswordTabPassword.Text;
            
            User user = new User();

            if (!File.Exists("client.json"))
            {
                File.Create("client.json");
            }
            var users = db.Users;
            //users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("client.json"));
            bool is_exists = false;
            //UserControHome ucHome = new UserControHome();

            foreach (User u in users)
            {

                if (login == u.login)
                {
                    if (password == u.password)
                    {
                        user.Id = u.Id;
                        user.login = u.login;
                        user.card_namber = u.card_namber;
                        user.password = u.password;
                        user.pin = u.pin;
                        user.balanse = u.balanse;

                        is_exists = true;
                        onLogined(user);
                        
                        Close();
                        //ucHome.BringToFront();
                        break;
                    }
                }
            }

            if (is_exists == false)
            {
                
                lblNotFound.Visible = true;
                lblNotFound.Text = "not found";
            }

        }

        private void lblSingUp_Click(object sender, EventArgs e)
        {
             if (lblSingUp.Text == "Sign up")
            {
                lblSingUp.Text = "Sign in";
                timer1.Start();
                this.BackColor = Color.FromArgb(59, 51, 181);
            }
            else if (lblSingUp.Text == "Sign in")
            {
                lblSingUp.Text = "Sign up";
                timer1.Start();
                this.BackColor = Color.FromArgb(74, 160, 236);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (lblSingUp.Text == "Sign in")
            {
                panel2.Left -= 40;
                panel1.Left -= 40;
                if (panel1.Left <= -280)
                {
                    timer1.Stop();
                }
            }
            if (lblSingUp.Text == "Sign up")
            {
                panel2.Left += 40;
                panel1.Left += 40;
                if (panel1.Left >= 0)
                {
                    timer1.Stop();
                }
            }
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(74, 160, 236);
            btnLogin.BackColor = Color.FromArgb(74, 160, 236);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnRegEnter.BackColor = Color.FromArgb(59, 51, 181);
            //lblHaeding.ForeColor = Color.FromArgb(74, 160, 236);

        }

        private void tbLoginTabLogin_Click(object sender, EventArgs e)
        {
            tbLoginTabLogin.Clear();
        }

        private void tbPasswordTabPassword_Click(object sender, EventArgs e)
        {
            tbPasswordTabPassword.Clear();
        }

        private void tbName_Click(object sender, EventArgs e)
        {
            tbName.Clear();
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
        }

        private void lblCloseReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbRegPin_Click(object sender, EventArgs e)
        {
            tbRegPin.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "lol";
            string password = "kek";
            //List<User> users = new List<User>();
            User user = new User();

            if (!File.Exists("client.json"))
            {
                File.Create("client.json");
            }

            var users = db.Users;
            //users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("client.json"));

            bool is_exists = false;
            //UserControHome ucHome = new UserControHome();

            foreach (User u in users)
            {

                if (login == u.login)
                {
                    if (password == u.password)
                    {
                        user.Id = u.Id;
                        user.login = u.login;
                        user.card_namber = u.card_namber;
                        user.password = u.password;
                        user.pin = u.pin;
                        user.balanse = u.balanse;

                        is_exists = true;
                        onLogined(user);

                        Close();
                        //ucHome.BringToFront();
                        break;
                    }
                }
            }

            if (is_exists == false)
            {
                lblIsLogined.Visible = true;
                lblIsLogined.Text = "not found";
            }

        }
    }
}
