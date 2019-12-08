using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options ) :base(options)
         {

        }
        public  DbSet<Weather>  Weathers { get; set; }
        protected override void OnModelCreating(ModelBuilder  builder)
        {
            builder.Entity<Weather>()
             .HasData(
                 new Weather {Id = 1  , Name = "value 101"},
                  new Weather {Id = 2  , Name = "value 102"},
                   new Weather {Id = 3  , Name = "value 103"},
                    new Weather {Id = 4  , Name = "value 104"}
             );
        }
    }
}
