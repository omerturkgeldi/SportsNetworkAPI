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
    public class TesisYorumlarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITesisYorumService _service;

        public TesisYorumlarController(IMapper mapper, ITesisYorumService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<TesisYorumDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<TesisYorumDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<TesisYorum>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<TesisYorumDto>(data);
            return CreateActionResult(CustomResponseDto<TesisYorumDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TesisYorumDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<TesisYorum>(dataDto));
            var newDataDto = _mapper.Map<TesisYorumDto>(newData);
            return CreateActionResult(CustomResponseDto<TesisYorumDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TesisYorumUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<TesisYorum>(dataUpdateDto));
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
