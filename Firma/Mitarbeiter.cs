namespace Vererbung
{
    /// <summary>
    /// Die Basisklasse für einen Mitarbeiter
    /// </summary>
    public abstract class Mitarbeiter
    {
        /// <summary>
        /// Der Vorname eines Mitarbeiters
        /// </summary>
        private string vorname = string.Empty;

        /// <summary>
        /// Der Nachname eines Mitarbeiters
        /// </summary>
        private string nachname = string.Empty;

        /// <summary>
        /// Initialisiert eine neue Instanz der Mitarbeiter Klasse
        /// </summary>
        /// <param name="vorname">Der Vorname des Mitarbeiters</param>
        /// <param name="nachname">Der Nachname des Mitarbeiters</param>
        public Mitarbeiter(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        /// <summary>
        /// Holt den Vornamen
        /// </summary>
        public string Vorname
        {
            get { return this.vorname; }
            private set { this.vorname = value; }
        }

        /// <summary>
        /// Holt den Nachnamen
        /// </summary>
        public string Nachname
        {
            get { return this.nachname; }
            private set { this.nachname = value; }
        }

        /// <summary>
        /// Holt die Details des Mitarbeiters
        /// </summary>
        /// <returns>Die Details des Mitarbeiters</returns>
        public abstract string GetDetails();

        /// <summary>
        /// Holt das Brutto des Mitarbeiters
        /// </summary>
        /// <returns>Das Brutto des Mitarbeiters</returns>
        public abstract float GetBrutto();
    }
}
