using AutoMapper;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Repositories;
using SportsNetwork.Core.Services;
using SportsNetwork.Core.UnitOfWorks;
using SportsNetwork.Service;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary.Common;

namespace SportsNetwork.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserApp> _userManager;

        public UserService(UserManager<UserApp> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new UserApp { Email = createUserDto.Email, UserName = createUserDto.UserName };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();
                StaticLogger.LogWarn(this.GetType(), createUserDto.UserName + " adlı kullanıcı oluşturulamadı! Hata sebebi --> " + errors.First().ToString());

                return Response<UserAppDto>.Fail(new ErrorDto(errors, true), 400);
            }
            StaticLogger.LogInfo(this.GetType(), createUserDto.UserName + " adlı kullanıcı oluşturuldu!");
            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user), 200);
        }

        public async Task<Response<UserAppDto>> GetUserByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return Response<UserAppDto>.Fail("UserName not found", 404, true);
            }

            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user), 200);
        }
    }
}
