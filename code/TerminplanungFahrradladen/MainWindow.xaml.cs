using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
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

namespace TerminplanungFahrradladen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ICollectionView CollectionView;
        private TerminerstellungEntities Context = new TerminerstellungEntities();
        List<String> myDataList = null;

        public MainWindow()
        {
            InitializeComponent();
            //Markiert nächsten Tag als Voreinstellung für neuen Termin
            CalendarT.SelectedDate = DateTime.Now.AddDays(1);
            //Vorauswahl ComboBoxen: erstes Element
            comboBoxKunde.SelectedIndex = comboBoxKunde.SelectedIndex + 1;
            comboBoxMitarbeiter.SelectedIndex = comboBoxMitarbeiter.SelectedIndex + 1;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Context.Staff.Load();
            //CollectionView = CollectionViewSource.GetDefaultView(Context.Staff.Local);
            //MainGrid.DataContext = CollectionView;

            //Zwei Abfragen, die die ComobBoxen mit Vor- und Nachnamen aus Datenbank füllen
            //Füllen der Mitarbeiter-ComboBox
            using (var db = new TerminerstellungEntities())
            {

                var queryS = from b in db.Staff
                             orderby b.LastName
                             select b;


                foreach (var item in queryS)
                {
                    var icS = item.LastName + " " + item.FirstName;
                    ComboBoxItem itmS = new ComboBoxItem
                    {
                        Content = icS
                    };

                    comboBoxMitarbeiter.Items.Add(itmS);
                }
            }

            //Füllen der Kunden-ComboBox
            using (var dbc = new TerminerstellungEntities())
            {

                var queryC = from c in dbc.Customer
                             orderby c.LastName
                             select c;


                foreach (var item in queryC)
                {
                    var icC = item.LastName + " " + item.FirstName;
                    ComboBoxItem itmC = new ComboBoxItem
                    {
                        Content = icC
                    };

                    comboBoxKunde.Items.Add(itmC);
                }

            }
        }

        //OnClick: neuer Termin wird in DB gespeichert
        private void BtnTerminSpeichern_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new TerminerstellungEntities())
            {
                //var list = CollectionView.Cast<Customer>();
                //string formatted;

                ////Kundennachamen aus ComboBox in CustomerDB suchen und ID liefern
                //String comboBoxString = comboBoxKunde.SelectedValue.ToString();
                //String[] searchTrim = comboBoxString.Split(' ');
                //String searchString = searchTrim[0];
                //int customerID = list.FirstOrDefault(x => x.LastName.Equals(searchString)).GetHashCode();


                //////Ausgewähltes Datum des DatePickers in SQL-DateTime konvertieren
                //DateTime? selectedDate = CalendarT.SelectedDate;
                //if (selectedDate.HasValue)
                //{
                //    formatted = selectedDate.Value.ToString("yyyy--dd--MM", System.Globalization.CultureInfo.InvariantCulture);
                //}

                //// Anlegen eines neuen Objekts.
                //Appointment a = new Appointment
                //{

                ////alternative zum abändern: a.Date = selectedDate.Year + "--"selectedDate.Day + "--" + selectedDate.Month;
                //a.Date = formatted;
                //a.Length = 2;
                //a.AppointmentPrice = 50m;
                //a.CustomerID = customerID;
                //a.WorkshopID = 1;

                // Hinzufügen des neuen Objekts zum Kontext.
                //db.Appointment.Add(a);
                // Übertragen der Änderungen an die Datenbank.
                //db.SaveChanges();
                TerminSuchen.Focus();
            };

        }

        //Leeren der gefüllten Felder im Terminplanungs-Tab
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            comboBoxKunde.ClearValue(ContentProperty);
            TbUhrzeit.Text = "";
            TbPreis.Text = "";
            comboBoxKunde.ClearValue(ContentProperty);


        }

        //Wechseln zum Terminplanungs-Tab
        private void BtnTerminAendern_Click(object sender, RoutedEventArgs e)
        {
            Terminplanen.Focus();
        }

        //Löschen eines Termins im Terminsuchen-Tab
        private void BtnTerminLoeschen_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BtnClearKundeNeu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSpeichernKundeNeu_Click(object sender, RoutedEventArgs e)
        {
          
                using (TerminerstellungEntities db = new TerminerstellungEntities())
                {
                    Customer c = new Customer
                    {
                        LastName = TbKundeNeuVorName.ToString(),
                        FirstName = TbKundeNeuName.ToString(),
                        Postleitzahl = Convert.ToInt32(TbKundeNeuPLZ.ToString()),
                        Ort = TbKundeNeuOrt.ToString(),
                        Straße = TbKundeNeuStrasse.ToString(),
                        Hausnummer = TbKundeNeuHNr.ToString(),
                       
                    };

                    db.Customer.Add(c);
                    db.SaveChanges();
                }

        }
    }
}
