using Controlleur.Entity.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity
{
    /* class ClientHandler : IObservable<Client>
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
         public IDisposable Subscribe(IObservable<Client> observer)
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
         /// Called to indicate all baggage is now unloaded
         /// </summary>
         /// <param name="_name"></param>
         public void ClientStatus(string _name)
         {
             ClientStatus(_name,String.Empty,0);
         }



         public void ClientSatus(string _name, int _nbPers)
         {
             var client = new Client(_name,_nbPers);
             //_nbPers is assigned, so add new client object to list
             if (_nbPers > 0 && !name.Contains(client))
             {
                 name.Add(client);
                 foreach (var observer in observers)
                     observer.OnNext(client);
             }

             else if (_nbPers == 0)
             {

             }
         }
     }*/
}
