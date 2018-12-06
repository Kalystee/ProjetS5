using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;

namespace Controlleur.Entity.Cuisine.Ustensiles
{
    public class Ustensile : IUstensile
    {
        public List<GrosUstensile> ListGrosUstensiles { get;  }
        public List<PetitUstensile> ListPetitUstensiles { get; }

        public Ustensile()
        {

        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
