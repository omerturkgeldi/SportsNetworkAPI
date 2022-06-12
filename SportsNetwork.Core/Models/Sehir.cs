using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Models.Tesisler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models
{
    /**************************************************************** 
    * Date: 18.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ <turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/

    public class Sehir: BaseEntity
    {
        public string PlakaNo { get; set; }
        public string SehirIsmi { get; set; }

        public ICollection<Ders> Dersler { get; set; }
        public ICollection<Tesis> Tesisler { get; set; }
        public ICollection<Etkinlik> Etkinlikler { get; set; }

    }
}
