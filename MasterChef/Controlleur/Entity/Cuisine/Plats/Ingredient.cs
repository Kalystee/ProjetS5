using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Cuisine.Plats
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public DateTime Dlc { get; set; }
        public int Id_Zone { get; set; }

        /// <summary>
        /// Query to insert a new ingredient
        /// </summary>
        /// <returns>Query to insert a new ingredient</returns>
        public string InsertIngredient()
        {
            return "INSERT INTO INGREDIENT(Nom,Quantite,DLC,Id_ZONE_STOCKAGE) VALUES (" + this.Nom+","+this.Quantite+",CURRENT_TIMESTAMP,"+this.Id_Zone+")";
        }

        
    }
}
