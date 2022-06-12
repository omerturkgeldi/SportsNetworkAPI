using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Etkinlikler
{
    public class EtkinlikYorumBegeni: BaseEntity
    {
        public int EtkinlikFk { get; set; }
        public string KullaniciFk { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp Kullanici { get; set; }

        [ForeignKey("EtkinlikFk")]
        public Etkinlik Etkinlik { get; set; }



    }
}
