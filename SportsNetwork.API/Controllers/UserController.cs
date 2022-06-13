using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Exceptions;
using SportsNetwork.API.Controllers;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsNetwork.API.Controllers
{
    public class UserController : CustomBaseController
    {

        private readonly IUserService _userService;
        private readonly IService<UserApp> _service;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IService<UserApp> service, IMapper mapper )
        {
            _userService = userService;
            _service = service;
            _mapper = mapper;
        }


        // api/user
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            //throw new CustomException("Veritabanı ile ilgili bir hata meydana geldi");
            return ActionResultInstance(await _userService.CreateUserAsync(createUserDto));
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return ActionResultInstance(await _userService.GetUserByNameAsync(HttpContext.User.Identity.Name));
        }


        [HttpPut]
        public async Task<IActionResult> Update(UserAppDto userAppDto)
        {
            await _service.UpdateAsync(_mapper.Map<UserApp>(userAppDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }


    }
}
