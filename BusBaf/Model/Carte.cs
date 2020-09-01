using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    public class Carte
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateExpiration { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Porteur { get; set; }
        public double Solde { get; set; }
        public double SoldeMin { get; set; }

    }
}
