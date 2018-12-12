using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;
using Modele;

namespace Controlleur.Entity.Cuisine.Plats
{
    public class PlatBuilder : Builder
    {

        public Plat Result { get; set; }



        public void CuirPlat()
        {
            Console.WriteLine("Cuisson...");
        }

        /// <summary>
        /// Method to préare a dish 
        /// </summary>
        /// <param name="plat">Dish to prepare</param>
        public void PréparerPlat(Plat plat)
        {
            this.Result = plat;
            DataSet data = new DataSet();
            CnxBDD bdd = new CnxBDD();
            data = bdd.GetRows(this.Result.GetIngredients(), "INGREDIENT");
            foreach (DataRow dataR in data.Tables[0].Rows)
            {
                bdd.ActionRow(this.Result.UseIngredients((int)dataR["Id"]));
            }

           
            if (plat.TpsCuisson > 0)
            {
                CuirPlat();
                //Trouver un four avec de la place, y placer le plat et le mettre en marche pendant le temps demander
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void PréparerAccompagnement()
        {
            if(this.Result.Accompagnement != null)
            {
                //Trouver un moyen de préparer l'accompagnement
            }
        }

        /// <summary>
        /// Method to get the final dish
        /// </summary>
        /// <returns></returns>
        public Plat GetResult()
        {
            return this.Result;
        }

        
    }
}
