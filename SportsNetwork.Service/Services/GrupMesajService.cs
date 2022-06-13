using AutoMapper;
using SportsNetwork.Core.Models.Mesajlar;
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
    public class GrupMesajService : Service<GrupMesaj>, IGrupMesajService
    {
        private readonly IGrupMesajRepository _grupMesajRepository;
        private readonly IMapper _mapper;

        public GrupMesajService(IGenericRepository<GrupMesaj> repository, IUnitOfWork unitOfWork, IMapper mapper, IGrupMesajRepository grupMesajRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _grupMesajRepository = grupMesajRepository;
        }
    }
}
