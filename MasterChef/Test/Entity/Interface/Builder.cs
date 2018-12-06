using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Cuisine.Plats;

namespace Controlleur.Entity.Interface
{
    public interface Builder
    {
        void PréparerPlat(Plat plat);
        void PréparerAccompagnement();
        void CuirPlat();

    }
}
