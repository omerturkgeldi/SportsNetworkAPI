using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Etkinlikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Etkinlikler
{
    public class EtkinlikYorumConfiguration : IEntityTypeConfiguration<EtkinlikYorum>
    {
        public void Configure(EntityTypeBuilder<EtkinlikYorum> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.EtkinlikFk).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();

            builder.ToTable("etkinlik_yorumlari");
        }
    }
}
