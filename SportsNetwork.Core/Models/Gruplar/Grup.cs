using SportsNetwork.Core.Models.Mesajlar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Gruplar
{
    public class Grup : BaseEntity
    {
        public string OlusturanKullaniciFk { get; set; }
        public string GrupIsmi { get; set; }
        public string Aciklama { get; set; }

        [ForeignKey("KullaniciFk")]
        public UserApp OlusturanKullanici { get; set; }
        public ICollection<GrupKullanici> GrupKullanicilar { get; set; }
        public ICollection<GrupMesaj> GrupMesajlar { get; set; }

    }
}
