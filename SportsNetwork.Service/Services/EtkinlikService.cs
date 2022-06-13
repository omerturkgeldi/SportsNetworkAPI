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
    public class EtkinlikService : Service<Etkinlik>, IEtkinlikService
    {
        private readonly IEtkinlikRepository _etkinlikRepository;
        private readonly IMapper _mapper;

        public EtkinlikService(IGenericRepository<Etkinlik> repository, IUnitOfWork unitOfWork, IMapper mapper, IEtkinlikRepository etkinlikRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _etkinlikRepository = etkinlikRepository;
        }
    }
}
