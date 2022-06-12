using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Tesisler
{
    public class TesisRezervasyon : BaseEntity
    {
        public int TesisFk { get; set; }
        public string RezerveEdenKullaniciFk { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool Onay { get; set; }


        [ForeignKey("RezerveEdenKullaniciFk")]
        public UserApp RezerveEdenKullanici { get; set; }

        [ForeignKey("TesisFk")]
        public Tesis Tesis { get; set; }
    }
}
