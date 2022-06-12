using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Mesajlar
{
    public class GrupMesajDto : BaseIntIdDto
    {
        public int GrupFk { get; set; }
        public string KullaniciFk { get; set; }
        public string Mesaj { get; set; }
    }
}
