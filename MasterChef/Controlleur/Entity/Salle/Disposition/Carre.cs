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
        public List<Rang> Rangs { get;}
        private ChefRang chefRang;
        private Serveur serveur;

        /// <summary>
        /// Constructor of a Carre
        /// </summary>
        /// <param name="_id">Id of the carre</param>
        public Carre(int _id)
        {
            this.id = _id;
            this.Rangs = new List<Rang>();
            this.chefRang = new ChefRang("ChefRang");
            this.serveur = new Serveur("Serveur");

            for (int i = 0; i < 2; i++){
                this.Rangs.Add(new Rang(i));
            }
        }
    }
}