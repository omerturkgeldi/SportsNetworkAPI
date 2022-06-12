using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Etkinlikler
{
    public class Etkinlik : BaseEntity
    {
        public string OlusturanKullaniciFk { get; set; }
        public string Isim { get; set; }
        public int SporFk { get; set; }
        public int SehirFk { get; set; }
        public byte Durum { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp OlusturanKullanici { get; set; }

        [ForeignKey("SporFk")]
        public Spor Spor { get; set; }

        [ForeignKey("SehirFk")]
        public Sehir Sehir { get; set; }

        public ICollection<EtkinlikYorumBegeni> EtkinlikYorumBegeniler { get; set; }
        public ICollection<EtkinlikKatilimci> EtkinlikKatilimcilar { get; set; }
        public ICollection<EtkinlikYorum> EtkinlikYorumlar { get; set; }
        public EtkinlikDetay EtkinlikDetay { get; set; }
        public Sonuc Sonuc { get; set; }

    }
}
