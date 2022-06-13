using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Mesajlar;
using SportsNetwork.Core.Models.Mesajlar;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class GrupMesajlarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGrupMesajService _service;

        public GrupMesajlarController(IMapper mapper, IGrupMesajService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<GrupMesajDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<GrupMesajDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<GrupMesaj>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<GrupMesajDto>(data);
            return CreateActionResult(CustomResponseDto<GrupMesajDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(GrupMesajDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<GrupMesaj>(dataDto));
            var newDataDto = _mapper.Map<GrupMesajDto>(newData);
            return CreateActionResult(CustomResponseDto<GrupMesajDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(GrupMesajUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<GrupMesaj>(dataUpdateDto));
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
