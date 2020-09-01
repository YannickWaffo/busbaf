using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    public class Points
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Description { get; set; }
        public string coordonnee { get; set; }
        public string Etat { get; set; }
        public Ligne ligne { get; set; }
    }
}
