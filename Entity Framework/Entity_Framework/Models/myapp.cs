using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Entity_Framework.Models
{
    public class myapp : DbContext
    {
        public myapp(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<departments> departments { get; set; }

    }
}
