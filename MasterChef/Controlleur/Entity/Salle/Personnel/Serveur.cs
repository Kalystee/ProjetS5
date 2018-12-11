using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle.Disposition;
using Controlleur.Entity.Salle.CouvertTable;

namespace Controlleur.Entity.Salle.Personnels
{
    public class Serveur : P_Salle
    {
        public Commande Commande { get; set; }
        CouvertTable.CouvertTable[] couvertTables = new CouvertTable.CouvertTable[5];
        public Table tableCible;


        public Serveur(string name) : base(name)
        {
       
        }

        public void ReceptionCommande()
        {

        }

        public void ServirCommande()
        {
            this.Commande = null;
        }

        public void DebarasserTable()
        {

        }

    }
}
