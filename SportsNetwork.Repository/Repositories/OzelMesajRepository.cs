using SportsNetwork.Core.Models.Mesajlar;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class OzelMesajRepository : GenericRepository<OzelMesaj>, IOzelMesajRepository
    {
        public OzelMesajRepository(AppDbContext context) : base(context)
        {
        }
    }
}
