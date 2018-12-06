using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Cuisine.Ustensiles
{
    public abstract class Ustensile
    {
        protected int id { get; set; }
        protected string nom { get; set; }

        protected bool estSale1;

        public bool GetestSale()
        {
            return estSale1;
        }

        public void SetestSale(bool value)
        {
            estSale1 = value;
        }

        public Ustensile(int _id, string _nom)
        {

        }
    }
}
