using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;

namespace Controlleur.Entity.Cuisine.Plats
{
    public class PlatBuilder : Builder
    {

        public Plat Result { get; set; }



        public void CuirPlat()
        {
            throw new NotImplementedException();
        }

        public void PréparerPlat(Plat plat)
        {
            plat.UseIngredients();

            //Patienter le temps de préparation
            Thread.Sleep(plat.TpsPrepa*1000);

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
