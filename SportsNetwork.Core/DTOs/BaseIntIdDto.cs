using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs
{
    public abstract class BaseIntIdDto
    {
        public int Id { get; set; }
        public DateTime OlusturulanTarih { get; set; }

    }
}
