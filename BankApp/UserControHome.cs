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
    public partial class UserControHome : UserControl
    {
        public User userHome { get; set; }
        
        public UserControHome(User userHome)
        {
            InitializeComponent();

            if (userHome == null)
            {         
                lblHomeLogin.Text = "null";
            }
            else
            {
                lblHomeLogin.Text = userHome.login;
                lblBalanseCard.Text = userHome.balanse.ToString();
                tbCardNumber.Text = userHome.card_namber;
            }
        }

    }
}
