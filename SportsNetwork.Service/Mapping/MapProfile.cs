using AutoMapper;
using SportsNetwork.Core.DTOs.Bildirimler;
using SportsNetwork.Core.Models.Bildirimler;

namespace SportsNetwork.Service.Mapping
{   
    /**************************************************************** 
    * Date: 21.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ < turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/
    public class MapProfile: Profile
    {

        public MapProfile()
        {
            // Bildirimler
            CreateMap<Bildirim, BildirimDto>().ReverseMap();
            CreateMap<Bildirim, BildirimUpdateDto>().ReverseMap();
            CreateMap<KullaniciBildirim, KullaniciBildirimDto>().ReverseMap();
            CreateMap<KullaniciBildirim, KullaniciBildirimUpdateDto>().ReverseMap();


        }


    }
}
