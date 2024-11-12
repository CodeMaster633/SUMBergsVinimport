using Data_Access.Model;
using DTO_.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Data_Access.Context
{
    internal class LagerContext : DbContext
    {
        public LagerContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlServer("Data Source=LAPTOP-TT7JTDJT\\SQLEXPRESS;Initial Catalog=Lagre;Integrated Security = SSPI; TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("Data Source=LAPTOP-CP8PKIBC\\SQLEXPRESS;Initial Catalog=Lagre;Integrated Security=True; TrustServerCertificate=true");

            //optionsBuilder.UseSqlServer("Data Source=LAPTOP-CP8PKIBC\\SQLEXPRESS;Initial Catalog=Lagre;Integrated Security = SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<Lager>().HasData(new Lager[]
            {
        new Lager { LagerId = 1, Navn = "Tilst Lager", Adresse = "Tilst", Kontaktperson = "Dennis" },
        new Lager { LagerId = 2, Navn = "Harlev Butik", Adresse = "Harlev", Kontaktperson = "Dennis" },
        new Lager { LagerId = 3, Navn = "Harlev Lager", Adresse = "Harlev", Kontaktperson = "Dennis" }
            });

            modelBuilder.Entity<Reol>().HasData(new Reol[]
            {
        new Reol { ReolId = 1,  LagerId = 1 },
        new Reol { ReolId = 2,  LagerId = 1 },
        new Reol { ReolId = 3,  LagerId = 2 },
        new Reol { ReolId = 4,  LagerId = 2 },
        new Reol { ReolId = 5,  LagerId = 3 },
        new Reol { ReolId = 6,  LagerId = 3 }
            });
            //Benytter TPT  Produkt er Basetype tabellen for de andre tabeller som nedarver
            //Klassen Produkt er lavet fordi man ikke kan bruger interface
            modelBuilder.Entity<Produkt>().ToTable("Produkt"); 

            // Hver specifikt produkt har sin egen tabel med de fields som Produkt ikke har (tjek deres kolonner) 
            modelBuilder.Entity<Mad>().ToTable("Mad").HasBaseType<Produkt>();
            modelBuilder.Entity<Nonfood>().ToTable("Nonfood").HasBaseType<Produkt>();
            modelBuilder.Entity<Vin>().ToTable("Vin").HasBaseType<Produkt>();
            modelBuilder.Entity<Øl>().ToTable("Øl").HasBaseType<Produkt>();
            modelBuilder.Entity<Spiritus>().ToTable("Spiritus").HasBaseType<Produkt>();

            // dette kode ValueGenereted hvor ved hver post til Database skal der sættes et nyt unikt ID 
            modelBuilder.Entity<Produkt>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd(); // SQL Server genererer automatisk Id


		}
        public DbSet<Lager> Lagre { get; set; }
        public DbSet<Produkt> Produkt { get; set; } 

        public DbSet<Mad> Mad { get; set; }
        public DbSet<Vin> Vin { get; set; }

        public DbSet<Nonfood> Nonfoods { get; set; }
        public DbSet<Spiritus> Spiritus { get; set; }

        public DbSet<Øl> Øls { get; set; }

    }
}
