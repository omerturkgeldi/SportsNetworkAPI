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
    public class TesisYorumBegeniConfiguration : IEntityTypeConfiguration<TesisYorumBegeni>
    {
        public void Configure(EntityTypeBuilder<TesisYorumBegeni> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.TesisYorumFk).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();

            builder.HasOne(x => x.TesisYorum).WithMany(x => x.TesisYorumBegeniler).HasForeignKey(x => x.TesisYorumFk);
            builder.HasOne(x => x.Kullanici).WithMany(x => x.TesisYorumBegeniler).HasForeignKey(x => x.KullaniciFk);

            builder.ToTable("tesis_yorum_begenileri");
        }
    }
}
