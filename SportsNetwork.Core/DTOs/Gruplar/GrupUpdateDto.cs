using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Gruplar
{
    public class GrupUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string GrupIsmi { get; set; }
        public string Aciklama { get; set; }
    }
}
