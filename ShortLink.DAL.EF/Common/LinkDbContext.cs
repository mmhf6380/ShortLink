using Microsoft.EntityFrameworkCore;
using ShortLink.Core.Entities.Links;
using ShortLink.Core.Entities.Persons;
using ShortLink.DAL.EF.Links;
using ShortLink.DAL.EF.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.DAL.EF.Common
{
    public class LinkDbContext:DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server =.; Database = ShortLink; Integrated Security = True; MultipleActiveResultSets = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LinkConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());


        }
    }
}
