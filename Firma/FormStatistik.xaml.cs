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
    /// Interaktionslogik für FormStatistik.xaml
    /// </summary>
    public partial class FormStatistik : Window
    {
        /// <summary>
        /// Das Singleton Objekt
        /// </summary>
        static private FormStatistik singleton = null;

        /// <summary>
        /// Eine Referenz auf die Firma
        /// </summary>
        private Firma firma = null;

        /// <summary>
        /// Initialisiert eine neue Instanz der FormStatistik Klasse
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        private FormStatistik(Firma firma)
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
        static public FormStatistik GetWindow(Firma firma)
        {
            if (singleton == null)
            {
                singleton = new FormStatistik(firma);
            }

            return singleton;
        }

        /// <summary>
        /// Aktuallisert das Fenster
        /// </summary>
        public void UpdateWindow()
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
