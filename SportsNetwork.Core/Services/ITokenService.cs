using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.Models;
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
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);

    }
}
