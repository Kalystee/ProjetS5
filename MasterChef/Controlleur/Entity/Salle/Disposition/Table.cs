using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Clients;
using Controlleur.Entity.Salle.MatosSalle;

namespace Controlleur.Entity.Salle.Disposition
{
    public class Table
    {
        public int Id {get;}
        public int NbPlace { get;}
        public  Client Client { get; set; }
        public MatosSalle.MatosSalle MatosSalle { get; set; }


        /// <summary>
        /// Constructor of a table
        /// </summary>
        /// <param name="id">Id of the table</param>
        /// <param name="nbPlace">number of seat of the table</param>
        public Table(int id, int nbPlace)
        {
            this.Id = id;
            this.NbPlace = nbPlace;
            
        }

        /// <summary>
        /// Method to know if the table is use by a client or not
        /// </summary>
        /// <returns>true if the table is available</returns>
        public bool EstDisponible()
        {
            return this.Client == null;
        }
    }
}