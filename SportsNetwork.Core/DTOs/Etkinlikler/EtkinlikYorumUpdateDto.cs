using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Etkinlikler
{
    public class EtkinlikYorumUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int EtkinlikFk { get; set; }
        public string KullaniciFk { get; set; }
        public string Yorum { get; set; }
    }
}
