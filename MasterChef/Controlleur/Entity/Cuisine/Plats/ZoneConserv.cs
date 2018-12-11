using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controlleur.Entity.Cuisine.Plats
{
    public class ZoneConserv
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int QuantitéMax { get; set; }
        public int TempsConserv { get; set; }
        //public List<Ingredient> ingredients { get; set; }

        public string GetIngredientsOfZone()
        {
            return "SELECT * FROM INGREDIENT WHERE Id_ZONE_STOCKAGE IN (SELECT Id FROM ZONE_STOCKAGE WHERE Id =" + this.Id+");";
        }

        public string GetZone()
        {
            return "SELECT * FROM ZONE_STOCKAGE WHERE Id=" + this.Id ;
        }

        /*public string AddIngredientsInZ()
        {
            return "INSERT INTO INGREDIENT (Nom,Quantite) VALUES();";
        }*/
        
       /* public string AddIngredient(Ingredient i)
        {
            
        }*/

        

        public void DeleteIngredient(Ingredient i)
        {
            throw new NotImplementedException();
        }

        public void UseIngredient(Ingredient tomate, int v)
        {
            throw new NotImplementedException();
        }
    }
}
