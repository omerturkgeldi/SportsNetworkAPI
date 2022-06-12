using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Etkinlikler
{
    public class EtkinlikDetayUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int EtkinlikFk { get; set; }
        public int TesisFk { get; set; }
        public string Konum { get; set; }
        public string Aciklama { get; set; }
        public byte Seviye { get; set; }
        public string KonumIsmi { get; set; }
    }
}
