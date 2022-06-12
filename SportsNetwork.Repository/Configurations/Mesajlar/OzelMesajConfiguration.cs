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
    public class OzelMesajConfiguration : IEntityTypeConfiguration<OzelMesaj>
    {
        public void Configure(EntityTypeBuilder<OzelMesaj> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.Mesaj).IsRequired();
            builder.Property(x => x.Kullanici1Fk).IsRequired();
            builder.Property(x => x.Kullanici2Fk).IsRequired();

            builder.HasOne(x => x.Kullanici1).WithMany(x => x.OzelMesajlar).HasForeignKey(x => x.Kullanici1Fk);
            builder.HasOne(x => x.Kullanici2).WithMany(x => x.OzelMesajlar).HasForeignKey(x => x.Kullanici2Fk);


            builder.ToTable("ozel_mesajlar");
        }
    }
}
