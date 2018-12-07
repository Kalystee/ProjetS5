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
        public Table Table { get; set; }
        public Plat Plat { get; set; }

        public Commande(Table table,Plat plat)
        {
            this.Table = table;
            this.Plat = plat;
        }

        public void CommanderPlat()
        {
            Table table = new Table();

            if (table.Disponible == true)
            {
                Commande commande = new Commande(new Table(), new Plat());
            }
        }

    }
}
