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
    public class IliskiStatuConfiguration : IEntityTypeConfiguration<IliskiStatu>
    {
        public void Configure(EntityTypeBuilder<IliskiStatu> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OlusturulanTarih).IsRequired();

            builder.ToTable("iliski_statuleri");
        }
    }
}
