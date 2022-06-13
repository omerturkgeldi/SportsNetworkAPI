using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Iliskiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Iliskiler
{
    public class IliskiConfiguration : IEntityTypeConfiguration<Iliski>
    {
        public void Configure(EntityTypeBuilder<Iliski> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.IliskiStatuFk).IsRequired();
            builder.Property(x => x.Kullanici1Fk).IsRequired();
            builder.Property(x => x.Kullanici2Fk).IsRequired();

            builder.HasOne(x => x.IliskiStatu).WithMany(x => x.Iliskiler).HasForeignKey(x => x.IliskiStatuFk);
            //builder.HasOne(x => x.Kullanici1).WithMany(x => x.Iliskiler).HasForeignKey(x => x.Kullanici1Fk);
            //builder.HasOne(x => x.Kullanici2).WithMany(x => x.Iliskiler).HasForeignKey(x => x.Kullanici2Fk);


            builder.ToTable("iliskiler");
        }
    }
}
