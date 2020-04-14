using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    public class Geners
    {
        [Key]
        public int IdGatunku { get; set; }
        public string NazwaGatunku { get; set; }
        public int RokPowstania{ get; set; }
        public string MiejscePowstania { get; set; }
        public virtual ICollection<Tracks> Utwory { get; set; } = new List<Tracks>();


    }
}
