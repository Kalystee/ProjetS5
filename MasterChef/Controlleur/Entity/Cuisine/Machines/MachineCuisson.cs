using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;

namespace Controlleur.Entity.Cuisine.Machine
{
    public class MachineCuisson : Machine, ICuisson
    {
        public MachineCuisson(int id, string nom) : base(id,nom)
        {

        }

        public void Cuire()
        {
            throw new NotImplementedException();
        }
    }
}
