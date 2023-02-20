using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI_OneToOne_003
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(@"server=Admin; Database=FluentAPIOneToOne; Trusted_Connection=True; Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.AddressId)
                .WithOne(a => a.Students)
                .HasForeignKey<StudentAddress>(p => p.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
    }
}
