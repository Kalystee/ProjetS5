using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Cuisine.Plats;

namespace Controlleur.Entity.Cuisine.Personnel
{
    public class Cuisinier
    {
        public PlatBuilder Builder { get; set; }

        public void preparerPlat(Plat p)
        {
            throw new NotImplementedException();
        }

        public void allerCuire()
        {
            throw new NotImplementedException();
        }

        public void préparerAccompagnement(Ingredient i)
        {
            throw new NotImplementedException();
        }
    }
}
