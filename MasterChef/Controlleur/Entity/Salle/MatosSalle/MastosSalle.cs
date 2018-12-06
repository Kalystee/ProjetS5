using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;

namespace Controlleur.Entity.Salle.MatosSalle
{
    public class MatosSalle : IMatosSalle

    {
        private List<Corbeille> corbeille;
        private List<Bouteille> bouteille;

        public MatosSalle()
            {

            }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void ReactCorbeille()
        {

        }

        public void ReactBouteille()
        {

        }
    }
}