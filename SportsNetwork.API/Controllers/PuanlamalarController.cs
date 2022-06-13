using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class PuanlamalarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPuanlamaService _service;

        public PuanlamalarController(IMapper mapper, IPuanlamaService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<PuanlamaDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<PuanlamaDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Puanlama>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<PuanlamaDto>(data);
            return CreateActionResult(CustomResponseDto<PuanlamaDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PuanlamaDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Puanlama>(dataDto));
            var newDataDto = _mapper.Map<PuanlamaDto>(newData);
            return CreateActionResult(CustomResponseDto<PuanlamaDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(PuanlamaUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Puanlama>(dataUpdateDto));
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
