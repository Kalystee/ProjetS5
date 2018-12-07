using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Salle.Personnels;

namespace Controlleur.Entity.Salle.Disposition
{
    public class Carre
    {
        private int id;
        private List<Rang> rangs;
        private ChefRang chefRang;
        private Serveur serveur;


        public Carre(int _id)
        {
            this.id = _id;
            this.rangs = new List<Rang>();

            for (int i = 0; i < 2; i++){
                this.rangs.Add(new Rang(i));
            }
        }
    }
}