using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity
{
    public class Restaurant
    {
        public string Nom { get; set; }
        public Cuisine.Cuisine Cuisine { get; set; }

        public Restaurant(string nom)
        {

        }
    }
}
