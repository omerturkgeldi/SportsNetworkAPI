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
    public class IliskiService: Service<Iliski>, IIliskiService
    {
        private readonly IIliskiRepository _iliskiRepository;
        private readonly IMapper _mapper;

        public IliskiService(IGenericRepository<Iliski> repository, IUnitOfWork unitOfWork, IMapper mapper, IIliskiRepository iliskiRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _iliskiRepository = iliskiRepository;
        }
    }
}
