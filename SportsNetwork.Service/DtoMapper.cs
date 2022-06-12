using AutoMapper;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Service
{
    class DtoMapper:Profile
    {

        public DtoMapper()
        {
            CreateMap<UserAppDto, UserApp>().ReverseMap();


        }


    }
}
