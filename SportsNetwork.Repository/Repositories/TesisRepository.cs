using SportsNetwork.Core.Models.Tesisler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class TesisRepository : GenericRepository<Tesis>, ITesisRepository
    {
        public TesisRepository(AppDbContext context) : base(context)
        {
        }
    }
}
