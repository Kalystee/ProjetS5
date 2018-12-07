using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Controlleur.Entity.Salle.Personnels
{
    public class Serveur : P_Salle
    {
        public Commande Commande { get; set; }


        public Serveur(int id) : base(id)
        {

        }

        public void ReceptionCommande()
        {

        }

        public void ServirCommande()
        {
            
        }
    }
}
