using SportsNetwork.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;
using SportsNetwork.Data.Models;
using SportsNetwork.Core.Models.Bildirimler;
using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Models.Gruplar;
using SportsNetwork.Core.Models.Iliskiler;
using SportsNetwork.Core.Models.Mesajlar;
using SportsNetwork.Core.Models.Tesisler;

namespace SportsNetwork.Repository
{
    public class AppDbContext : IdentityDbContext<UserApp, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Log> Loglar { get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }
        
        public DbSet<Bildirim> Bildirimler { get; set; }
        public DbSet<KullaniciBildirim> KullaniciBildirimler { get; set; }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<DersRezervasyon> DersRezervasyonlar { get; set; }

        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<EtkinlikDetay> EtkinlikDetaylar { get; set; }
        public DbSet<EtkinlikKatilimci> EtkinlikKatilimcilar { get; set; }
        public DbSet<EtkinlikYorum> EtkinlikYorumlar { get; set; }
        public DbSet<EtkinlikYorumBegeni> EtkinlikYorumBegeniler { get; set; }

        public DbSet<Grup> Gruplar { get; set; }
        public DbSet<GrupKullanici> GrupKullanicilar { get; set; }

        public DbSet<Iliski> Iliskiler { get; set; }
        public DbSet<IliskiStatu> IliskiStatuler { get; set; }

        public DbSet<GrupMesaj> GrupMesajlar { get; set; }
        public DbSet<OzelMesaj> OzelMesajlar { get; set; }

        public DbSet<Tesis> Tesisler { get; set; }
        public DbSet<TesisRezervasyon> TesisRezervasyonlar { get; set; }
        public DbSet<TesisYorum> TesisYorumlar { get; set; }
        public DbSet<TesisYorumBegeni> TesisYorumBegeniler { get; set; }

        public DbSet<Puanlama> Puanlamalar { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Sonuc> Sonuclar { get; set; }
        public DbSet<Spor> Sporlar { get; set; }



        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.Entity)
                    {
                        case EntityState.Added:
                            {
                                entityReference.OlusturulanTarih = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                entityReference.GuncellemeTarihi = DateTime.Now;
                                break;
                            }

                    }
                }
            }
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.OlusturulanTarih=DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.OlusturulanTarih).IsModified = false;

                                entityReference.GuncellemeTarihi = DateTime.Now;
                                break;
                            }
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

        }


    }

}
