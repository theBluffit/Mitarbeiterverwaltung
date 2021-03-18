namespace Vererbung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaktionslogik für FormMitarbeiter.xaml
    /// </summary>
    public partial class FormMitarbeiter : Window, IObserver
    {
        /// <summary>
        /// Das Singleton Objekt
        /// </summary>
        private static FormMitarbeiter singleton = null;

        /// <summary>
        /// Eine Referenz auf die Firma
        /// </summary>
        private FirmaSubject firma = null;

        /// <summary>
        /// Initialisiert eine neue Instanz der FormMitarbeiter Klasse
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        private FormMitarbeiter(FirmaSubject firma)
        {
            this.InitializeComponent();

            this.firma = firma;
            this.Update();
        }

        /// <summary>
        /// Holt das Singleton Objekt
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        /// <returns>Die Singleton Instanz</returns>
        public static FormMitarbeiter GetWindow(FirmaSubject firma)
        {
            if (singleton == null)
            {
                singleton = new FormMitarbeiter(firma);
            }

            return singleton;
        }

        /// <summary>
        /// Aktuallisiert das Fenster
        /// </summary>
        public void Update()
        {
            this.lstDetails.Items.Clear();

            foreach (Mitarbeiter mitarbeiter in this.firma.ListMitarbeiter)
            {
                this.lstDetails.Items.Add(mitarbeiter.GetDetails());
            }
        }
    }
}
