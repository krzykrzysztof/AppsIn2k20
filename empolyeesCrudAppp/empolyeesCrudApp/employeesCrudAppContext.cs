using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using empolyeesCrudApp.Model;

namespace empolyeesCrudApp
{
    class employeesCrudAppContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
    }
}
