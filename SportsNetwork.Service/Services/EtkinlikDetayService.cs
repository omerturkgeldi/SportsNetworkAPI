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
    public class EtkinlikDetayService: Service<EtkinlikDetay>, IEtkinlikDetayService
    {
        private readonly IEtkinlikDetayRepository _etkinlikDetayRepository;
        private readonly IMapper _mapper;

        public EtkinlikDetayService(IGenericRepository<EtkinlikDetay> repository, IUnitOfWork unitOfWork, IMapper mapper, IEtkinlikDetayRepository etkinlikDetayRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _etkinlikDetayRepository = etkinlikDetayRepository;
        }
    }
}
