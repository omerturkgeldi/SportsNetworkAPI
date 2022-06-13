using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class SehirlerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ISehirService _service;

        public SehirlerController(IMapper mapper, ISehirService service)
        {
            _mapper=mapper;
            _service=service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<SehirDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<SehirDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Sehir>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<SehirDto>(data);
            return CreateActionResult(CustomResponseDto<SehirDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SehirDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Sehir>(dataDto));
            var newDataDto = _mapper.Map<SehirDto>(newData);
            return CreateActionResult(CustomResponseDto<SehirDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(SehirUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Sehir>(dataUpdateDto));
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
