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
    public class TesisYorumBegeniService : Service<TesisYorumBegeni>, ITesisYorumBegeniService
    {
        private readonly ITesisYorumBegeniRepository _tesisYorumBegeniRepository;
        private readonly IMapper _mapper;

        public TesisYorumBegeniService(IGenericRepository<TesisYorumBegeni> repository, IUnitOfWork unitOfWork, IMapper mapper, ITesisYorumBegeniRepository tesisYorumBegeniRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _tesisYorumBegeniRepository = tesisYorumBegeniRepository;
        }
    }
}
