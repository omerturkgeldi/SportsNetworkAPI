using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Tesisler
{
    public class TesisRezervasyonDto : BaseIntIdDto
    {
        public int TesisFk { get; set; }
        public string RezerveEdenKullaniciFk { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool Onay { get; set; }
    }
}
