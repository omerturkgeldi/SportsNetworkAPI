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
    public class SonucService : Service<Sonuc>, ISonucService
    {
        private readonly ISonucRepository _sonucRepository;
        private readonly IMapper _mapper;

        public SonucService(IGenericRepository<Sonuc> repository, IUnitOfWork unitOfWork, IMapper mapper, ISonucRepository sonucRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _sonucRepository = sonucRepository;
        }
    }
}
