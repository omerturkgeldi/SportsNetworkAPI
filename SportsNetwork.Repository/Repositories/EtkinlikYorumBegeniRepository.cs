using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class EtkinlikYorumBegeniRepository : GenericRepository<EtkinlikYorumBegeni>, IEtkinlikYorumBegeniRepository
    {
        public EtkinlikYorumBegeniRepository(AppDbContext context) : base(context)
        {
        }
    }
}
