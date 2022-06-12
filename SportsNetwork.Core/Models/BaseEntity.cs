using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models
{
    /**************************************************************** 
    * Date: 20.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ < turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime OlusturulanTarih { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public bool SilindiMi { get; set; }
    }
}
