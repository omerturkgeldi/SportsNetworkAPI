using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Bildirimler
{
    public class Bildirim: BaseEntity
    {
        public string BildirimBasligi { get; set; }
        public string BildirimTip { get; set; }
        public string BildirimIcerik { get; set; }
        public string EkleyenKullaniciFk { get; set; }

        [ForeignKey("EkleyenKullaniciFk")]
        public UserApp EkleyenKullanici { get; set; }

        public ICollection<KullaniciBildirim> KullaniciBildirimler { get; set; }

    }
}
