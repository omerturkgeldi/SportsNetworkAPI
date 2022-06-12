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
    public class EtkinlikYorumBegeniConfiguration : IEntityTypeConfiguration<EtkinlikYorumBegeni>
    {
        public void Configure(EntityTypeBuilder<EtkinlikYorumBegeni> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.EtkinlikFk).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();

            builder.HasOne(x => x.Kullanici).WithMany(x => x.EtkinlikYorumBegeniler).HasForeignKey(x => x.KullaniciFk);
            builder.HasOne(x => x.Etkinlik).WithMany(x => x.EtkinlikYorumBegeniler).HasForeignKey(x => x.EtkinlikFk);

            builder.ToTable("etkinlik_yorum_begenileri");
        }
    }
}
