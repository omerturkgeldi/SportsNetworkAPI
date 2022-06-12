using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Tesisler
{
    public class TesisYorumUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int TesisFk { get; set; }
        public string KullaniciFk { get; set; }
        public string Yorum { get; set; }
    }
}
