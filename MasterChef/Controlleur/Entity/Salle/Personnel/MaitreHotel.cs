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
    public class MaitreHotel : P_Salle, IObserver<Client>
    {
        private static MaitreHotel instance;

        private List<string> nameInfos = new List<string>();
        private IDisposable cancellation;


        private MaitreHotel(string name) : base(name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned ");
            this.name = name;
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

        public static MaitreHotel GetInstance()
        {
            if (MaitreHotel.instance == null)
            {
                MaitreHotel.instance = new MaitreHotel("MH");
            }
            return MaitreHotel.instance;
             
      

        }


        public void OnNext(Client info)
        {
            bool update = false;

            if(info.NbPers == 0)
            {
                Console.WriteLine("Aucun Client ", this.name);
                Console.WriteLine();
            }
            else
            {
                //Add name if it doesn't exist
                string nameInfo = String.Format(info.Name, info.NbPers);
                if(!nameInfos.Contains(nameInfo))
                {
                    nameInfos.Add(nameInfo);
                    update = true;
                }
            }
            if (update)
            {
                nameInfos.Sort();
                Console.WriteLine("Client is here : ");
                foreach (var nameInfo in nameInfos)
                    Console.WriteLine(nameInfo);
                Console.WriteLine("A table for :");
                Console.WriteLine(info.NbPers);
                Console.WriteLine();

            }
        }


        /// <summary>
        /// implementation needed
        /// this methode is not called by the ClientHandler class
        /// </summary>
        /// <param name="error"></param>
        public void OnError(Exception error)
        {
           
        }

        public void OnCompleted()
        {
            nameInfos.Clear();
        }
    }
}
