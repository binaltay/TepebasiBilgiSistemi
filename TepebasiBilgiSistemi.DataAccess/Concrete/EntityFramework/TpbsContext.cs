using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.DataAccess.Concrete.EntityFramework
{
    public class TpbsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(@"Host=172.16.24.38;Database=cbssozluk;Username=postgres;Password=Tpb1372ALY!");            
            optionsBuilder.UseNpgsql("Host=172.16.24.37;Database=tpbsbilsis25;Username=postgres;Password=Tpb1372ALY!",
                o => o.UseNetTopologySuite());
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasPostgresExtension("postgis");
        }
        public DbSet<Baskan> Baskan { get; set; }
        public DbSet<BaskanMudurluk> BaskanMudurluk { get; set; }
        public DbSet<Belge> Belge { get; set; }
        public DbSet<BelgeMudurluk> BelgeMudurluk { get; set; }
        public DbSet<ButceMudurluk> ButceMudurluk { get; set; }
        public DbSet<Calisan> Calisan { get; set; }        
        public DbSet<Egitim> Egitim { get; set; }        
        public DbSet<Etkinlik> Etkinlik { get; set; }        
        public DbSet<IstekSikayet> IstekSikayet { get; set; }        
        public DbSet<Kadro> Kadro { get; set; }        
        public DbSet<Kurs> Kurs { get; set; }        
        public DbSet<Mahalle> Mahalle { get; set; }        
        public DbSet<Mudurluk> Mudurluk { get; set; }        
        
    }
}