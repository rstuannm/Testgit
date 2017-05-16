using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MTLibrary.MTEntity;

namespace MTLibrary.MTContext
{
    public class MTDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
