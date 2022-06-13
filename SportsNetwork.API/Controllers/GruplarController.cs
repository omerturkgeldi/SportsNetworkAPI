
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Gruplar;
using SportsNetwork.Core.Models.Gruplar;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class GruplarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGrupService _service;

        public GruplarController(IMapper mapper, IGrupService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<GrupDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<GrupDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Grup>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<GrupDto>(data);
            return CreateActionResult(CustomResponseDto<GrupDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(GrupDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Grup>(dataDto));
            var newDataDto = _mapper.Map<GrupDto>(newData);
            return CreateActionResult(CustomResponseDto<GrupDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(GrupUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Grup>(dataUpdateDto));
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
