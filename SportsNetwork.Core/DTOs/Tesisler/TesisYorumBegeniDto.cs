using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Tesisler
{
    public class TesisYorumBegeniDto : BaseIntIdDto
    {
        public int TesisYorumFk { get; set; }
        public string KullaniciFk { get; set; }
    }
}
