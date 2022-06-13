﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.API.Filters;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Bildirimler;
using SportsNetwork.Core.Models.Bildirimler;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class BildirimlerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IBildirimService _service;

        public BildirimlerController(IMapper mapper, IBildirimService service)
        {
            _mapper=mapper;
            _service=service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var datas = await _service.GetAllAsync();
            var datasList = _mapper.Map<List<BildirimDto>>(datas.ToList());
            return CreateActionResult(CustomResponseDto<List<BildirimDto>>.Success(200, datasList));
        }

        [ServiceFilter(typeof(NotFoundFilter<Bildirim>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetByIdAsync(id);
            var dataDto = _mapper.Map<BildirimDto>(data);
            return CreateActionResult(CustomResponseDto<BildirimDto>.Success(200, dataDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(BildirimDto dataDto)
        {
            var newData = await _service.AddAsync(_mapper.Map<Bildirim>(dataDto));
            var newDataDto = _mapper.Map<BildirimDto>(newData);
            return CreateActionResult(CustomResponseDto<BildirimDto>.Success(201, newDataDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(BildirimUpdateDto dataUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Bildirim>(dataUpdateDto));
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
