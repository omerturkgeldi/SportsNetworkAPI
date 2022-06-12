using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Dersler
{
    public class DersRezervasyonDto : BaseIntIdDto
    {
        public int DersFk { get; set; }
        public string KursiyerKullaniciFk { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool Onay { get; set; }

    }
}
