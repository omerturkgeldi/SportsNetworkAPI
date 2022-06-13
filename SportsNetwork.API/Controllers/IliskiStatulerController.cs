using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Iliskiler;
using SportsNetwork.Core.Models.Iliskiler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class IliskiStatulerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IIliskiStatuService _service;

        public IliskiStatulerController(IMapper mapper, IIliskiStatuService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<IliskiStatuDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<IliskiStatuDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<IliskiStatu>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<IliskiStatuDto>(data);
            return CreateActionResult(CustomResponseDto<IliskiStatuDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(IliskiStatuDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<IliskiStatu>(dataDto));
            var newDataDto = _mapper.Map<IliskiStatuDto>(newData);
            return CreateActionResult(CustomResponseDto<IliskiStatuDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(IliskiStatuUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<IliskiStatu>(dataUpdateDto));
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
