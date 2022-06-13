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
    public class EtkinlikYorumBegenilerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IEtkinlikYorumBegeniService _service;

        public EtkinlikYorumBegenilerController(IMapper mapper, IEtkinlikYorumBegeniService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<EtkinlikYorumBegeniDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<EtkinlikYorumBegeniDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<EtkinlikYorumBegeni>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<EtkinlikYorumBegeniDto>(data);
            return CreateActionResult(CustomResponseDto<EtkinlikYorumBegeniDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(EtkinlikYorumBegeniDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<EtkinlikYorumBegeni>(dataDto));
            var newDataDto = _mapper.Map<EtkinlikYorumBegeniDto>(newData);
            return CreateActionResult(CustomResponseDto<EtkinlikYorumBegeniDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(EtkinlikYorumBegeniUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<EtkinlikYorumBegeni>(dataUpdateDto));
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
