using SportsNetwork.Core.Models;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class PuanlamaRepository : GenericRepository<Puanlama>, IPuanlamaRepository
    {
        public PuanlamaRepository(AppDbContext context) : base(context)
        {
        }
    }
}
