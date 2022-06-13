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
    public class DersService : Service<Ders>, IDersService
    {
        private readonly IDersRepository _dersRepository;
        private readonly IMapper _mapper;

        public DersService(IGenericRepository<Ders> repository, IUnitOfWork unitOfWork, IMapper mapper, IDersRepository dersRepository) : base(repository, unitOfWork, mapper)
        { 
            _mapper = mapper;
            _dersRepository = dersRepository;
        }
    }
}
