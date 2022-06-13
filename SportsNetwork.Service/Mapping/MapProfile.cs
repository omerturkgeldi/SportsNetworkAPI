using AutoMapper;
using SportsNetwork.Core.DTOs;
using SportsNetwork.Core.DTOs.Bildirimler;
using SportsNetwork.Core.DTOs.Dersler;
using SportsNetwork.Core.DTOs.Etkinlikler;
using SportsNetwork.Core.DTOs.Gruplar;
using SportsNetwork.Core.DTOs.Iliskiler;
using SportsNetwork.Core.DTOs.Mesajlar;
using SportsNetwork.Core.DTOs.Tesisler;
using SportsNetwork.Core.Models;
using SportsNetwork.Core.Models.Bildirimler;
using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Models.Gruplar;
using SportsNetwork.Core.Models.Iliskiler;
using SportsNetwork.Core.Models.Mesajlar;
using SportsNetwork.Core.Models.Tesisler;

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

            //Dersler
            CreateMap<Ders, DersDto>().ReverseMap();
            CreateMap<Ders, DersUpdateDto>().ReverseMap();
            CreateMap<DersRezervasyon, DersRezervasyonDto>().ReverseMap();
            CreateMap<DersRezervasyon, DersRezervasyonUpdateDto>().ReverseMap();

            //Etkinlikler
            CreateMap<Etkinlik, EtkinlikDto>().ReverseMap();
            CreateMap<Etkinlik, EtkinlikUpdateDto>().ReverseMap();
            CreateMap<EtkinlikDetay, EtkinlikDetayDto>().ReverseMap();
            CreateMap<EtkinlikDetay, EtkinlikDetayUpdateDto>().ReverseMap();
            CreateMap<EtkinlikKatilimci, EtkinlikKatilimciDto>().ReverseMap();
            CreateMap<EtkinlikKatilimci, EtkinlikKatilimciUpdateDto>().ReverseMap();
            CreateMap<EtkinlikYorum, EtkinlikYorumDto>().ReverseMap();
            CreateMap<EtkinlikYorum, EtkinlikYorumUpdateDto>().ReverseMap();
            CreateMap<EtkinlikYorumBegeni, EtkinlikYorumBegeniDto>().ReverseMap();
            CreateMap<EtkinlikYorumBegeni, EtkinlikYorumBegeniUpdateDto>().ReverseMap();

            //Gruplar
            CreateMap<Grup, GrupDto>().ReverseMap();
            CreateMap<Grup, GrupUpdateDto>().ReverseMap();
            CreateMap<GrupKullanici, GrupKullaniciDto>().ReverseMap();
            CreateMap<GrupKullanici, GrupKullaniciUpdateDto>().ReverseMap();

            //İlişkiler
            CreateMap<Iliski, IliskiDto>().ReverseMap();
            CreateMap<Iliski, IliskiUpdateDto>().ReverseMap();
            CreateMap<IliskiStatu, IliskiStatuDto>().ReverseMap();
            CreateMap<IliskiStatu, IliskiStatuUpdateDto>().ReverseMap();

            //Mesajlar
            CreateMap<GrupMesaj, GrupMesajDto>().ReverseMap();
            CreateMap<GrupMesaj, GrupMesajUpdateDto>().ReverseMap();
            CreateMap<OzelMesaj, OzelMesajDto>().ReverseMap();
            CreateMap<OzelMesaj, OzelMesajUpdateDto>().ReverseMap();

            //Tesisler
            CreateMap<Tesis, TesisDto>().ReverseMap();
            CreateMap<Tesis, TesisUpdateDto>().ReverseMap();
            CreateMap<TesisRezervasyon, TesisRezervasyonDto>().ReverseMap();
            CreateMap<TesisRezervasyon, TesisRezervasyonUpdateDto>().ReverseMap();
            CreateMap<TesisYorum, TesisYorumDto>().ReverseMap();
            CreateMap<TesisYorum, TesisYorumUpdateDto>().ReverseMap();
            CreateMap<TesisYorumBegeni, TesisYorumBegeniDto>().ReverseMap();
            CreateMap<TesisYorumBegeni, TesisYorumBegeniUpdateDto>().ReverseMap();

            //Puanlama
            CreateMap<Puanlama, PuanlamaDto>().ReverseMap();
            CreateMap<Puanlama, PuanlamaUpdateDto>().ReverseMap();

            //Şehir
            CreateMap<Sehir, SehirDto>().ReverseMap();
            CreateMap<Sehir, SehirUpdateDto>().ReverseMap();

            //Sonuç
            CreateMap<Sonuc, SonucDto>().ReverseMap();
            CreateMap<Sonuc, SonucUpdateDto>().ReverseMap();

            //Spor
            CreateMap<Spor, SporDto>().ReverseMap();
            CreateMap<Spor, SporUpdateDto>().ReverseMap();


        }

    }
}
