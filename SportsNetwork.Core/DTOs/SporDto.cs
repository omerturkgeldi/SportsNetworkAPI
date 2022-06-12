using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs
{
    public class SporDto : BaseIntIdDto
    {
        public string Isim { get; set; }
        public string Icon { get; set; }

    }
}
