using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    public class Versement
    {
        public int Id { get; set; }
        public String Numero { get; set; }
        public String Description { get; set; }
        public Double Montant { get; set; }
        public DateTime Date { get; set; }
        public Carte carte { get; set; }
        public Admin admin { get; set; }

    }
}
