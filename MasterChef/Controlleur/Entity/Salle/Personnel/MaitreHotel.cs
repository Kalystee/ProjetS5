using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Personnels
{
    public class MaitreHotel : P_Salle
    {
        private static MaitreHotel instance;

        private MaitreHotel(int id) : base(id)
        {

        }
        
        public static MaitreHotel GetInstance()
        {
            return null;
        }
    }
}
