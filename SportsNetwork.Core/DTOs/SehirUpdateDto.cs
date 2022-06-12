using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs
{
    public class SehirUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string PlakaNo { get; set; }
        public string SehirIsmi { get; set; }
    }
}
