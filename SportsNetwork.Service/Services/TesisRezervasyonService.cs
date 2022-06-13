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
    public class TesisRezervasyonService : Service<TesisRezervasyon>, ITesisRezervasyonService
    {
        private readonly ITesisRezervasyonRepository _tesisRezervasyonRepository;
        private readonly IMapper _mapper;

        public TesisRezervasyonService(IGenericRepository<TesisRezervasyon> repository, IUnitOfWork unitOfWork, IMapper mapper, ITesisRezervasyonRepository tesisRezervasyonRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _tesisRezervasyonRepository = tesisRezervasyonRepository;
        }
    }
}
