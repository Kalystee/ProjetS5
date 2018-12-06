using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;

namespace Controlleur.Entity.Salle.CouvertTable
{
    public class CouvertTable : ICouvertTable
    {
        private List<Assiettes> assiettes;
        private List<Verres> verres;
        private List<Couverts> couverts;
        private List<Tissus> tissus;

        public CouvertTable()
        {

        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void ReactAssiettes()
        {

        }

        public void ReactVerres()
        {

        }

        public void ReactCouverts()
        {

        }

        public void ReactTissus()
        {

        }
    }
}
