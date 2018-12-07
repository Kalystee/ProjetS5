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
        private List<Table> tables;

        public Rang(int _id)
        {
            this.id = _id;
            this.tables = new List<Table>();
            for(int i = 0; i < 2; i++)
            {
                this.tables.Add(new Table(i,4));
            }
        }
    }
}