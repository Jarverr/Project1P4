using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    public class Grades
    {
        [Key]
        public int IdOceny { get; set; }
        public int OcenaAdministratora { get; set; }
        public int OcenaAdministratorki { get; set; }
        public virtual ICollection<Tracks> Utwory { get; set; } = new List<Tracks>();


    }
}
