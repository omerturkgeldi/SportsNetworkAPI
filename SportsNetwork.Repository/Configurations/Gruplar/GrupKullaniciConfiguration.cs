using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Gruplar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Gruplar
{
    public class GrupKullaniciConfiguration : IEntityTypeConfiguration<GrupKullanici>
    {
        public void Configure(EntityTypeBuilder<GrupKullanici> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.GrupFk).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();


            builder.HasOne(x => x.Grup).WithMany(x => x.GrupKullanicilar).HasForeignKey(x => x.GrupFk);
            builder.HasOne(x => x.Kullanici).WithMany(x => x.GrupKullanicilar).HasForeignKey(x => x.KullaniciFk);


            builder.ToTable("grup_kullanicilari");
        }
    }
}
