using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Model
{
    class Droits
    {
        public int Id { get; set; }
        public Admin admin { get; set; }
        public string Table { get; set; }
        public string Consulter { get; set; }
        public string Ajouter { get; set; }
        public string Modifier { get; set; }
        public string Supprimer { get; set; }
    }
}
