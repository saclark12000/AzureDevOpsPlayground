using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data.Entities
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(b => b.UserId)
                .IsRequired();
        }

        public CodeFirstContext(DbContextOptions<CodeFirstContext> options)
            :base(options)
        {
        }

    }
}
