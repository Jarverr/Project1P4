using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    class AwardsReceive
    {
        [Key]
        public int IdUtworu { get; set; }
        [Key]
        public int IdNagrody { get; set; }
        public DateTime DataOtrzymania { get; set; }
    }
}
