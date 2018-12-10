using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Salle.Disposition.Personnels;
using Controlleur.Entity.Salle.Personnels;

namespace Controlleur.Entity.Salle.Disposition
{
    public class Salle
    {
        private int id;
        private List<Carre> carres;
        private MaitreHotel maitreHotel;

        /// <summary>
        /// Constructor of Salle
        /// </summary>
        /// <param name="num">Id of Salle</param>
        public Salle(int num)
        {
            this.id = num;
            this.carres = new List<Carre>();
            this.maitreHotel = MaitreHotel.GetInstance();
            for(int i = 0; i < 2; i++)
            {
                this.carres.Add(new Carre(i));
            }
            
            
        }
    }
}