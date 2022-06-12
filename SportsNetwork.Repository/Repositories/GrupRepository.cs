using SportsNetwork.Core.Models.Gruplar;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class GrupRepository : GenericRepository<Grup>, IGrupRepository
    {
        public GrupRepository(AppDbContext context) : base(context)
        {
        }
    }
}
