using SportsNetwork.Core.Models.Iliskiler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class IliskiRepository : GenericRepository<Iliski>, IIliskiRepository
    {
        public IliskiRepository(AppDbContext context) : base(context)
        {
        }
    }
}
