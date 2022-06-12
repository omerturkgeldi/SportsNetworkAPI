using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Tesisler
{
    public class TesisYorum : BaseEntity
    {
        public int TesisFk { get; set; }
        public string KullaniciFk { get; set; }
        public string Yorum { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp Kullanici { get; set; }

        [ForeignKey("TesisFk")]
        public Tesis Tesis { get; set; }

        public ICollection<TesisYorumBegeni> TesisYorumBegeniler { get; set; }

    }
}
