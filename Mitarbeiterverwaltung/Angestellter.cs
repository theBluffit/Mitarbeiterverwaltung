namespace Mitarbeiterverwaltung
{
    /// <summary>
    /// Stellt einen Angestellten da
    /// </summary>
    public class Angestellter : Mitarbeiter
    {
        /// <summary>
        /// Der Bruttogehalt
        /// </summary>
        private float bruttogehalt = 0;

        /// <summary>
        /// Initialisiert eine neue Instanz der Angestellter Klasse
        /// </summary>
        /// <param name="vorname">Der Vorname des Angestellten</param>
        /// <param name="nachname">Der Nachname des Angestellten</param>
        /// <param name="bruttogehalt">Der Bruttogehalt des Angestellten</param>
        public Angestellter(string vorname, string nachname, float bruttogehalt) : base(vorname, nachname)
        {
            this.Bruttogehalt = bruttogehalt;
        }

        /// <summary>
        /// Holt oder setzt den Bruttogehalt
        /// </summary>
        public float Bruttogehalt
        {
            get
            {
                return this.bruttogehalt;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException();
                }

                this.bruttogehalt = value;
            }
        }

        /// <summary>
        /// Holt die Details des Angestellten
        /// </summary>
        /// <returns>String der die Details beinhält</returns>
        public override string GetDetails()
        {
            return this.Vorname + " " + this.Nachname + " | Bruttogehalt: " + this.bruttogehalt;
        }

        /// <summary>
        /// Holt den Brutto des Angestellten
        /// </summary>
        /// <returns>Der Brutto des Angestellten</returns>
        public override float GetBrutto()
        {
            return this.bruttogehalt;
        }
    }
}