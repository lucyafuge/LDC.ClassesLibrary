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
        public DbSet<Sign> Signs => Set<Sign>();
    }
}
