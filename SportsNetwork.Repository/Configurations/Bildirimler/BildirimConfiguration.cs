using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Bildirimler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Bildirimler
{
    public class BildirimConfiguration : IEntityTypeConfiguration<Bildirim>
    {
        public void Configure(EntityTypeBuilder<Bildirim> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.BildirimBasligi).HasMaxLength(50);
            builder.Property(x => x.BildirimIcerik).IsRequired().HasMaxLength(300);
            builder.Property(x => x.EkleyenKullaniciFk).IsRequired();

            builder.HasOne(x => x.EkleyenKullanici).WithMany(x => x.Bildirimler).HasForeignKey(x => x.EkleyenKullaniciFk);


            builder.ToTable("bildirimler");
        }
    }
}
