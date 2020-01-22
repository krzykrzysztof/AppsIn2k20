using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalsCatalogApp
{
    class Animal
    {
        public Nullable<int> Id { get; set; }
        public string Name { get; set; }
        public int MaxHeight { get; set; }
        public float MaxWeight { get; set; }
        public string Country { get; set; }
        public int MaxAge { get; set; }
        string image = "zdj.jpg";
    }
}
