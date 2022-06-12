using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models
{
    public class Puanlama: BaseEntity
    {
        public string Kullanici1Fk { get; set; }
        public string Kullanici2Fk { get; set; }
        public byte Puan { get; set; }
        public string Yorum { get; set; }

        [ForeignKey("Kullanici1Fk")]
        public UserApp Kullanici1 { get; set; }

        [ForeignKey("Kullanici2Fk")]
        public UserApp Kullanici2 { get; set; }

    }
}
