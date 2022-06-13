using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class SporlarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ISporService _service;

        public SporlarController(IMapper mapper, ISporService service)
        {
            _mapper=mapper;
            _service=service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<SporDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<SporDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Spor>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<SporDto>(data);
            return CreateActionResult(CustomResponseDto<SporDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SporDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Spor>(dataDto));
            var newDataDto = _mapper.Map<SporDto>(newData);
            return CreateActionResult(CustomResponseDto<SporDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(SporUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Spor>(dataUpdateDto));
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
