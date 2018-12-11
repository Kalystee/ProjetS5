using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle;
using Controlleur.Entity.Salle.Disposition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;


namespace Controlleur.Entity.Clients
{
    public class Client
    {
        public string Name { get; }
        public int NbPers { get; }
        public Plat Plat { get; }
        public Commande Commande { get; set; }
        public IBehaviour Behaviour { get; set; }


        /// <summary>
        /// Constructor of a Client
        /// </summary>
        /// <param name="_name">Name of the client</param>
        /// <param name="_nbPers">Number of person</param>
        public Client(string _name, int _nbPers)
        {
            this.Name = _name;
            this.NbPers = _nbPers;

            
        }

        
        /// <summary>
        /// A client can choose dishes of the restaurant menu
        /// </summary>
        /// <returns></returns>
        public Plat CommanderPlat()
        {
            Plat commandePlat = new Plat();
            commandePlat.Id = 2;
            return commandePlat;
        }
    }  
}