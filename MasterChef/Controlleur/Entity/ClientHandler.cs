using Controlleur.Entity.Clients;
using Controlleur.Entity.Salle.Personnels;
using Controlleur.Entity.Salle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Cuisine.Plats;

namespace Controlleur.Entity
{
    public class ClientHandler : IObservable<Client>
    {
        private List<IObserver<Client>> observers; //people who will get informations
        private List<Client> name;

         public ClientHandler()
         {
             observers = new List<IObserver<Client>>();
             name = new List<Client>();
         }

        /// <summary>
        /// methode to check if observer is already registered. If not, add it
        /// provide observe with existing data
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<Client> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                foreach (var item in name)
                    observer.OnNext(item);
            }
            return new Unsubscriber<Client>(observers, observer);
        }

        /// <summary>
        /// It permits to know if client is taken or not by MaitreHotel
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="_nbPers"></param>
        public void ClientStatus(string Name, int _nbPers)
        {
            var client = new Client(Name, _nbPers);
            //_nbPers is assigned, so add new client object to list
            if (_nbPers > 0 && !name.Contains(client))
            {
                name.Add(client);
                foreach (var observer in observers)
                    observer.OnNext(client);
            }
        }
    }
}
