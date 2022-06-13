using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Iliskiler;
using SportsNetwork.Core.Models.Iliskiler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class IliskilerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IIliskiService _service;

        public IliskilerController(IMapper mapper, IIliskiService service)
        {
            _mapper=mapper;
            _service=service;
        }



        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<IliskiDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<IliskiDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Iliski>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<IliskiDto>(data);
            return CreateActionResult(CustomResponseDto<IliskiDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(IliskiDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Iliski>(dataDto));
            var newDataDto = _mapper.Map<IliskiDto>(newData);
            return CreateActionResult(CustomResponseDto<IliskiDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(IliskiUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Iliski>(dataUpdateDto));
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
