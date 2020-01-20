using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoctorApp
{
    class DoctorAppDbContext : DbContext
    {
     public DbSet<Medicine> Medicines { get; set; }
     public DbSet<Member> Members { get; set; }
    }
}
