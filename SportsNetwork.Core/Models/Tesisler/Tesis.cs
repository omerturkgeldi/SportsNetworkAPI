using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Models.Etkinlikler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Tesisler
{
    public class Tesis : BaseEntity
    {
        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public string TesisSahibiFk { get; set; }
        public int SehirFk { get; set; }
        public string Konum { get; set; }
        public string KonumAdres { get; set; }

        [ForeignKey("SehirFk")]
        public Sehir Sehir { get; set; }

        [ForeignKey("TesisSahibiFk")]
        public UserApp TesisSahibi { get; set; }

        public ICollection<TesisRezervasyon> TesisRezervasyonlar { get; set; }
        public ICollection<TesisYorum> TesisYorumlar { get; set; }
        public ICollection<Ders> Dersler { get; set; }
        public ICollection<EtkinlikDetay> EtkinlikDetaylar { get; set; }

    }
}
