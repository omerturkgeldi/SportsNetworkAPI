using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Mesajlar
{
    public class OzelMesajDto : BaseIntIdDto
    {
        public string Kullanici1Fk { get; set; }
        public string Kullanici2Fk { get; set; }
        public string Mesaj { get; set; }
    }
}
