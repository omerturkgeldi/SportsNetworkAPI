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
    public class EtkinlikKatilimciService : Service<EtkinlikKatilimci>, IEtkinlikKatilimciService
    {
        private readonly IEtkinlikKatilimciRepository _etkinlikKatilimciRepository;
        private readonly IMapper _mapper;

        public EtkinlikKatilimciService(IGenericRepository<EtkinlikKatilimci> repository, IUnitOfWork unitOfWork, IMapper mapper, IEtkinlikKatilimciRepository etkinlikKatilimciRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _etkinlikKatilimciRepository = etkinlikKatilimciRepository;
        }
    }
}
