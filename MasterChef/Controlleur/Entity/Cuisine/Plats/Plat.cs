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

        /// <summary>
        /// Methof to get the query to get a dish using Id
        /// </summary>
        /// <param name="idPlat">Id of the dish</param>
        /// <returns>Query to get the dish</returns>
        public string GetPlatFromId(int idPlat)
        {
            return "SELECT * FROM RECETTE WHERE Id=" + idPlat;
        }

        /// <summary>
        /// Query to get all the ingredients of the dish
        /// </summary>
        /// <returns>Query</returns>
        public string GetIngredients()
        {
            return "SELECT * FROM INGREDIENT WHERE Id IN (SELECT Id_Ingredient FROM composer WHERE Id ="+this.Id+");";
        }

        /// <summary>
        /// Query to update the quantity of all the ingredient of the dish
        /// </summary>
        /// <returns>Query</returns>
        public string UseIngredients(int idIng)
        {
            return "UPDATE INGREDIENT " +
                "SET Quantite = Quantite - (SELECT Quantite_INGREDIENT FROM composer WHERE Id_INGREDIENT = " + idIng + " AND Id=" + this.Id + ")" +
                "WHERE Id = " + idIng + ";";
        }
    }
}
