using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Salle.Disposition;
using Controlleur.Entity.Cuisine.Plats;

namespace Controlleur.Entity.Salle
{
    public class Commande
    {
        private Table table;
        private Plat plat;

        public Commande(Table table,Plat plat)
        {

        }

        public Plat GetPlat()
        {
            return plat;
        }
    }
}
