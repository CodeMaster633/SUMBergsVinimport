using Data_Access.Model;
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
			//optionsBuilder.UseSqlServer("Data Source=LAPTOP-CP8PKIBC\\SQLEXPRESS;Initial Catalog=Lagre;Integrated Security = SSPI; TrustServerCertificate=true");
			optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lager>().HasData(new Lager[] {
                new Lager{Id=-1,Navn="Tilst Lager", Adresse="Tilst", Kontaktperson="Dennis"},
                new Lager{Id=-2,Navn="Harlev Butik", Adresse="Harlev", Kontaktperson="Dennis" },
                new Lager{Id=-3,Navn="Harlev Lager", Adresse="Harlev", Kontaktperson="Dennis"}
            });
        }
        public DbSet<Lager> Lagre { get; set; }
    }
}
