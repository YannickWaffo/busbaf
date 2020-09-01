using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    class Periode
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Coordonnee { get; set; }
        public DateTime Heure { get; set; }
    }
}
