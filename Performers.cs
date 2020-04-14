using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    public class Performers
    {
        [Key]
        public int IdWykonawcy { get; set; }
        public string Wykonawca { get; set; }
        public Nullable<int> RokPowstania { get; set; }
        public virtual ICollection<Tracks> Utwory { get; set; } = new List<Tracks>();

    }
}
