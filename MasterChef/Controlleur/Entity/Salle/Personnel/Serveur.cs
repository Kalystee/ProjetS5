using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle.Disposition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks; 

namespace Controlleur.Entity.Salle.Personnels
{
    public class Serveur : P_Salle
    {
        public Commande Commande { get; set; }


        public Serveur(int id) : base(id)
        {
        
            Thread th = new Thread(ServirCommande);

            
            th.Start();

        }

        public void ReceptionCommande()
        {

        }

        public void ServirCommande()
        {
            /*Serveur serveur = new Serveur(20);

            serveur.Commande = new Commande(new Table(1,), new Plat());
            serveur.Commande.Plat.EstPret = true;
            serveur.ServirCommande();*/
        }
    }
}
