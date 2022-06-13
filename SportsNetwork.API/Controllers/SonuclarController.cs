using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class SonuclarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ISonucService _service;

        public SonuclarController(IMapper mapper, ISonucService service)
        {
            _mapper=mapper;
            _service=service;
        }



        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<SonucDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<SonucDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Sonuc>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<SonucDto>(data);
            return CreateActionResult(CustomResponseDto<SonucDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SonucDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Sonuc>(dataDto));
            var newDataDto = _mapper.Map<SonucDto>(newData);
            return CreateActionResult(CustomResponseDto<SonucDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(SonucUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Sonuc>(dataUpdateDto));
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
