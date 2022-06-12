using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models.Iliskiler
{
    public class IliskiStatu : BaseEntity
    {
        public string Tip { get; set; }
        public ICollection<Iliski> Iliskiler { get; set; }

    }
}
