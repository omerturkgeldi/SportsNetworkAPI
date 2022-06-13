using AutoMapper;
using SportsNetwork.Core.Models.Etkinlikler;
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
    public class EtkinlikYorumService : Service<EtkinlikYorum>, IEtkinlikYorumService
    {
        private readonly IEtkinlikYorumRepository _etkinlikYorumRepository;
        private readonly IMapper _mapper;

        public EtkinlikYorumService(IGenericRepository<EtkinlikYorum> repository, IUnitOfWork unitOfWork, IMapper mapper, IEtkinlikYorumRepository etkinlikYorumRepository ) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _etkinlikYorumRepository = etkinlikYorumRepository; 
        }
    }
}
