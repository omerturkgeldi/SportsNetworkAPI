using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations
{
    public class PuanlamaConfiguration : IEntityTypeConfiguration<Puanlama>
    {
        public void Configure(EntityTypeBuilder<Puanlama> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.Kullanici1Fk).IsRequired();
            builder.Property(x => x.Kullanici2Fk).IsRequired();
            builder.Property(x => x.Puan).IsRequired();

            builder.HasOne(x => x.Kullanici1).WithMany(x => x.Puanlamalar).HasForeignKey(x => x.Kullanici1Fk);
            builder.HasOne(x => x.Kullanici2).WithMany(x => x.Puanlamalar).HasForeignKey(x => x.Kullanici2Fk);

            builder.ToTable("puanlamalar");
        }
    }
}
