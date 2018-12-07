using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Clients;

namespace Controlleur.Entity.Salle.Disposition
{
    public class Table
    {
        public int Id {get;}
        public int NbPlace { get;}
        public  Client Client { get; set; }

        public Table(int id, int nbPlace)
        {
            this.Id = id;
            this.NbPlace = nbPlace;
            
        }

        public bool EstDisponible()
        {
            return this.Client != null;
        }

    }
}