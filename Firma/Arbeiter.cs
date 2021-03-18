namespace Vererbung
{
    /// <summary>
    /// Stellt einen Arbeiter da
    /// </summary>
    public class Arbeiter : Mitarbeiter
    {
        /// <summary>
        /// Die Anzahl der gearbeiteten Stunden
        /// </summary>
        private int stundenzahl = 0;

        /// <summary>
        /// Der Stundenlohn
        /// </summary>
        private float stundenlohn = 0;

        /// <summary>
        /// Initialisiert eine neue Instanz der Arbeiter Klasse
        /// </summary>
        /// <param name="vorname">Der Vorname</param>
        /// <param name="nachname">Der Nachname</param>
        /// <param name="stundenzahl">Die Anzahl der gearbeiteten Stunden</param>
        /// <param name="stundenlohn">Der Stundenlohn</param>
        public Arbeiter(string vorname, string nachname, int stundenzahl, float stundenlohn) : base(vorname, nachname)
        {
            this.Stundenzahl = stundenzahl;
            this.Stundenlohn = stundenlohn;
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der gearbeiteten Stunden
        /// </summary>
        public int Stundenzahl
        {
            get
            {
                return this.stundenzahl;
            }

            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException();
                }

                this.stundenzahl = value;
            }
        }

        /// <summary>
        /// Holt oder setzt den Stundenlohn
        /// </summary>
        public float Stundenlohn
        {
            get
            {
                return this.stundenlohn;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException();
                }

                this.stundenlohn = value;
            }
        }

        /// <summary>
        /// Holt die Details des Mitarbeiters
        /// </summary>
        /// <returns>Die Details</returns>
        public override string GetDetails()
        {
            return this.Vorname + " " + this.Nachname + " | Stundenzahl: " + this.stundenzahl + " | Stundenlohn: " + this.stundenlohn;
        }

        /// <summary>
        /// Holt das Brutto des Arbeiters
        /// </summary>
        /// <returns>Das Brutto des Arbeiters</returns>
        public override float GetBrutto()
        {
            return this.stundenzahl * this.stundenlohn;
        }
    }
}
