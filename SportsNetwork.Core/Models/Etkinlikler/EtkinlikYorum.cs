using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Etkinlikler
{
    public class EtkinlikYorum : BaseEntity
    {
        public int EtkinlikFk { get; set; }
        public string KullaniciFk { get; set; }
        public string Yorum { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp Kullanici { get; set; }

        [ForeignKey("EtkinlikFk")]
        public Etkinlik Etkinlik { get; set; }

        public ICollection<EtkinlikYorumBegeni> EtkinlikYorumBegeniler { get; set; }

    }
}
