using Microsoft.EntityFrameworkCore;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class SehirRepository : GenericRepository<Sehir>, ISehirRepository
    {
        public SehirRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<List<Sehir>> GetSehirsWithEtkinlikler()
        {
            return await _context.Sehirler.Include(x => x.Etkinlikler).ToListAsync();
        }
    }
    
}
