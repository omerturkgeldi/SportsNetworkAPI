using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Etkinlikler
{
    public class EtkinlikYorumDto : BaseIntIdDto
    {
        public int EtkinlikFk { get; set; }
        public string KullaniciFk { get; set; }
        public string Yorum { get; set; }
    }
}
