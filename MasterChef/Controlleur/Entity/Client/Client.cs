using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle;
using Controlleur.Entity.Salle.Disposition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controlleur.Entity.Client
{
    public class Client
    {
        public Table Table { get; set; }

        public Client()
        {

        }

        /// <summary>
        /// methode : Client order something only if a table is  available for eating
        /// </summary>
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