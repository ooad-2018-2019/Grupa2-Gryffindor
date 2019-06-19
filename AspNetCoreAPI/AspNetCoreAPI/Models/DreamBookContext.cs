using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetCoreAPI.Models
{
    public partial class DreamBookContext : DbContext
    {
        public DreamBookContext()
        {
        }

        public DreamBookContext (DbContextOptions<DreamBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Knjiga> Knjiga { get; set; }
        public virtual DbSet<Kupac> Kupac { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Knjiga>(entity =>
            {
                entity.Property(e => e.Naslov)
                    .HasColumnName("Naslov")
                   ;

                entity.Property(e => e.Autor)
                    .IsRequired()
                    ;
                entity.Property(e => e.Cijena)
                    .IsRequired()
                    ;
                entity.Property(e => e.Kolicina)
                    .IsRequired()
                    ;
            });

            modelBuilder.Entity<Kupac>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.Ime).IsRequired();
                entity.Property(e => e.Prezime).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Sifra).IsRequired();
                entity.Property(e => e.Grad).IsRequired();
                entity.Property(e => e.Adresa).IsRequired();
                entity.Property(e => e.Telefon).IsRequired();

            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.Property(e => e.ID);
                entity.Property(e => e.ListaKnjiga).IsRequired();
            });
        }
    }
}