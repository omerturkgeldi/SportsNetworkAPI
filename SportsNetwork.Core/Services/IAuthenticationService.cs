using SportsNetwork.Core.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Services
{
    /**************************************************************** 
    * Date: 20.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ < turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);
        Response<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto);

    }
}
