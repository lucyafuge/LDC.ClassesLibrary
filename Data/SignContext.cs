using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC.ClassesLibrary.Data
{
    internal class SignContext : DbContext
    {
        private string ConnectionString { get; set; }
        public DbSet<Sign> Signs => Set<Sign>();

        public SignContext(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
