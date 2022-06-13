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
    public class OzelMesajService : Service<OzelMesaj>, IOzelMesajService
    {
        private readonly IOzelMesajRepository _ozelMesajRepository;
        private readonly IMapper _mapper;

        public OzelMesajService(IGenericRepository<OzelMesaj> repository, IUnitOfWork unitOfWork, IMapper mapper, IOzelMesajRepository ozelMesajRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _ozelMesajRepository = ozelMesajRepository;
        }
    }
}
