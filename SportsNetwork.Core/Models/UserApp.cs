using Microsoft.AspNetCore.Identity;
using SportsNetwork.Core.Models.Bildirimler;
using SportsNetwork.Core.Models.Dersler;
using SportsNetwork.Core.Models.Etkinlikler;
using SportsNetwork.Core.Models.Gruplar;
using SportsNetwork.Core.Models.Iliskiler;
using SportsNetwork.Core.Models.Mesajlar;
using SportsNetwork.Core.Models.Tesisler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Models
{
    /**************************************************************** 
    * Date: 20.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ < turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/
    public class UserApp : IdentityUser
    {
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public ICollection<Bildirim> Bildirimler { get; set; }
        public ICollection<KullaniciBildirim> KullaniciBildirimler { get; set; }

        public ICollection<Ders> Dersler { get; set; }
        public ICollection<DersRezervasyon> DersRezervasyonlar { get; set; }

        public ICollection<Etkinlik> Etkinlikler { get; set; }
        public ICollection<EtkinlikKatilimci> EtkinlikKatilimcilar { get; set; }
        public ICollection<EtkinlikYorum> EtkinlikYorumlar { get; set; }
        public ICollection<EtkinlikYorumBegeni> EtkinlikYorumBegeniler { get; set; }

        public ICollection<Grup> Gruplar { get; set; }
        public ICollection<GrupKullanici> GrupKullanicilar { get; set; }

        //public ICollection<Iliski> Iliskiler { get; set; }


        public ICollection<GrupMesaj> GrupMesajlar { get; set; }
        //public ICollection<OzelMesaj> OzelMesajlar { get; set; }

        public ICollection<Tesis> Tesisler { get; set; }
        public ICollection<TesisRezervasyon> TesisRezervasyonlar { get; set; }
        public ICollection<TesisYorum> TesisYorumlar { get; set; }
        public ICollection<TesisYorumBegeni> TesisYorumBegeniler { get; set; }

        //public ICollection<Puanlama> Puanlamalar { get; set; }
        public ICollection<Sonuc> Sonuclar { get; set; }


    }
}
