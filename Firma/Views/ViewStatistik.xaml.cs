namespace Mitarbeiterverwaltung.Views
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
    /// Interaktionslogik für ViewStatistik.xaml
    /// </summary>
    public partial class ViewStatistik : Window, IObserver
    {
        /// <summary>
        /// Das Singleton Objekt
        /// </summary>
        private static ViewStatistik singleton = null;

        /// <summary>
        /// Eine Referenz auf die Firma
        /// </summary>
        private FirmaSubject firma = null;

        /// <summary>
        /// Initialisiert eine neue Instanz der ViewStatistik Klasse
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        private ViewStatistik(FirmaSubject firma)
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
        public static ViewStatistik GetWindow(FirmaSubject firma)
        {
            if (singleton == null)
            {
                singleton = new ViewStatistik(firma);
            }

            return singleton;
        }

        /// <summary>
        /// Aktuallisert das Fenster
        /// </summary>
        public void Update()
        {
            float gesamtGehalt = 0.0f;

            foreach (Mitarbeiter mitarbeiter in this.firma.ListMitarbeiter)
            {
                gesamtGehalt += mitarbeiter.GetBrutto();
            }

            if (gesamtGehalt != 0.0f)
            {
                this.tbxTotal.Text = Math.Round(gesamtGehalt / this.firma.ListMitarbeiter.Count, 2).ToString("0.00") + "€";
            }
        }
    }
}
