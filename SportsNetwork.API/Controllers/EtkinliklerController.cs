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
    public class EtkinliklerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IEtkinlikService _service;

        public EtkinliklerController(IMapper mapper, IEtkinlikService service)
        {
            _mapper=mapper;
            _service=service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<EtkinlikDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<EtkinlikDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Etkinlik>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<EtkinlikDto>(data);
            return CreateActionResult(CustomResponseDto<EtkinlikDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(EtkinlikDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Etkinlik>(dataDto));
            var newDataDto = _mapper.Map<EtkinlikDto>(newData);
            return CreateActionResult(CustomResponseDto<EtkinlikDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(EtkinlikUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Etkinlik>(dataUpdateDto));
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
