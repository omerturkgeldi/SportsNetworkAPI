using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Etkinlikler
{
    public class EtkinlikYorumBegeniDto : BaseIntIdDto
    {
        public int EtkinlikYorumFk { get; set; }
        public string KullaniciFk { get; set; }
    }
}
