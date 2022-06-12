using AutoMapper;
using SportsNetwork.Core.Models.Bildirimler;
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
    public class BildirimService : Service<Bildirim>, IBildirimService
    {
        private readonly IBildirimRepository _bildirimRepository;
        private readonly IMapper _mapper;

        public BildirimService(IGenericRepository<Bildirim> repository, IUnitOfWork unitOfWork, IMapper mapper, IBildirimRepository bildirimRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _bildirimRepository = bildirimRepository;
        }
    }
}
