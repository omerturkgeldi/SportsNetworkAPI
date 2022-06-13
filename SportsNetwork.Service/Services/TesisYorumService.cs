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
    public class TesisYorumService : Service<TesisYorum>, ITesisYorumService
    {
        private readonly ITesisYorumRepository _tesisYorumRepository;
        private readonly IMapper _mapper;

        public TesisYorumService(IGenericRepository<TesisYorum> repository, IUnitOfWork unitOfWork, IMapper mapper, ITesisYorumRepository tesisYorumRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _tesisYorumRepository = tesisYorumRepository;
        }
    }
}
