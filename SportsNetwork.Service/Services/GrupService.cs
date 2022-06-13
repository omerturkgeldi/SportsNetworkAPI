using AutoMapper;
using SportsNetwork.Core.Models.Gruplar;
using SportsNetwork.Core.Repositories;
using SportsNetwork.Core.Services;
using SportsNetwork.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Service.Services
{
    public class GrupService : Service<Grup>, IGrupService
    {
        private readonly IGrupRepository _grupRepository;
        private readonly IMapper _mapper;

        public GrupService(IGenericRepository<Grup> repository, IUnitOfWork unitOfWork, IMapper mapper, IGrupRepository grupRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _grupRepository = grupRepository;
        }
    }
}
