namespace Vererbung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Die Basisklasse eines Beobachters
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Aktualisiert den Beobachter
        /// </summary>
        void Update();
    }
}
