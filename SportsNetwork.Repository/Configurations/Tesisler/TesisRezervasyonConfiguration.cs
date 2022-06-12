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
    public class TesisRezervasyonConfiguration : IEntityTypeConfiguration<TesisRezervasyon>
    {
        public void Configure(EntityTypeBuilder<TesisRezervasyon> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.TesisFk).IsRequired();
            builder.Property(x => x.RezerveEdenKullaniciFk).IsRequired();
            builder.Property(x => x.BaslangicTarihi).IsRequired();
            builder.Property(x => x.BitisTarihi).IsRequired();

            builder.HasOne(x => x.Tesis).WithMany(x => x.TesisRezervasyonlar).HasForeignKey(x => x.TesisFk);
            builder.HasOne(x => x.RezerveEdenKullanici).WithMany(x => x.TesisRezervasyonlar).HasForeignKey(x => x.RezerveEdenKullaniciFk);


            builder.ToTable("tesis_rezervasyonlari");
        }
    }
}
