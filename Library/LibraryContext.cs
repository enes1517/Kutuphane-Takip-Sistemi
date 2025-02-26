using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryContext:DbContext
    {

        public DbSet<product> Products { get; set; }
    }

    public class BookContext : DbContext
    {

        public DbSet<book> Books { get; set; }

    }

    public class MemberContext:DbContext
    {
        public DbSet<member> Members { get; set; }

    }

}
