using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Cuisine.Plats;

namespace Controlleur.Entity.Cuisine.Personnel
{
    public class Cuisinier : PersonnelCuisine
    {
        public PlatBuilder Builder { get; set; }

        public Cuisinier(int id) : base(id)
        {
            this.Builder = new PlatBuilder();
        }

        public Plat preparerPlat(Plat p)
        {
            this.Builder.PréparerPlat(p);
            this.Builder.PréparerAccompagnement();
            this.Builder.Result.EstPret = true;
            return this.Builder.GetResult();
            
        }
    }
}
