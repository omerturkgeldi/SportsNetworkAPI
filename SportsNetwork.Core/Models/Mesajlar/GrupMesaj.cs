using SportsNetwork.Core.Models.Gruplar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Mesajlar
{
    public class GrupMesaj : BaseEntity
    {
        public int GrupFk { get; set; }
        public string KullaniciFk { get; set; }
        public string Mesaj { get; set; }


        [ForeignKey("GrupFk")]
        public Grup Grup { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp Kullanici { get; set; }


    }
}
