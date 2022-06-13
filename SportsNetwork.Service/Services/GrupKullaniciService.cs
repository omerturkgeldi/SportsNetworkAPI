using AutoMapper;
using SportsNetwork.Core.Models.Gruplar;
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
    public class GrupKullaniciService : Service<GrupKullanici>, IGrupKullaniciService
    {
        private readonly IGrupKullaniciRepository _grupKullaniciRepository;
        private readonly IMapper _mapper;

        public GrupKullaniciService(IGenericRepository<GrupKullanici> repository, IUnitOfWork unitOfWork, IMapper mapper, IGrupKullaniciRepository grupKullaniciRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _grupKullaniciRepository = grupKullaniciRepository;
        }
    }
}
