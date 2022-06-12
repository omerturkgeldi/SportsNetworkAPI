using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Gruplar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Gruplar
{
    public class GrupConfiguration : IEntityTypeConfiguration<Grup>
    {
        public void Configure(EntityTypeBuilder<Grup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.OlusturanKullaniciFk).IsRequired();
            builder.Property(x => x.GrupIsmi).IsRequired().HasMaxLength(150);

            builder.HasOne(x => x.OlusturanKullanici).WithMany(x => x.Gruplar).HasForeignKey(x => x.OlusturanKullaniciFk);


            builder.ToTable("gruplar");
        }
    }
}
