using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs
{
    public class SehirDto : BaseIntIdDto
    {
        public string PlakaNo { get; set; }
        public string SehirIsmi { get; set; }
    }
}
