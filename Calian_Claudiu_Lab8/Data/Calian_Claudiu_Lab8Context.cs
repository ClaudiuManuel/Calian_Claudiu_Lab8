using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calian_Claudiu_Lab8.Models;

namespace Calian_Claudiu_Lab8.Data
{
    public class Calian_Claudiu_Lab8Context : DbContext
    {
        public Calian_Claudiu_Lab8Context (DbContextOptions<Calian_Claudiu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Calian_Claudiu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Calian_Claudiu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Calian_Claudiu_Lab8.Models.Category> Category { get; set; }
    }
}
