using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    public class Chauffeur
    {
        public int Id { get; set; }
        public String Numero { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNais { get; set; }
        public String Telephone { get; set; }
        public String Adresse { get; set; }
        public String Permis { get; set; }
        public String Status { get; set; }
        public Byte Photo { get; set; }

    }
}
