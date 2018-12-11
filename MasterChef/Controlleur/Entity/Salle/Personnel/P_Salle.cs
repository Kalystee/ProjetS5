using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle.Personnels
{
    public abstract class P_Salle
    {
        protected string name;
        public string Name
        {
            get
            {
                return this.name;  
            }

            set
            {
                this.name=value;
            }
        }
        

        public P_Salle(string name)
        {
         
        }
    }
}
