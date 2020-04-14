using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    public class Awards
    {
        [Key]
        public int IdNagrody { get; set; }
        public string NazwaNagrody { get; set; }
        public string Kategoria { get; set; }
        public int RokWreczeniaPierwszejNagrody { get; set; }
        public virtual ICollection<Tracks> Utwory { get; set; } = new List<Tracks>();

    }
}
