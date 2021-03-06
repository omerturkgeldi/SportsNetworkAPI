using AutoMapper;
using SportsNetwork.Core.Models.Tesisler;
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
    public class TesisService : Service<Tesis>, ITesisService
    {
        private readonly ITesisRepository _tesisRepository;
        private readonly IMapper _mapper;

        public TesisService(IGenericRepository<Tesis> repository, IUnitOfWork unitOfWork, IMapper mapper, ITesisRepository tesisRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _tesisRepository = tesisRepository;
        }
    }
}
