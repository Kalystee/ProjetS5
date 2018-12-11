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
        public Plat Plat { get; set; }
        public Ingredient Ing { get; set; }
        public DataSet Dataset { get; set; }


        public CuisineController()
        {
            this.Connex = new CnxBDD();
            this.Zone = new ZoneConserv();
            this.Dataset = new DataSet();
            this.Ing = new Ingredient();
            this.Plat = new Plat();
        }

        public DataSet SelectIngredientInZone(int idZone)
        {
            this.Dataset.Tables.Clear();
            this.Zone.Id = idZone;
            return this.Connex.GetRows(this.Zone.GetIngredientsOfZone(), "INGREDIENT");
        }

        public void InsertIngredient(string nom, int quantite, int zone)
        {
            this.Dataset.Tables.Clear();
            this.Ing.Nom = nom;
            this.Ing.Quantite = quantite;
            this.Ing.Id_Zone = zone;
           this.Connex.ActionRow(this.Ing.InsertIngredient());
        }

        public DataSet SelectIngredientOfPlat(int idPlat)
        {
            this.Dataset.Tables.Clear();
            this.Plat.Id = idPlat;
            return this.Connex.GetRows(this.Plat.GetIngredients(),"INGREDIENT");
        }

    }
}
