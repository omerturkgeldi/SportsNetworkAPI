using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations
{
    public class SonucConfiguration : IEntityTypeConfiguration<Sonuc>
    {
        public void Configure(EntityTypeBuilder<Sonuc> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.EtkinlikFk).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();
            builder.Property(x => x.SporFk).IsRequired();

            //builder.HasOne(x => x.Etkinlik).WithOne(x => x.Sonuc).HasForeignKey(x => x.EtkinlikFk);

            builder.HasOne(x => x.Kullanici).WithMany(x => x.Sonuclar).HasForeignKey(x => x.KullaniciFk);

            builder.HasOne(x => x.Spor).WithMany(x => x.Sonuclar).HasForeignKey(x => x.SporFk);

            builder.ToTable("sonuclar");
        }
    }
}
