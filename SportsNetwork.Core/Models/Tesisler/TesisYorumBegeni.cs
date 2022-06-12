using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Tesisler
{
    public class TesisYorumBegeni : BaseEntity
    {

        public int TesisYorumFk { get; set; }
        public string KullaniciFk { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp Kullanici { get; set; }

        [ForeignKey("TesisYorumFk")]
        public TesisYorum TesisYorum { get; set; }

    }
}
