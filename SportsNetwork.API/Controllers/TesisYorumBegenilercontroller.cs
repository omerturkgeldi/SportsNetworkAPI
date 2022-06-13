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
    public class TesisYorumBegenilercontroller : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITesisYorumBegeniService _service;

        public TesisYorumBegenilercontroller(IMapper mapper, ITesisYorumBegeniService service)
        {
            _mapper=mapper;
            _service=service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<TesisYorumBegeniDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<TesisYorumBegeniDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<TesisYorumBegeni>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<TesisYorumBegeniDto>(data);
            return CreateActionResult(CustomResponseDto<TesisYorumBegeniDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TesisYorumBegeniDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<TesisYorumBegeni>(dataDto));
            var newDataDto = _mapper.Map<TesisYorumBegeniDto>(newData);
            return CreateActionResult(CustomResponseDto<TesisYorumBegeniDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TesisYorumBegeniUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<TesisYorumBegeni>(dataUpdateDto));
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
