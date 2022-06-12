using SportsNetwork.Core.Models.Etkinlikler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models
{
    public class Sonuc: BaseEntity
    {
        public string KullaniciFk { get; set; }
        public int EtkinlikFk { get; set; }
        public int SporFk { get; set; }

        [Column(TypeName = "jsonb")]
        public string SonucJson { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp Kullanici { get; set; }

        [ForeignKey("EtkinlikFk")]
        public Etkinlik Etkinlik { get; set; }

        [ForeignKey("SporFk")]
        public Spor Spor { get; set; }



    }
}
