using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class DersRepository : GenericRepository<Ders>, IDersRepository
    {
        public DersRepository(AppDbContext context) : base(context)
        {
        }
    }
}
