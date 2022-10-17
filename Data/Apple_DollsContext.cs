using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apple_Dolls.Models;

namespace Apple_Dolls.Data
{
    public class Apple_DollsContext : DbContext
    {
        public Apple_DollsContext(DbContextOptions<Apple_DollsContext> options)
            : base(options)
        {
        }

        public DbSet<Doll> Doll { get; set; }
    }
}
