using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Cuisine.Personnel
{
    public class Chef : PersonnelCuisine
    {
        private static Chef instance;

        private Chef(int id) : base(id)
        {

        }

        public static Chef GetInstance()
        {
            if(Chef.instance == null)
            {
                Chef.instance = new Chef(1);
            }
            return Chef.instance;
        }
    }
}
