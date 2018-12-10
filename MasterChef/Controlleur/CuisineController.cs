using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Modele;
using Controlleur.Entity.Cuisine.Plats;

namespace Controlleur
{
    public class CuisineController
    {
        public CnxBDD Connex { get; }
        public ZoneConserv Zone { get; set; }
        public Ingredient Ing { get; set; }
        public DataSet Dataset { get; set; }

        public CuisineController()
        {
            this.Connex = new CnxBDD();
            this.Zone = new ZoneConserv();
            this.Dataset = new DataSet();
            this.Ing = new Ingredient();
        }

        public DataSet SelectIngredientInZone()
        {
            this.Dataset.Tables.Clear();

            this.Dataset = this.Connex.GetRows(this.Zone.GetIngredientsOfZone(), "ZONE_STOCKAGE");
            return this.Dataset;
        }

        public void InsertIngredient(string nom, int quantite, int zone)
        {
            this.Dataset.Tables.Clear();
            this.Ing.Nom = nom;
            this.Ing.Quantite = quantite;
            this.Ing.Id_Zone = zone;
           this.Connex.ActionRow(this.Ing.InsertIngredient());
        }

    }
}
