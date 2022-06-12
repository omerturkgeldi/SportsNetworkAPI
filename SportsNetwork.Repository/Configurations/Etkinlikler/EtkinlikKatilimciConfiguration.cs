using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Etkinlikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Etkinlikler
{
    public class EtkinlikKatilimciConfiguration : IEntityTypeConfiguration<EtkinlikKatilimci>
    {
        public void Configure(EntityTypeBuilder<EtkinlikKatilimci> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.EtkinlikFk).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();

            builder.HasOne(x => x.Etkinlik).WithMany(x => x.EtkinlikKatilimcilar).HasForeignKey(x => x.EtkinlikFk);
            builder.HasOne(x => x.Kullanici).WithMany(x => x.EtkinlikKatilimcilar).HasForeignKey(x => x.KullaniciFk);

            builder.ToTable("etkinlik_katilimcilari");
        }
    }
}
