using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Gruplar;
using SportsNetwork.Core.Models.Gruplar;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class GrupKullanicilarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IGrupKullaniciService _service;

        public GrupKullanicilarController(IMapper mapper, IGrupKullaniciService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<GrupKullaniciDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<GrupKullaniciDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<GrupKullanici>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<GrupKullaniciDto>(data);
            return CreateActionResult(CustomResponseDto<GrupKullaniciDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(GrupKullaniciDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<GrupKullanici>(dataDto));
            var newDataDto = _mapper.Map<GrupKullaniciDto>(newData);
            return CreateActionResult(CustomResponseDto<GrupKullaniciDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(GrupKullaniciUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<GrupKullanici>(dataUpdateDto));
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
