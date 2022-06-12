using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Mesajlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Mesajlar
{
    public class GrupMesajConfiguration : IEntityTypeConfiguration<GrupMesaj>
    {
        public void Configure(EntityTypeBuilder<GrupMesaj> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.Mesaj).IsRequired();
            builder.Property(x => x.GrupFk).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();

            builder.HasOne(x => x.Grup).WithMany(x => x.GrupMesajlar).HasForeignKey(x => x.GrupFk);
            builder.HasOne(x => x.Kullanici).WithMany(x => x.GrupMesajlar).HasForeignKey(x => x.KullaniciFk);


            builder.ToTable("grup_mesajlari");
        }
    }
}
