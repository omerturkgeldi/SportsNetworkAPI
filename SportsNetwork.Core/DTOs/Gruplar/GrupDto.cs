using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Gruplar
{
    public class GrupDto : BaseIntIdDto
    {
        public string OlusturanKullaniciFk { get; set; }
        public string GrupIsmi { get; set; }
        public string Aciklama { get; set; }
    }
}
