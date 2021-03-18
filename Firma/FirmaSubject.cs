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
    public class FirmaSubject : Subject
    {
        /// <summary>
        /// Die Liste der Mitarbeiter
        /// </summary>
        private List<Mitarbeiter> listMitarbeiter = new List<Mitarbeiter>();

        /// <summary>
        /// Holt oder setzt die Liste der Mitarbeiter
        /// </summary>
        public List<Mitarbeiter> ListMitarbeiter
        {
            get { return this.listMitarbeiter; }
            set { this.listMitarbeiter = value; }
        }
    }
}
