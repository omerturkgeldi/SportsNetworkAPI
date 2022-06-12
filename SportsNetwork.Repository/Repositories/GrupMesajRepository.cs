using SportsNetwork.Core.Models.Mesajlar;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class GrupMesajRepository : GenericRepository<GrupMesaj>, IGrupMesajRepository
    {
        public GrupMesajRepository(AppDbContext context) : base(context)
        {
        }
    }
}
