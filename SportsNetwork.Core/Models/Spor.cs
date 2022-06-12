using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Models.Etkinlikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models
{
    public class Spor: BaseEntity
    {
        public string Isim { get; set; }
        public string Icon { get; set; }


        public ICollection<Ders> Dersler { get; set; }
        public ICollection<Etkinlik> Etkinlikler { get; set; }
        public ICollection<Sonuc> Sonuclar { get; set; }

    }
}
