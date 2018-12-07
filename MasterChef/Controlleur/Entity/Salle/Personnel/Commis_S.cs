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

        private Commis_S(int id) : base(id) {

        }

        public static Commis_S GetInstance()
        {
            if (Commis_S.instance == null)
            {
                Commis_S.instance = new Commis_S(40);
            }
            return Commis_S.instance;
        }

    }
}
