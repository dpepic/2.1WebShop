using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1WebShop
{
    internal class Db : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikal>()
                .HasKey(a => a.Id);
            modelBuilder.Entity<Person>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Address>()
                .HasKey(a => a.Id);
            modelBuilder.Entity<Order>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Artikals)
                .WithMany(a => a.Orders);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Address);
            modelBuilder.Entity<Admin>().HasData
                (
                    new Admin[]
                    {
                        new Admin { Id=-1, Name = "john", Surname = "doe", Email = "john@gmail.com", Username = "john", Password = "john", TajniBroj=4 },
                        new Admin { Id=-2, Name = "qqq", Surname = "qqq", Email = "john@gmail.com", Username = "qqq", Password = "qqq", TajniBroj=8 },
                        
                    }
                );
            modelBuilder.Entity<User>().HasData
                (
                    new User[]
                    {
                        new User { Id=-3, Name = "qwe", Surname = "muller", Email = "ana@gmail.com", Username = "ana", Password = "ana", NestoZaKorisnika="asd" },
                        new User { Id=-4, Name = "zxc", Surname = "muller", Email = "ana@gmail.com", Username = "ana", Password = "ana", NestoZaKorisnika="qzcv" }
                    }
                );
        }

        public DbSet<Artikal> Artikals { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
