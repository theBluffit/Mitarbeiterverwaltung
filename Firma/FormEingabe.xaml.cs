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
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Das Singleton Objekt
        /// </summary>
        static private MainWindow singleton = null;

        /// <summary>
        /// Eine Referenz auf die Firma
        /// </summary>
        private Firma firma = null;

        /// <summary>
        /// Initialisiert eine neue Instanz der MainWindow Klasse
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        private MainWindow(Firma firma)
        {
            this.InitializeComponent();

            this.firma = firma;
        }

        /// <summary>
        /// Holt das Singleton Objekt
        /// </summary>
        /// <param name="firma">Referenz auf die Firma</param>
        /// <returns>Die Singleton Instanz</returns>
        static public MainWindow GetWindow(Firma firma)
        {
            if (singleton == null)
            {
                singleton = new MainWindow(firma);
            }

            return singleton;
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
                this.firma.UpdateWindows();

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
