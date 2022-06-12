using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Bildirimler
{
    public class KullaniciBildirimDto: BaseIntIdDto
    {
        public int BildirimFk { get; set; }
        public string KullaniciFk { get; set; }
        public bool OkunduMu { get; set; }
        public DateTime IletilmeTarihi { get; set; }
        public DateTime OkunmaTarihi { get; set; }

    }
}
