using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Tesisler;
using SportsNetwork.Core.Models.Tesisler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class TesislerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITesisService _service;

        public TesislerController(IMapper mapper, ITesisService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<TesisDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<TesisDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Tesis>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<TesisDto>(data);
            return CreateActionResult(CustomResponseDto<TesisDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TesisDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Tesis>(dataDto));
            var newDataDto = _mapper.Map<TesisDto>(newData);
            return CreateActionResult(CustomResponseDto<TesisDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TesisUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Tesis>(dataUpdateDto));
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
