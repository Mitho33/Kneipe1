using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Threading;//dispatchtertimer

namespace Kneipe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(Timer_Tick);//Event Handler sorgt dafür das jedes Ereignis von MainWindow bei jedem Tick die Funktion neu ausführt
            timer.Interval = TimeSpan.FromSeconds(0.1);//Intervalldauer
            timer.Tick += Timer_Tick; // Methode für den Timer wird für die Bombe benötigt
        }

        Speisekarte speisekarte = new Speisekarte();
        int x;
        int z = 0;
        int y = 0;
        int r;
        double w;
        BelegWindow belegWindow;
        Beleg beleg;
        BelegRed belegRed;
        DispatcherTimer timer = new DispatcherTimer();//erst nach dem Konstruktor wird das Objekt  Dispatcher Timer erzeugt, sonst wird unten den timer.Start nicht erkannt
        Logo logo;
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Ticker für Canvas

            logo.Posx = (double)logo.Canvas.GetValue(Canvas.LeftProperty);//Initialisiert Variable
            logo.Posy = (double)logo.Canvas.GetValue(Canvas.TopProperty);
            logo.Canvas.SetValue(Canvas.LeftProperty, logo.Posx - 5);//notwendig zur aktuellen Positionsbestimmung
            logo.Canvas.SetValue(Canvas.TopProperty, logo.Posy);

            if (logo.Posx <= 0)//unten Canvas ist 450 hoch - Höhe Spieler
            {
                logo.Canvas.SetValue(Canvas.LeftProperty, logo.Posx = 750);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            logo = new Logo();
            Hintergrund.Children.Add(logo.Canvas);
            timer.Start();

            DgTisch1.ItemsSource = speisekarte.Dt.DefaultView;


        }

        private void Auswahl(object sender, SelectionChangedEventArgs e)//Ereignishandler  des ersten Grids SelectionChanged
        {
            for (int i = 0; i < DgTisch1.SelectedItems.Count; i++)

            {
                DgTisch1Bestellung.Items.Add(DgTisch1.SelectedItem);//Achtung Items und Item
                                                                    
            }
        }

        private void Rückgängig(object sender, SelectionChangedEventArgs e)
        {
            if (DgTisch1Bestellung.SelectedItems.Count > 0)
            {
                DataRowView dvr = (DataRowView)DgTisch1Bestellung.SelectedItem;
                string rstr = dvr.Row[1].ToString();
                r = Convert.ToInt32(rstr);
                y += r;
                DgTisch1Bestellung.Items.Remove(DgTisch1Bestellung.SelectedItem);             

            }
        }

        private void Abrechnung(object sender, SelectedCellsChangedEventArgs e)
        {
            Berechnung();
        }

        private void Berechnung()
        {

            if (DgTisch1.SelectedItems.Count > 0)
            {
                for (int j = 0; j <= DgTisch1.SelectedItems.Count - 1; j++)
                {

                    DataRowView dv = (DataRowView)DgTisch1.SelectedItem;
                    string str = dv.Row[1].ToString();
                    int x = Convert.ToInt32(str);
                    z += x;
                    
                }
            }
        }    

        private void Rechnung(object sender, RoutedEventArgs e)
        {
            if (RbRg1.IsChecked==true)
            {
                belegWindow = new BelegWindow();
                beleg = new Beleg();
                belegWindow.Show();
                w = z - y;
                belegWindow.LbBetrag.Content = w + " €";
                belegWindow.LbSteuerbetrag.Content = beleg.Berechnen(w).ToString() + " €";
                belegWindow.LbName.Content = beleg.Name;
                belegWindow.LbDatum.Content = beleg.Datum;
                belegWindow.LbBezahlzeit.Content = beleg.BezahlZeit;
                belegWindow.LbSteuersatz.Content = beleg.Steuersatz + " % Mehrwertsteuer";
            }

           else if (RbRg2.IsChecked==true)
            {
                belegWindow = new BelegWindow();
                belegRed = new BelegRed();
                belegWindow.Show();
                w = z - y;
                belegWindow.LbBetrag.Content = w + " €";
                belegWindow.LbSteuerbetrag.Content = belegRed.Berechnen(w).ToString("0.00") + " €";
                belegWindow.LbName.Content = belegRed.Name;
                belegWindow.LbDatum.Content = belegRed.Datum;
                belegWindow.LbBezahlzeit.Content = belegRed.BezahlZeit;
                belegWindow.LbSteuersatz.Content = belegRed.Steuersatz + " % Mehrwertsteuer";
            }

            else
            {
                MessageBox.Show("Bitte Rechungsart auswählen");
            }
            
        }

        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
