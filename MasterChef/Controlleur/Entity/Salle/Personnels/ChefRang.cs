using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Personnels
{
    public class ChefRang : P_Salle
    {
        private ChefRang instance;

        private ChefRang(int id) : base(id)
        {

        }

        public ChefRang GetInstance()
        {
            return null;
        }
    }
}
