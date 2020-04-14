using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    public class Albums
    {
        [Key]
        public int IdAlbumu { get; set; }
        public string NazwaAlbumu { get; set; }
        public int? RokWydania { get; set; }
        public int? RokRozpoczecieNagrań { get; set; }
        public string Wydawnictwo { get; set; }
        public virtual ICollection<Tracks> Utwory { get; set; } = new List<Tracks>();

    }
}
