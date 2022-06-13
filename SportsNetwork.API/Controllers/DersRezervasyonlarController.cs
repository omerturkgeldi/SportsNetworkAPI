using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Dersler;
using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class DersRezervasyonlarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IDersRezervasyonService _service;

        public DersRezervasyonlarController(IMapper mapper, IDersRezervasyonService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<DersRezervasyonDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<DersRezervasyonDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<DersRezervasyon>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<DersRezervasyonDto>(data);
            return CreateActionResult(CustomResponseDto<DersRezervasyonDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(DersRezervasyonDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<DersRezervasyon>(dataDto));
            var newDataDto = _mapper.Map<DersRezervasyonDto>(newData);
            return CreateActionResult(CustomResponseDto<DersRezervasyonDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(DersRezervasyonUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<DersRezervasyon>(dataUpdateDto));
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
