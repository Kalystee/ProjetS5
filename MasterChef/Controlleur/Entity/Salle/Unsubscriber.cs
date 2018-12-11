using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Salle
{
    public class Unsubscriber<Client> : IDisposable
    {
        private List<IObserver<Client>> _observers;
        private IObserver<Client> _observer;

        internal Unsubscriber(List<IObserver<Client>> observers, IObserver<Client> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
