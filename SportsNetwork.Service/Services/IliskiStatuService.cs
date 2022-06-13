using AutoMapper;
using SportsNetwork.Core.Models.Iliskiler;
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
    public class IliskiStatuService : Service<IliskiStatu>, IIliskiStatuService
    {
        private readonly IIliskiStatuRepository _iliskiStatuRepository;
        private readonly IMapper _mapper;

        public IliskiStatuService(IGenericRepository<IliskiStatu> repository, IUnitOfWork unitOfWork, IMapper mapper, IIliskiStatuRepository iliskiStatuRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _iliskiStatuRepository = iliskiStatuRepository;
        }
    }
}
