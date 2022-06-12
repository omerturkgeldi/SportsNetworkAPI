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
    public class DersRezervasyonConfiguration : IEntityTypeConfiguration<DersRezervasyon>
    {
        public void Configure(EntityTypeBuilder<DersRezervasyon> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DersFk).IsRequired();
            builder.Property(x => x.KursiyerKullaniciFk).IsRequired();

            builder.HasOne(x => x.Ders).WithMany(x => x.DersRezervasyonlar).HasForeignKey(x => x.DersFk);
            builder.HasOne(x => x.KursiyerKullanici).WithMany(x => x.DersRezervasyonlar).HasForeignKey(x => x.KursiyerKullaniciFk);

            builder.ToTable("ders_rezervasyonlari");

        }
    }
}
