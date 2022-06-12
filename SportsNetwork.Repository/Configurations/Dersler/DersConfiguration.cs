using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Dersler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Dersler
{
    public class DersConfiguration : IEntityTypeConfiguration<Ders>
    {
        public void Configure(EntityTypeBuilder<Ders> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.EgitmenFk).IsRequired();
            builder.Property(x => x.TesisFk).IsRequired();
            builder.Property(x => x.SehirFk).IsRequired();
            builder.Property(x => x.SporFk).IsRequired();
            builder.Property(x => x.Baslik).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Aciklama).HasMaxLength(500);

            builder.HasOne(x => x.Tesis).WithMany(x => x.Dersler).HasForeignKey(x => x.TesisFk);
            builder.HasOne(x => x.Sehir).WithMany(x => x.Dersler).HasForeignKey(x => x.SehirFk);
            builder.HasOne(x => x.Egitmen).WithMany(x => x.Dersler).HasForeignKey(x => x.EgitmenFk);
            builder.HasOne(x => x.Spor).WithMany(x => x.Dersler).HasForeignKey(x => x.SporFk);

            builder.ToTable("dersler");

        }
    }
}
