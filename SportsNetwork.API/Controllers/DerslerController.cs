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
    public class DerslerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IDersService _service;

        public DerslerController(IMapper mapper, IDersService service)
        {
            _mapper=mapper;
            _service=service;
        }



        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<DersDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<DersDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Ders>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<DersDto>(data);
            return CreateActionResult(CustomResponseDto<DersDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(DersDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Ders>(dataDto));
            var newDataDto = _mapper.Map<DersDto>(newData);
            return CreateActionResult(CustomResponseDto<DersDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(DersUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Ders>(dataUpdateDto));
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
