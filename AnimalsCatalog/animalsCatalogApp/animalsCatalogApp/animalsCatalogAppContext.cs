﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalsCatalogApp
{
    class animalsCatalogAppContext :DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}
