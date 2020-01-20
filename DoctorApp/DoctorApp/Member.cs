using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApp
{
     class Member
    {
        public Nullable<int> Id { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public DateTime LastVisit { get; set; }
        public int Age { get; set; }
        public Medicine MedicnesId { get; set; }
    }
}
