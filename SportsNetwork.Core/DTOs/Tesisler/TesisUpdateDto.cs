using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Tesisler
{
    public class TesisUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public string TesisSahibiFk { get; set; }
        public int SehirFk { get; set; }
        public string Konum { get; set; }
        public string KonumAdres { get; set; }
    }
}
