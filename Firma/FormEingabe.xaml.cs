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
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IObserver
    {
        /// <summary>
        /// Das Singleton Objekt
        /// </summary>
        private static MainWindow singleton = null;

        /// <summary>
        /// Eine Referenz auf die Firma
        /// </summary>
        private FirmaSubject firma = null;

        /// <summary>
        /// Initialisiert eine neue Instanz der MainWindow Klasse
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        private MainWindow(FirmaSubject firma)
        {
            this.InitializeComponent();

            this.firma = firma;
        }

        /// <summary>
        /// Holt das Singleton Objekt
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        /// <returns>Die Singleton Instanz</returns>
        public static MainWindow GetWindow(FirmaSubject firma)
        {
            if (singleton == null)
            {
                singleton = new MainWindow(firma);
            }

            return singleton;
        }

        /// <summary>
        /// Aktualisiert das Fenster
        /// </summary>
        public void Update()
        {
            // Nichts geschieht
        }

        /// <summary>
        /// Eventhandler für wenn der "Hinzufügen" Knopf gedrückt wurde
        /// </summary>
        /// <param name="sender">Der Sender</param>
        /// <param name="e">Die Argumente</param>
        private void BTNAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mitarbeiter newMitarbeiter = null;

                if (this.tabAngestellter.IsSelected)
                {
                    newMitarbeiter = new Angestellter(txbAngestellterVorname.Text, txbAngestellterName.Text, float.Parse(txbAngestellterBruttogehalt.Text));
                }
                else if (this.tabArbeiter.IsSelected)
                {
                    newMitarbeiter = new Arbeiter(txbArbeiterVorname.Text, txbArbeiterName.Text, int.Parse(txbArbeiterStundenanzahl.Text), float.Parse(txbArbeiterStundenlohn.Text));
                }

                this.firma.ListMitarbeiter.Add(newMitarbeiter);
                this.firma.Notify();

                MessageBox.Show("Mitarbeiter hinzugefügt", "Erfolg", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ungültige Eingabe", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Der Eventhandler für wenn der "Beenden" Knopf gedrückt wurde
        /// </summary>
        /// <param name="sender">Der Sender</param>
        /// <param name="e">Die Argumente</param>
        private void BTNExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
