namespace Vererbung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Stellt die Firma da
    /// </summary>
    public class Firma
    {
        /// <summary>
        /// Die Liste der Mitarbeiter
        /// </summary>
        private List<Mitarbeiter> listMitarbeiter = new List<Mitarbeiter>();

        /// <summary>
        /// Das Fenster für das Eingeben neuer Mitarbeiter
        /// </summary>
        private MainWindow formEingabe = null;

        /// <summary>
        /// Das Fenster für das Anzeigen aller Mitarbeiter
        /// </summary>
        private FormMitarbeiter formMitarbeiter = null;

        /// <summary>
        /// Das Fenster für das Anzeigen des duchschnittlichen Gehalts
        /// </summary>
        private FormStatistik formStatistik = null;

        /// <summary>
        /// Das Fenster für das Anzeigen des am meisten und am geringsten verdienenden Mitarbeiters
        /// </summary>
        private FensterMinMax formMinMax = null;

        /// <summary>
        /// Initialisiert eine neue Instanz der Firma Klasse
        /// </summary>
        public Firma()
        {
            this.formEingabe = MainWindow.GetWindow(this);
            this.formMitarbeiter = FormMitarbeiter.GetWindow(this);
            this.formStatistik = FormStatistik.GetWindow(this);
            this.formMinMax = FensterMinMax.GetWindow(this);
        }

        /// <summary>
        /// Holt oder setzt die Liste der Mitarbeiter
        /// </summary>
        public List<Mitarbeiter> ListMitarbeiter
        {
            get { return this.listMitarbeiter; }
            set { this.listMitarbeiter = value; }
        }

        /// <summary>
        /// Zeigt alle Fenster an
        /// </summary>
        public void ShowWindows()
        {
            this.formEingabe.Show();
            this.formMitarbeiter.Show();
            this.formStatistik.Show();
            this.formMinMax.Show();
        }

        /// <summary>
        /// Aktualisiert alle Fenster
        /// </summary>
        public void UpdateWindows()
        {
            this.formMitarbeiter.UpdateWindow();
            this.formStatistik.UpdateWindow();
            this.formMinMax.UpdateWindow();
        }
    }
}
