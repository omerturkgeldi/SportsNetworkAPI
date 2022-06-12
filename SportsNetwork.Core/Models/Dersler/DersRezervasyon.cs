using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Dersler
{
    public class DersRezervasyon : BaseEntity
    {
        public int DersFk { get; set; }
        public string KursiyerKullaniciFk { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool Onay { get; set; }


        [ForeignKey("DersFk")]
        public Ders Ders { get; set; }

        [ForeignKey("KursiyerKullaniciFk")]
        public UserApp KursiyerKullanici { get; set; }



    }
}
