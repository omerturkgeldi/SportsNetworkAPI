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
    public class TesisYorumConfiguration : IEntityTypeConfiguration<TesisYorum>
    {
        public void Configure(EntityTypeBuilder<TesisYorum> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();
            builder.Property(x => x.TesisFk).IsRequired();
            builder.Property(x => x.Yorum).IsRequired().HasMaxLength(500);

            builder.HasOne(x => x.Kullanici).WithMany(x => x.TesisYorumlar).HasForeignKey(x => x.KullaniciFk);
            builder.HasOne(x => x.Tesis).WithMany(x => x.TesisYorumlar).HasForeignKey(x => x.TesisFk);

            builder.ToTable("tesis_yorumlari");
        }
    }
}
