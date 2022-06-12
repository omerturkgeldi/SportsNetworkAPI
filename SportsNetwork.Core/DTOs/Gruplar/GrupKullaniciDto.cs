using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Gruplar
{
    public class GrupKullaniciDto : BaseIntIdDto
    {
        public int GrupFk { get; set; }
        public string KullaniciFk { get; set; }
        public bool AdminMi { get; set; }
    }
}
