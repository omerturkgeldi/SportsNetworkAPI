using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.DTOs
{
    public class UserAppDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciRole { get; set; }
    }
}
