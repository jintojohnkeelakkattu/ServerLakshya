using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AdminSolution.DataLayer
{
    public class DbLayerContext: DbContext
    {

        //public DbLayerContext(DbContextOptions<DbLayerContext> options)
        //    : base(options)
        //    {

        //    }
            public DbSet<ClientContacts> ClientContacts
            {
                get;
                set;
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<ClientContacts>().ToTable("ClientContact");
                modelBuilder.Entity<ClientContacts>().Property(p => p.ID).ValueGeneratedOnAdd();
        
            }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Sample;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
