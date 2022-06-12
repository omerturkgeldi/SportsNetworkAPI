using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Dersler
{
    public class DersUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string EgitmenFk { get; set; }
        public int SehirFk { get; set; }
        public int TesisFk { get; set; }
        public int SporFk { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Konum { get; set; }
        public string KonumIsmi { get; set; }
        public decimal SaatlikUcret { get; set; }

    }
}
