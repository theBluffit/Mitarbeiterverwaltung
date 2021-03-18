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
    /// Interaktionslogik für FensterMinMax.xaml
    /// </summary>
    public partial class FensterMinMax : Window
    {
        /// <summary>
        /// Das Singleton Objekt
        /// </summary>
        private static FensterMinMax singleton = null;

        /// <summary>
        /// Eine Referenz auf die Firma
        /// </summary>
        private Firma firma = null;

        /// <summary>
        /// Initialisiert eine neue Instanz der FensterMinMax Klasse
        /// </summary>
        /// <param name="firma">Eine Referenz auf die Firma</param>
        private FensterMinMax(Firma firma)
        {
            this.InitializeComponent();

            this.firma = firma;
            this.UpdateWindow();
        }

        /// <summary>
        /// Holt das Singleton Objekt
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        /// <returns>Die Singleton Instanz</returns>
        public static FensterMinMax GetWindow(Firma firma)
        {
            if (singleton == null)
            {
                singleton = new FensterMinMax(firma);
            }

            return singleton;
        }

        /// <summary>
        /// Aktuallisiert das Fenster
        /// </summary>
        public void UpdateWindow()
        {
            lstDetailsBest.Items.Clear();
            lstDetailsWorst.Items.Clear();

            Mitarbeiter kleinsterMitarbeiter = null;
            Mitarbeiter groessterMitarbeiter = null;

            // Suche nach kleinsten und größten Mitarbeiter
            foreach (Mitarbeiter mitarbeiter in this.firma.ListMitarbeiter)
            {
                // Prüfe ob kleiner
                if (kleinsterMitarbeiter == null)
                {
                    kleinsterMitarbeiter = mitarbeiter;
                }
                else
                {
                    if (mitarbeiter.GetBrutto() < kleinsterMitarbeiter.GetBrutto())
                    {
                        kleinsterMitarbeiter = mitarbeiter;
                    }
                }

                // Prüfe ob größer
                if (groessterMitarbeiter == null)
                {
                    groessterMitarbeiter = mitarbeiter;
                }
                else
                {
                    if (mitarbeiter.GetBrutto() > groessterMitarbeiter.GetBrutto())
                    {
                        groessterMitarbeiter = mitarbeiter;
                    }
                }
            }

            // Größter Mitarbeiter anzeigen wenn vorhanden
            if (groessterMitarbeiter != null)
            {
                lstDetailsBest.Items.Add(groessterMitarbeiter.GetDetails());
            }

            // Kleinster Mitarbeiter anzeigen wenn vorhanden
            if (kleinsterMitarbeiter != null)
            {
                lstDetailsWorst.Items.Add(kleinsterMitarbeiter.GetDetails());
            }
        }
    }
}
