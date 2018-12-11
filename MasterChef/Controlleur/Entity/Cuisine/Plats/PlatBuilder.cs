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
            Console.WriteLine("FIN PREPARATION");

            Console.WriteLine("Debut Attente");
            //Patienter le temps de préparation
            Thread.Sleep(plat.TpsPrepa*1000);
            Console.WriteLine("fin Attente");
            if (plat.TpsCuisson > 0)
            {
                CuirPlat();
                //Trouver un four avec de la place, y placer le plat et le mettre en marche pendant le temps demander
            }


        }

        public void PréparerAccompagnement()
        {
            if(this.Result.Accompagnement != null)
            {
                //Trouver un moyen de préparer l'accompagnement
            }
        }

        public Plat GetResult()
        {
            return this.Result;
        }

        
    }
}
