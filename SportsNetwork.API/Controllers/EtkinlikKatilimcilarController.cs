using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Etkinlikler;
using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class EtkinlikKatilimcilarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IEtkinlikKatilimciService _service;

        public EtkinlikKatilimcilarController(IMapper mapper, IEtkinlikKatilimciService service)
        {
            _mapper=mapper;
            _service=service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<EtkinlikKatilimciDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<EtkinlikKatilimciDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<EtkinlikKatilimci>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<EtkinlikKatilimciDto>(data);
            return CreateActionResult(CustomResponseDto<EtkinlikKatilimciDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(EtkinlikKatilimciDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<EtkinlikKatilimci>(dataDto));
            var newDataDto = _mapper.Map<EtkinlikKatilimciDto>(newData);
            return CreateActionResult(CustomResponseDto<EtkinlikKatilimciDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(EtkinlikKatilimciUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<EtkinlikKatilimci>(dataUpdateDto));
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
