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
    public class EtkinlikYorumBegeniService : Service<EtkinlikYorumBegeni>, IEtkinlikYorumBegeniService
    {
        private readonly IEtkinlikYorumBegeniRepository _etkinlikYorumBegeniRepository;
        private readonly IMapper _mapper;
        public EtkinlikYorumBegeniService(IGenericRepository<EtkinlikYorumBegeni> repository, IUnitOfWork unitOfWork, IMapper mapper, IEtkinlikYorumBegeniRepository etkinlikYorumBegeniRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _etkinlikYorumBegeniRepository  =  etkinlikYorumBegeniRepository;
        }
    }
}
