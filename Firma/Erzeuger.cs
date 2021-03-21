namespace Mitarbeiterverwaltung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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

            firma.Attatch(formEingabe);
            firma.Attatch(formStatistik);
            firma.Attatch(formMitarbeiter);
            firma.Attatch(formMinMax);

            formEingabe.Show();
            formStatistik.Show();
            formMitarbeiter.Show();
            formMinMax.Show();
        }
    }
}
