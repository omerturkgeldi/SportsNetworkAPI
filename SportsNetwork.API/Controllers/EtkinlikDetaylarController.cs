using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Etkinlikler;
using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class EtkinlikDetaylarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IEtkinlikDetayService _service;

        public EtkinlikDetaylarController(IMapper mapper, IEtkinlikDetayService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<EtkinlikDetayDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<EtkinlikDetayDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<EtkinlikDetay>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<EtkinlikDetayDto>(data);
            return CreateActionResult(CustomResponseDto<EtkinlikDetayDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(EtkinlikDetayDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<EtkinlikDetay>(dataDto));
            var newDataDto = _mapper.Map<EtkinlikDetayDto>(newData);
            return CreateActionResult(CustomResponseDto<EtkinlikDetayDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(EtkinlikDetayUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<EtkinlikDetay>(dataUpdateDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(data);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }


    }
}
