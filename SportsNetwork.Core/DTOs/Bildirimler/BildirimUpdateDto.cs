using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Bildirimler
{
    public class BildirimUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string BildirimBasligi { get; set; }
        public string BildirimTip { get; set; }
        public string BildirimIcerik { get; set; }

    }
}
