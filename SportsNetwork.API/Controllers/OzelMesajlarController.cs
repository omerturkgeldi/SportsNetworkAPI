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
    public class OzelMesajlarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IOzelMesajService _service;

        public OzelMesajlarController(IMapper mapper, IOzelMesajService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<OzelMesajDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<OzelMesajDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<OzelMesaj>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<OzelMesajDto>(data);
            return CreateActionResult(CustomResponseDto<OzelMesajDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(OzelMesajDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<OzelMesaj>(dataDto));
            var newDataDto = _mapper.Map<OzelMesajDto>(newData);
            return CreateActionResult(CustomResponseDto<OzelMesajDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(OzelMesajUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<OzelMesaj>(dataUpdateDto));
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
