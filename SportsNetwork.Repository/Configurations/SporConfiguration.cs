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
    public class SporConfiguration : IEntityTypeConfiguration<Spor>
    {
        public void Configure(EntityTypeBuilder<Spor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();
            builder.Property(x => x.Isim).IsRequired().HasMaxLength(100);

            builder.ToTable("sporlar");
        }
    }
}
