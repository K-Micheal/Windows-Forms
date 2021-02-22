using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class UCTransfer : UserControl
    {
        User userTransfer = new User();
        UserContext db = new UserContext();
        int Userid;
        int UserBalanse;
        public UCTransfer(User userTransfer)
        {
            InitializeComponent();

            Userid = userTransfer.Id;
            UserBalanse = userTransfer.balanse;
            lblBalanseCard.Text = userTransfer.balanse.ToString();
            tbCardNumber.Text = userTransfer.card_namber;
            btnTransfer.BackColor = Color.FromArgb(140, 138, 138);

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var users = db.Users;
            int i = int.Parse(tbSumTrabsfer.Text);
            bool transfer_done = false;

            string s = mtbTransgerCardNuber.Text;
            string s1;
            s1 = s.Remove(4, 1);
            s = s1.Remove(8, 1);
            s1 = s.Remove(12, 1);

            foreach (var u in db.Users)
            {
                if (u.card_namber == s1 & UserBalanse >= i)
                {

                    u.balanse = u.balanse + i;
                    transfer_done = true;
                    

                    break;
                }
            }
            db.SaveChanges();
            foreach (var u1 in db.Users)
            {
                    if (u1.Id == Userid & transfer_done==true)
                    {
                    
                    
                            u1.balanse = u1.balanse - i;
                    lblSuccess.Text = "Success";
                    lblSuccess.Visible = true;
                        break;
                    }

                    
            }
            db.SaveChanges();

        }
    }
}
