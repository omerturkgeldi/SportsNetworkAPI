using SportsNetwork.Core.Models.Bildirimler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class KullaniciBildirimRepository : GenericRepository<KullaniciBildirim>, IKullaniciBildirimRepository
    {
        public KullaniciBildirimRepository(AppDbContext context) : base(context)
        {
        }
    }
}
