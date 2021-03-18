namespace Vererbung
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Die Firma
        /// </summary>
        private Firma firma = new Firma();

        /// <summary>
        /// Initialisiert eine neue Instanz der App Klasse
        /// </summary>
        public App()
        {
            this.firma.ShowWindows();
        }
    }
}
