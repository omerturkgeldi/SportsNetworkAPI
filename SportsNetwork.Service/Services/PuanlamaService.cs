using AutoMapper;
using SportsNetwork.Core.Models;
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
    public class PuanlamaService : Service<Puanlama>, IPuanlamaService
    {
        private readonly IPuanlamaRepository _puanlamaRepository;
        private readonly IMapper _mapper;

        public PuanlamaService(IGenericRepository<Puanlama> repository, IUnitOfWork unitOfWork, IMapper mapper, IPuanlamaRepository puanlamaRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _puanlamaRepository = puanlamaRepository;
        }
    }
}
