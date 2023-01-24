using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace entitycodefirst.entity
{
    class Context:DbContext
    {
        public DbSet<Urunler> urunlers { get; set; }

        public DbSet<Kategoriler> Kategorilers { get; set; }

        public DbSet<Musteriler> Musterilers { get; set; }

    }
}
 