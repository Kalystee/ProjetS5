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

        public Commande Commande { get; set; }

        public Client(Commande commande)
        {
            this.Commande = commande;
            commande.CommanderPlat();   //Client choose a plat

        }
    }

    
}