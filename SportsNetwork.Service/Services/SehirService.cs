using AutoMapper;
using SportsNetwork.Core.DTOs;
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
    public class SehirService : Service<Sehir>, ISehirService
    {
        private readonly ISehirRepository _sehirRepository;
        private readonly IMapper _mapper;

        public SehirService(IGenericRepository<Sehir> repository, IUnitOfWork unitOfWork, IMapper mapper, ISehirRepository sehirRepository) : base(repository, unitOfWork, mapper)
        {
            _sehirRepository=sehirRepository;
            _mapper=mapper;
        }

        //public async Task<CustomResponseDto<List<SehirWithGonderiDto>>> GetSehirsWithGonderiler()
        //{
        //    var sehirler = await _sehirRepository.GetSehirsWithGonderiler();
        //    var sehirlerDto = _mapper.Map<List<SehirWithGonderiDto>>(sehirler);
        //    return CustomResponseDto<List<SehirWithGonderiDto>>.Success(200, sehirlerDto);
        //}


    }
}
