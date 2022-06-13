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
    public class EtkinlikYorumlarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IEtkinlikYorumService _service;

        public EtkinlikYorumlarController(IMapper mapper, IEtkinlikYorumService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<EtkinlikYorumDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<EtkinlikYorumDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<EtkinlikYorum>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<EtkinlikYorumDto>(data);
            return CreateActionResult(CustomResponseDto<EtkinlikYorumDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(EtkinlikYorumDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<EtkinlikYorum>(dataDto));
            var newDataDto = _mapper.Map<EtkinlikYorumDto>(newData);
            return CreateActionResult(CustomResponseDto<EtkinlikYorumDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(EtkinlikYorumUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<EtkinlikYorum>(dataUpdateDto));
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
