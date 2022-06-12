using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Bildirimler
{
    public class KullaniciBildirim : BaseEntity
    {
        public int BildirimFk { get; set; }
        public string KullaniciFk { get; set; }
        public bool OkunduMu { get; set; }
        public DateTime IletilmeTarihi { get; set; }
        public DateTime OkunmaTarihi { get; set; }


        [ForeignKey("BildirimFk")]
        public Bildirim Bildirim { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp Kullanici { get; set; }

    }
}
