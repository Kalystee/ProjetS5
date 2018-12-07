using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Disposition
{
    public class Table
    {
        public int Id {get; set;}
        public int NbPlace { get; set; }
        public bool Disponible { get; set; }
        public Commande Commande { get; set; }

        public Table()
        {

        }

    }
}