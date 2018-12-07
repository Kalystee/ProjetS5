using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Cuisine.Plats
{
    public class Plat
    {
        public int Id { get; set; }
        public int TpsCuisson { get; set; }
        public int NbPers { get; set; }
        public int TpsPrepa { get; set; }
        public bool EstPret { get; set; }
        public TypePlat typePlat { get; set; }
        public Dictionary<int,Ingredient> ListeIngredients { get; set; }
        public Ingredient Accompagnement { get; set; }
        

        public Plat()
        {

        }
    }
}
