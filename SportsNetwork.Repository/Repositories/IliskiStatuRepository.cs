using SportsNetwork.Core.Models.Iliskiler;
using SportsNetwork.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Repository.Repositories
{
    public class IliskiStatuRepository : GenericRepository<IliskiStatu>, IIliskiStatuRepository
    {
        public IliskiStatuRepository(AppDbContext context) : base(context)
        {
        }
    }
}
