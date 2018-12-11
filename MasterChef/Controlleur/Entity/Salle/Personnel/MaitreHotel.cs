using Controlleur.Entity.Clients;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Salle.Disposition;
using Controlleur.Entity.Salle.Personnels;

namespace Controlleur.Entity.Salle.Disposition.Personnels
{
    public class MaitreHotel : P_Salle, IObserver<Clients.Client>
    {
        private static MaitreHotel instance;
        private ChefRang chefRang;
        public Salle salle { get; set; }


        private MaitreHotel(int id) : base(id)
        {
            Salle salle = new Salle(1);
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
        public void IAssignerTable()
        {
        
        }

        public void OnNext(Client value)
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
