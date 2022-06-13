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
    public class SporService : Service<Spor>, ISporService
    {
        private readonly ISporRepository _sporRepository;
        private readonly IMapper _mapper;

        public SporService(IGenericRepository<Spor> repository, IUnitOfWork unitOfWork, IMapper mapper, ISporRepository sporRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _sporRepository =  sporRepository;
        }
    }
}
