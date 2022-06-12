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
    public class EtkinlikConfiguration : IEntityTypeConfiguration<Etkinlik>
    {
        public void Configure(EntityTypeBuilder<Etkinlik> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturanKullaniciFk).IsRequired();
            builder.Property(x => x.SehirFk).IsRequired();
            builder.Property(x => x.SporFk).IsRequired();
            builder.Property(x => x.Isim).IsRequired();

            builder.HasOne(x => x.Sehir).WithMany(x => x.Etkinlikler).HasForeignKey(x => x.SehirFk);
            builder.HasOne(x => x.OlusturanKullanici).WithMany(x => x.Etkinlikler).HasForeignKey(x => x.OlusturanKullaniciFk);
            builder.HasOne(x => x.Spor).WithMany(x => x.Etkinlikler).HasForeignKey(x => x.SporFk);

            builder.ToTable("etkinlikler");
        }
    }
}
