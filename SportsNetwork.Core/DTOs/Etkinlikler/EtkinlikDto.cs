using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Etkinlikler
{
    public class EtkinlikDto : BaseIntIdDto
    {
        public string OlusturanKullaniciFk { get; set; }
        public string Isim { get; set; }
        public int SporFk { get; set; }
        public int SehirFk { get; set; }
        public byte Durum { get; set; }
    }
}
