namespace Mitarbeiterverwaltung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Mitarbeiterverwaltung.Views;

    /// <summary>
    /// Stellt eine Methode zum erstellen aller Beobachter bereit
    /// </summary>
    public static class Erzeuger
    {
        /// <summary>
        /// Erstellt alle Beobachter fügt sie dem Subjekt hinzu
        /// </summary>
        /// <param name="firma">Das Subjekt</param>
        public static void ErzeugeObserver(FirmaSubject firma)
        {
            ViewEingabe formEingabe = ViewEingabe.GetWindow(firma);
            ViewStatistik formStatistik = ViewStatistik.GetWindow(firma);
            ViewMitarbeiter formMitarbeiter = ViewMitarbeiter.GetWindow(firma);
            ViewMinMax formMinMax = ViewMinMax.GetWindow(firma);

            firma.Attach(formEingabe);
            firma.Attach(formStatistik);
            firma.Attach(formMitarbeiter);
            firma.Attach(formMinMax);

            formEingabe.Show();
            formStatistik.Show();
            formMitarbeiter.Show();
            formMinMax.Show();
        }
    }
}
