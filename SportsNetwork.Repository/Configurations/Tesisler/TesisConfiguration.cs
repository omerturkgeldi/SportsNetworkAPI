using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Tesisler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Tesisler
{
    public class TesisConfiguration : IEntityTypeConfiguration<Tesis>
    {
        public void Configure(EntityTypeBuilder<Tesis> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.SehirFk).IsRequired();
            builder.Property(x => x.TesisSahibiFk).IsRequired();
            builder.Property(x => x.Isim).IsRequired().HasMaxLength(200);

            builder.HasOne(x => x.Sehir).WithMany(x => x.Tesisler).HasForeignKey(x => x.SehirFk);
            builder.HasOne(x => x.TesisSahibi).WithMany(x => x.Tesisler).HasForeignKey(x => x.TesisSahibiFk);

            builder.ToTable("tesisler");
        }
    }
}
