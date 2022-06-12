using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Iliskiler
{
    public class IliskiDto : BaseIntIdDto
    {
        public string Kullanici1Fk { get; set; }
        public string Kullanici2Fk { get; set; }
        public int IliskiStatuFk { get; set; }
    }
}
