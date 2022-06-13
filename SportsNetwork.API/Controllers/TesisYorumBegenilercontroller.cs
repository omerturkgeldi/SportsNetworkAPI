using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsNetwork.Core.Services;

namespace SportsNetwork.API.Controllers
{
    public class TesisYorumBegenilercontroller : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITesisYorumBegeniService _service;

        public TesisYorumBegenilercontroller(IMapper mapper, ITesisYorumBegeniService service)
        {
            _mapper=mapper;
            _service=service;
        }


    }
}
