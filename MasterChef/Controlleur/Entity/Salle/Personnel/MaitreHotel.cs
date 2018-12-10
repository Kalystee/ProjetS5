using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle.Disposition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Personnels
{
    public class MaitreHotel : P_Salle
    {
        private static MaitreHotel instance;

        private MaitreHotel(int id) : base(id)
        {

        }
        
        public static MaitreHotel GetInstance()
        {
            if (MaitreHotel.instance == null)
            {
                MaitreHotel.instance = new MaitreHotel(10);
            }
            return MaitreHotel.instance;
             
      

        }

        /// <summary>
        /// methode : Client order something only if a table is  available for eating
        /// </summary>
        public void CreerCommander()
        {
            Table table = new Table();

            if (table.EstDisponible == true)
            {
                Commande commande = new Commande(new Table(), new Plat());
            }

        }
    }
}
