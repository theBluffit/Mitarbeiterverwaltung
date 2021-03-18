namespace Vererbung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Die Basisklasse eines Subjekt für das Observer-Pattern
    /// </summary>
    public abstract class Subject
    {
        /// <summary>
        /// Die Liste aller angebundenen Beobachter
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// Fügt dem Subjekt einen Beobachter hinzu
        /// </summary>
        /// <param name="observer">Der Beobachter</param>
        public void Attatch(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// Entfernt einen Beobachter vom Subjekt
        /// </summary>
        /// <param name="observer">Der Beobachter</param>
        public void Detatch(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        /// <summary>
        /// Aktualisiert alle angebundenen Beobachter
        /// </summary>
        public void Notify()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
