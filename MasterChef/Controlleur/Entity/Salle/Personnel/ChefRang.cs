using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Salle.Disposition;
using Controlleur.Entity.Cuisine.Plats;

namespace Controlleur.Entity.Salle.Personnels
{
    public class ChefRang : P_Salle
    {
        public Commande Commande { get; set; }
        

        public ChefRang(int id) : base(id)
        {
         
        }

        public void PrendreCommande(Table t, Plat p)
        {
            this.Commande = new Commande(t, p);
        }



        
    }
}
