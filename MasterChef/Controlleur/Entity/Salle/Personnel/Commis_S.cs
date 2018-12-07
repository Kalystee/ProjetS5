using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Personnels
{
    public class Commis_S : P_Salle
    {
        private static Commis_S instance;

        public Commis_S(int id) : base(id) {

        }

        public Commis_S GetInstance()
        {
            return null;
        }

    }
}
