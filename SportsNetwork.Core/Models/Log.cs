using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsNetwork.Data.Models
{
    /**************************************************************** 
    * Date: 20.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ < turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/
    
    public class Log
    {
        public int Id { get; set; }
        public string Application { get; set; }
        public string MachineName { get; set; }
        public string Logged { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }

    }
}
