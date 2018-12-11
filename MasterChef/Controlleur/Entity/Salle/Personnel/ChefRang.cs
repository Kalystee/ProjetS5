using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Salle.Disposition;
using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Clients;

namespace Controlleur.Entity.Salle.Personnels
{
    public class ChefRang : P_Salle, IObserver<Client>
    {
        public Commande Commande { get; set; }
        private List<string> nameInfos = new List<string>();
        private IDisposable cancellation;

        /// <summary>
        /// Constructor get this observer
        /// </summary>
        /// <param name="name"></param>
        public ChefRang(string name) : base(name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned ");
            this.name = name;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="t"></param>
        /// <param name="p"></param>
        public void PrendreCommande(Table t, Plat p)
        {
            this.Commande = new Commande(t, p);
        }

        /// <summary>
        /// Add MH to the list of observer
        /// </summary>
        /// <param name="provider"></param>
        public virtual void Subscribe(ClientHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            nameInfos.Clear();
        }

        public void OnNext(Client value)
        {
            //prendre une commande
            //info : client + table = commande

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
