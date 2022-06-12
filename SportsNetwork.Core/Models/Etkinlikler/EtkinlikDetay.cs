using SportsNetwork.Core.Models.Tesisler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Etkinlikler
{
    public class EtkinlikDetay : BaseEntity
    {
        public int EtkinlikFk { get; set; }
        public int TesisFk { get; set; }
        public string Konum { get; set; }
        public string Aciklama { get; set; }
        public byte Seviye { get; set; }
        public string KonumIsmi { get; set; }


        [ForeignKey("EtkinlikFk")]
        public Etkinlik Etkinlik { get; set; }

        [ForeignKey("TesisFk")]
        public Tesis Tesis { get; set; }
    }
}
