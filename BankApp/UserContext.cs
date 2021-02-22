using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class UserContext:DbContext
    {
        public UserContext() : base(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString)
        { }
        public DbSet<User> Users { get; set; }
    }
}
