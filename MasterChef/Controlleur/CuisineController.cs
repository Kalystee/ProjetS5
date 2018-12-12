using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Modele;
using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Cuisine.Personnel;

namespace Controlleur
{
    public class CuisineController
    {
        public CnxBDD Connex { get; }
        public ZoneConserv Zone { get; set; }
        public Plat Plat { get; set; }
        public Ingredient Ing { get; set; }
        public DataSet Dataset { get; set; }
        public Cuisinier Cuisinier { get; set; }


        public CuisineController()
        {
            this.Connex = new CnxBDD();
            this.Zone = new ZoneConserv();
            this.Dataset = new DataSet();
            this.Ing = new Ingredient();
            this.Plat = new Plat();
            this.Cuisinier = new Cuisinier(100);
        }

        /// <summary>
        /// Method to get all the ingredient in a zone
        /// </summary>
        /// <param name="idZone">Id of the zone </param>
        /// <returns></returns>
        public DataSet SelectIngredientInZone(int idZone)
        {
            this.Dataset.Tables.Clear();
            this.Zone.Id = idZone;
            return this.Connex.GetRows(this.Zone.GetIngredientsOfZone(), "INGREDIENT");
        }

        /// <summary>
        /// Method to add ingredient in a zone
        /// </summary>
        /// <param name="nom">Name of the ingredient</param>
        /// <param name="quantite">Quantity of the ingredient</param>
        /// <param name="zone">Id of the zone where the ingredient will be stock</param>
        public void InsertIngredient(string nom, int quantite, int zone)
        {
            this.Dataset.Tables.Clear();
            this.Ing.Nom = nom;
            this.Ing.Quantite = quantite;
            this.Ing.Id_Zone = zone;
           this.Connex.ActionRow(this.Ing.InsertIngredient());
        }

        /// <summary>
        /// Method to get all the ingredient we need to prepare a dish
        /// </summary>
        /// <param name="idPlat"></param>
        /// <returns></returns>
        public DataSet SelectIngredientOfPlat(int idPlat)
        {
            this.Dataset.Tables.Clear();
            this.Plat.Id = idPlat;
            return this.Connex.GetRows(this.Plat.GetIngredients(),"INGREDIENT");
        }

    }
}
