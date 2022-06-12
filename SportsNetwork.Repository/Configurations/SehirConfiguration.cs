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
    public class SehirConfiguration : IEntityTypeConfiguration<Sehir>
    {
        public void Configure(EntityTypeBuilder<Sehir> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.PlakaNo).IsRequired();
            builder.Property(x => x.SehirIsmi).IsRequired().HasMaxLength(20);
            builder.HasIndex(x => x.PlakaNo).IsUnique();


            builder.ToTable("sehirler");
        }
    }
}
