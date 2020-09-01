using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    public class Attribuer
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Bus bus { get; set; }
        public Chauffeur chauffeur { get; set; }
    }
}
