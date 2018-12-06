using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Cuisine.Machines;
using Controlleur.Entity.Cuisine.Ustensiles;

namespace Controlleur.Entity.Cuisine
{
    public class Cuisine
    {
        public int Id { get; set; }
        public List<ZoneConserv> ListZone { get; set; }
        public List<Machine> ListMachine { get; set; }
        public List<Ustensile> ListUstensile { get; set; }

        public Cuisine()
        {

        }

    }
}
