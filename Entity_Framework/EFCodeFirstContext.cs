using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class EFCodeFirstContext : DbContext
    {
        public EFCodeFirstContext():base()
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<category>Categories { get; set; }
    }
}
