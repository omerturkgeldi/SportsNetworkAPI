using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class EtkinlikDetayConfiguration : GenericRepository<EtkinlikDetay>, IEtkinlikDetayRepository
    {
        public EtkinlikDetayConfiguration(AppDbContext context) : base(context)
        {
        }
    }
}
