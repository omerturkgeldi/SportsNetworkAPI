using AutoMapper;
using SportsNetwork.Core.Models.Dersler;
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
    public class DersRezervasyonService : Service<DersRezervasyon>, IDersRezervasyonService
    {
        private readonly IDersRezervasyonRepository _dersRezervasyonRepository;
        private readonly IMapper _mapper;

        public DersRezervasyonService(IGenericRepository<DersRezervasyon> repository, IUnitOfWork unitOfWork, IMapper mapper, IDersRezervasyonRepository dersRezervasyonRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _dersRezervasyonRepository = dersRezervasyonRepository;
        }
    }
}
