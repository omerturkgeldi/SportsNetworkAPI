using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Bildirimler;
using SportsNetwork.Core.Models.Bildirimler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class KullaniciBildirimlerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IKullaniciBildirimService _service;

        public KullaniciBildirimlerController(IMapper mapper, IKullaniciBildirimService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<KullaniciBildirimDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<KullaniciBildirimDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<KullaniciBildirim>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<KullaniciBildirimDto>(data);
            return CreateActionResult(CustomResponseDto<KullaniciBildirimDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(KullaniciBildirimDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<KullaniciBildirim>(dataDto));
            var newDataDto = _mapper.Map<KullaniciBildirimDto>(newData);
            return CreateActionResult(CustomResponseDto<KullaniciBildirimDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(KullaniciBildirimUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<KullaniciBildirim>(dataUpdateDto));
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
