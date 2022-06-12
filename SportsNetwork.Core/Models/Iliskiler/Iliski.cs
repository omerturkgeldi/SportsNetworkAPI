using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Iliskiler
{
    public class Iliski : BaseEntity
    {
        public string Kullanici1Fk { get; set; }
        public string Kullanici2Fk { get; set; }
        public int IliskiStatuFk { get; set; }

        [ForeignKey("IliskiStatuFk")]
        public IliskiStatu IliskiStatu { get; set; }

        [ForeignKey("Kullanici1Fk")]
        public UserApp Kullanici1 { get; set; }

        [ForeignKey("Kullanici2Fk")]
        public UserApp Kullanici2 { get; set; }
    }
}
