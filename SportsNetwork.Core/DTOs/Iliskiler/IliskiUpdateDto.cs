using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Iliskiler
{
    public class IliskiUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string Kullanici1Fk { get; set; }
        public string Kullanici2Fk { get; set; }
        public int IliskiStatuFk { get; set; }
    }
}
