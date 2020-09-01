using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    public class Bus
    {
        public int Id { get; set; }
        public String Numero { get; set; }
        public String Type { get; set; }
        public String Marque { get; set; }
        public string Place { get; set; }
        public String Kilometrage { get; set; }
        public String Puissance { get; set; }
        public String Energie { get; set; }
        public String Etat { get; set; }
        public DateTime DateMise { get; set; }
        public String CarteGrise { get; set; }
        public String Chassis { get; set; }
    }
}
