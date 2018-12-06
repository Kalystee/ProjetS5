using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Cuisine.Plats
{
    public class ZoneConserv
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int QuantitéMax { get; set; }
        public int TempsConserv { get; set; }
        public List<Ingredient> ingredients { get; set; }
    }
}
