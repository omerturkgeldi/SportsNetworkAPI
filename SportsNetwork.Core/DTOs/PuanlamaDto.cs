using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs
{
    public class PuanlamaDto : BaseIntIdDto
    {
        public string Kullanici1Fk { get; set; }
        public string Kullanici2Fk { get; set; }
        public byte Puan { get; set; }
        public string Yorum { get; set; }
    }
}
