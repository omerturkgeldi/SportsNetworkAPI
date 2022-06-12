using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Bildirimler
{
    public class BildirimDto : BaseIntIdDto
    {
        public string BildirimBasligi { get; set; }
        public string BildirimTip { get; set; }
        public string BildirimIcerik { get; set; }
        public string EkleyenKullaniciFk { get; set; }

    }
}
