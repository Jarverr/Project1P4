using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    class GenersBelonging
    {
        [Key]
        public int IdUtworu { get; set; }
        [Key]
        public int IdGatunku { get; set; }
    }
}
