using SportsNetwork.Core.Models;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class SonucRepository : GenericRepository<Sonuc>, ISonucRepository
    {
        public SonucRepository(AppDbContext context) : base(context)
        {
        }
    }
}
