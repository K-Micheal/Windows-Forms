using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //User user1 = new User { balanse = "2500", card_namber = "0980406591", login = "lol", password = "kek", pin = "1111" };
            //UserContext db = new UserContext();
            //db.Users.Add(user1);
            //db.SaveChanges();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankForm());

          

        }
    }
}
