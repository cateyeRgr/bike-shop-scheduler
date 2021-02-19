﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
        //private ICollectionView CollectionView;
        private TerminerstellungEntities Context = new TerminerstellungEntities();
        List<String> myDataList = null;
        int rbIsChecked = 0;
        int dauerTermin = 2;

        public MainWindow()
        {
            InitializeComponent();
            //Markiert nächsten Tag als Voreinstellung für neuen Termin
            CalendarT.SelectedDate = DateTime.Now.AddDays(1);
            //Vorauswahl ComboBoxen: erstes Element
            comboBoxKunde.SelectedIndex = 0;
            comboBoxMitarbeiter.SelectedIndex = 0;

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

                var queryS = from s in db.Staff
                             orderby s.LastName
                             select s;


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
            using (TerminerstellungEntities db = new TerminerstellungEntities())
            {
                //var list = CollectionView.Cast<Customer>();
                //string formatted;
                DateTime dateAndTime;

                //Kundennachamen aus ComboBox in CustomerDB suchen und ID liefern
                string comboBoxString = comboBoxKunde.SelectedValue.ToString();
                string[] searchTrim = comboBoxString.Split(' ');
                string searchString = searchTrim[0];

                //int customerID = list.FirstOrDefault(x => x.LastName.Equals(searchString)).GetHashCode();


                //Ausgewähltes Datum des DatePickers in SQL-DateTime konvertieren
                DateTime? selectedDate = CalendarT.SelectedDate;
                string calendarDate = CalendarT.SelectedDate.Value.ToString();
                DateTime date = DateTime.Parse(calendarDate);
                TimeSpan time = TimeSpan.Parse(TbUhrzeit.Text);
                dateAndTime = date + time;

                // Anlegen eines neuen Objekts.
                Appointment a = new Appointment
                {
                    Date = dateAndTime,
                    //Date = Convert.ToDateTime("2021-03-24 00:00:00.000"),
                    Length = dauerTermin,
                    AppointmentPrice = decimal.Parse(TbPreis.Text),
                    //CustomerID = 10,
                    WorkshopID = 1
                };

                //Hinzufügen des neuen Objekts zum Kontext.
                db.Appointment.Add(a);
                //Übertragen der Änderungen an die Datenbank.
                db.SaveChanges();
                TerminSuchen.Focus();
            };

            //using (TerminerstellungEntities db = new TerminerstellungEntities())
            //{
            //    Bike b = new Bike { };
            //    AppointmentStaff as = new AppointmentStaff
            //    {

            //    }
            //}


        }

        //Leeren der gefüllten Felder im Terminplanungs-Tab
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            //TbUhrzeit.ClearValue(ContentProperty);
            TbUhrzeit.Text = "";
            TbPreis.Text = "";
            comboBoxKunde.SelectedIndex = 0;
            comboBoxMitarbeiter.SelectedIndex = 0;

        }

        //Wechseln zum Terminplanungs-Tab
        private void BtnTerminAendern_Click(object sender, RoutedEventArgs e)
        {
            Terminplanen.Focus();
        }

        //Löschen eines Termins im Terminsuchen-Tab
        private void BtnTerminLoeschen_Click(object sender, RoutedEventArgs e)
        {
            //ToDO
        }

        private void BtnSpeichernKundeNeu_Click(object sender, RoutedEventArgs e)
        {

            using (TerminerstellungEntities db = new TerminerstellungEntities())
            {
                Customer c = new Customer
                {
                    LastName = TbKundeNeuVorName.Text,
                    FirstName = TbKundeNeuName.Text,
                    Postleitzahl = int.Parse(TbKundeNeuPLZ.Text),
                    Ort = TbKundeNeuOrt.Text,
                    Straße = TbKundeNeuStrasse.Text,
                    Hausnummer = TbKundeNeuHNr.Text,
                };

                db.Customer.Add(c);
                db.SaveChanges();
            }
            Terminplanen.Focus();
        }

        private void BtnClearKundeNeu_Click(object sender, RoutedEventArgs e)
        {
            TbKundeNeuVorName.Text = "";
            TbKundeNeuName.Text = "";
            TbKundeNeuPLZ.Text = "";
            TbKundeNeuOrt.Text = "";
            TbKundeNeuStrasse.Text = "";
            TbKundeNeuHNr.Text = "";
        }

        private void CbMANeuVor_Click(object sender, RoutedEventArgs e)
        {
            rbIsChecked = 1;
        }

        private void BtnSpeichernMANeu_Click(object sender, RoutedEventArgs e)
        {
            using (TerminerstellungEntities db = new TerminerstellungEntities())
            {
                //checked = CbMANeuVor.IsChecked ? 1 : 0;
                //Supervisor = int.Parse((CbMANeuVor.IsChecked?? false )? 1:0)

                Staff s = new Staff
                {
                    LastName = TbMANeuVorName.Text,
                    FirstName = TbMANeuName.Text,
                    Wage = decimal.Parse(TbMANeuGehalt.Text),
                    Hours = int.Parse(TbMANeuStunden.Text),
                    Supervisor = rbIsChecked
                };

                db.Staff.Add(s);
                db.SaveChanges();
            }
            Terminplanen.Focus();
        }


        private void BtnClearMANeu_Click(object sender, RoutedEventArgs e)
        {
            TbMANeuVorName.Text = "";
            TbMANeuName.Text = "";
            TbMANeuGehalt.Text = "";
            TbMANeuStunden.Text = "";
            CbMANeuVor.IsChecked = false;
        }

        //Prüfen der Textboxen auf korrekte Eingabe (Buchstaben oder Ziffern)
        private void TbUhrzeit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]{2}:[0-9]{2}");
            if (regex.IsMatch(TbUhrzeit.Text))
            {
                MessageBox.Show("Bitte geben Sie eine Uhrzeit im Format hh:mm ohne Leerzeichen ein.");
            }
        }

        private void TbPreis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(TbPreis.Text))
            {
                MessageBox.Show("Bitte geben Sie Ziffern ohne Leerzeichen ein.");
            }
        }

        private void TbKundeNeuName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(TbKundeNeuName.Text))
            {
                MessageBox.Show("Bitte geben Sie Buchstaben ohne Leerzeichen ein.");
            }
        }

        private void TbKundeNeuVorName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(TbKundeNeuVorName.Text))
            {
                MessageBox.Show("Bitte geben Sie Buchstaben ohne Leerzeichen ein.");
            }
        }

        private void TbKundeNeuStrasse_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(TbKundeNeuStrasse.Text))
            {
                MessageBox.Show("Bitte geben Sie Buchstaben ohne Leerzeichen ein.");
            }
        }

        private void TbKundeNeuHNr_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Zahlen und Buchstaben möglich, z. B. Hausnummer 24a; längere Hausnummern möglich
            Regex regex = new Regex("^\\d{5} [a-z]?");
            if (regex.IsMatch(TbKundeNeuPLZ.Text))
            {
                MessageBox.Show("Bitte geben Sie maximal 5 Ziffern und einen Buchstaben ohne Leerzeichen ein.");
            }
        }

        private void TbKundeNeuPLZ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^\\d{5}");
            if (regex.IsMatch(TbKundeNeuPLZ.Text))
            {
                MessageBox.Show("Bitte geben Sie maximal 5 Ziffern ohne Leerzeichen ein.");
            }
        }

        private void TbKundeNeuOrt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(TbKundeNeuOrt.Text))
            {
                MessageBox.Show("Bitte geben Sie Buchstaben ohne Leerzeichen ein.");
            }
        }

        private void TbMANeuName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(TbMANeuName.Text))
            {
                MessageBox.Show("Bitte geben Sie Buchstaben ohne Leerzeichen ein.");
            }
        }

        private void TbMANeuVorName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(TbMANeuVorName.Text))
            {
                MessageBox.Show("Bitte geben Sie Buchstaben ohne Leerzeichen ein.");
            }
        }

        private void TbMANeuGehalt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(TbMANeuGehalt.Text))
            {
                MessageBox.Show("Bitte geben Sie Ziffern ohne Leerzeichen ein.");
            }
        }

        private void TbMANeuStunden_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(TbMANeuStunden.Text))
            {
                MessageBox.Show("Bitte geben Sie Ziffern ohne Leerzeichen ein.");
            }
        }
    }
}
