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
    public class TesisRezervasyonlarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITesisRezervasyonService _service;

        public TesisRezervasyonlarController(IMapper mapper, ITesisRezervasyonService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<TesisRezervasyonDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<TesisRezervasyonDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<TesisRezervasyon>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<TesisRezervasyonDto>(data);
            return CreateActionResult(CustomResponseDto<TesisRezervasyonDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TesisRezervasyonDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<TesisRezervasyon>(dataDto));
            var newDataDto = _mapper.Map<TesisRezervasyonDto>(newData);
            return CreateActionResult(CustomResponseDto<TesisRezervasyonDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TesisRezervasyonUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<TesisRezervasyon>(dataUpdateDto));
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
