using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DreamBook.Models;

namespace DreamBook.Models
{
    public class DreamBookContext : DbContext
    {

        public DreamBookContext(DbContextOptions<DreamBookContext> options) : base(options)
        {
        }
        public DreamBookContext()

        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kupac>().ToTable("Kupac");
            modelBuilder.Entity<Profil>().ToTable("Profil");


        }

        public DbSet<Kupac> Kupac { get; set; }
        public DbSet<Administrator> Administrator { get; set; }

        public DbSet<Narudzba> Narudzba { get; set; }

        public DbSet<Profil> Profil { get; set; }

        public DbSet<Knjiga> Knjiga { get; set; }
    }
}
