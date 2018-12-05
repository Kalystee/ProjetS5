using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Personnels
{
    public abstract class P_Salle
    {
        protected int id;
        public int Id
        {
            get
            {
                return this.id;  
            }

            set
            {
                this.id=value;
            }
        }
        

        public P_Salle(int id)
        {
         
        }
    }
}
