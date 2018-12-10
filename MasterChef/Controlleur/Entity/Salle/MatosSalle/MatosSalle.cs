using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;
using Controlleur.Entity.Salle.Disposition;

namespace Controlleur.Entity.Salle.MatosSalle
{
    public class MatosSalle : IMatosSalle

    {
        private List<Corbeille> corbeilles;
        private List<Bouteille> bouteilles;
        private int matosSalle;
        public Table Table { get; set; }

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