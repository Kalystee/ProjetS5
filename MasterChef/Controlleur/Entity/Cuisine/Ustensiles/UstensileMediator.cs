using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;

namespace Controlleur.Entity.Cuisine.Ustensiles
{
    public class UstensileMediator : IUstensile
    {
        public List<GrosUstensile> ListGrosUstensiles { get;  }
        public List<PetitUstensile> ListPetitUstensiles { get; }

        public UstensileMediator()
        {

        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
