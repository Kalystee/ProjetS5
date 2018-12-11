using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Disposition
{
    public class Rang
    {
        private int id;
        public List<Table> Tables { get; }

        /// <summary>
        /// Constructor of a Rang
        /// </summary>
        /// <param name="_id">Id of the rang</param>
        public Rang(int _id)
        {
            this.id = _id;
            this.Tables = new List<Table>();
            for(int i = 0; i < 2; i++)
            {
                this.Tables.Add(new Table(i,4));
            }
        }
    }
}