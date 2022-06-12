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
    public class EtkinlikDetayConfiguration : IEntityTypeConfiguration<EtkinlikDetay>
    {
        public void Configure(EntityTypeBuilder<EtkinlikDetay> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.EtkinlikFk).IsRequired();
            builder.Property(x => x.TesisFk).IsRequired();
            builder.Property(x => x.KonumIsmi).IsRequired().HasMaxLength(300);

            //builder.HasOne(x => x.Etkinlik).WithOne(x => x.EtkinlikDetay).HasForeignKey(x => x.EtkinlikFk);
            builder.HasOne(x => x.Tesis).WithMany(x => x.EtkinlikDetaylar).HasForeignKey(x => x.TesisFk);


            builder.ToTable("etkinlik_detaylari");
        }
    }
}
