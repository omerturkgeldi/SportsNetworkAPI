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
    public class KullaniciBildirimService : Service<KullaniciBildirim>, IKullaniciBildirimService
    {
        private readonly IKullaniciBildirimRepository _kullaniciBildirimRepository;
        private readonly IMapper _mapper;

        public KullaniciBildirimService(IGenericRepository<KullaniciBildirim> repository, IUnitOfWork unitOfWork, IMapper mapper, IKullaniciBildirimRepository kullaniciBildirimRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _kullaniciBildirimRepository = kullaniciBildirimRepository;
        }
    }
}
