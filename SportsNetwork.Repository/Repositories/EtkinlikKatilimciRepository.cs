using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class EtkinlikKatilimciRepository : GenericRepository<EtkinlikKatilimci>, IEtkinlikKatilimciRepository
    {
        public EtkinlikKatilimciRepository(AppDbContext context) : base(context)
        {
        }
    }
}
