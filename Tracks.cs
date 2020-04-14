using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1ListaPrzebojów
{
    public class Tracks
    {
        [Key]
    
        public int IdUtworu { get; set; }
        public string NazwaUtworu { get; set; }
        public int RokWykonania { get; set; }
        public string OpisUtworu { get; set; }
        public string Długość { get; set; }
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        [ForeignKey("Ocena")]
        public int IdOceny { get; set; }
        [ForeignKey("Wykonawca")]
        public int WykonawcaId { get; set; }
        public virtual Albums Album{ get; set; }
        public virtual Grades Ocena{ get; set; }
        public virtual Performers Wykonawca { get; set; }
        public virtual ICollection<Geners> Gatunki { get; set; } = new List<Geners>();
        public virtual ICollection<Awards> Nagrody { get; set; } = new List<Awards>();

    }
}
