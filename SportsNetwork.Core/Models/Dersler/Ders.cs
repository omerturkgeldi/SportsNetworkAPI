using SportsNetwork.Core.Models.Tesisler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Dersler
{
    public class Ders : BaseEntity
    {
        public string EgitmenFk { get; set; }
        public int SehirFk { get; set; }
        public int TesisFk { get; set; }
        public int SporFk { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Konum { get; set; }
        public string KonumIsmi { get; set; }
        public decimal SaatlikUcret { get; set; }


        [ForeignKey("EgitmenFk")]
        public UserApp Egitmen { get; set; }

        [ForeignKey("SehirFk")]
        public Sehir Sehir { get; set; }

        [ForeignKey("TesisFk")]
        public Tesis Tesis { get; set; }

        [ForeignKey("SporFk")]
        public Spor Spor { get; set; }

        public ICollection<DersRezervasyon> DersRezervasyonlar { get; set; }

    }
}
