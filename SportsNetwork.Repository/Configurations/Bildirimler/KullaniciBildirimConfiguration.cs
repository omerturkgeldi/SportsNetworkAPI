using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsNetwork.Core.Models.Bildirimler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Configurations.Bildirimler
{
    /**************************************************************** 
    * Date: 20.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ < turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/

    public class KullaniciBildirimConfiguration : IEntityTypeConfiguration<KullaniciBildirim>
    {
        public void Configure(EntityTypeBuilder<KullaniciBildirim> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IletilmeTarihi).IsRequired();
            builder.Property(x => x.KullaniciFk).IsRequired();
            builder.Property(x => x.BildirimFk).IsRequired();

            builder.HasOne(x => x.Kullanici).WithMany(x => x.KullaniciBildirimler).HasForeignKey(x => x.KullaniciFk);
            builder.HasOne(x => x.Bildirim).WithMany(x => x.KullaniciBildirimler).HasForeignKey(x => x.BildirimFk);

            builder.ToTable("kullanici_bildirimleri");

        }
    }
}
