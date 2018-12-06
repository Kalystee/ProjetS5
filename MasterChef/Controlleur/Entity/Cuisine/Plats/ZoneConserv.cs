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

        public void AddIngredient(Ingredient i)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> ingredients { get; set; }

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
