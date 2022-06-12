using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs.Etkinlikler
{
    public class EtkinlikUpdateDto
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string Isim { get; set; }
        public int SporFk { get; set; }
        public int SehirFk { get; set; }
        public byte Durum { get; set; }

    }
}
