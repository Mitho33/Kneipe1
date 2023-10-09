using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kneipe
{
    class Beleg
    {
        protected string name;
        protected string datum;
        protected string bezahlZeit;
        protected int steuersatz;
        protected double steuerbetrag;
        protected double gerundeterSteuerbetrag;

        public Beleg()
        {
            name = "Anne Ruhr \n Castrop Rauxel \n alle Preise inkl.\n des gültigen Steuersatzes";
            bezahlZeit = "Uhrzeit: " + DateTime.Now.ToString(" HH:mm:ss");
            datum = "Datum: " + DateTime.Now.ToShortDateString();
            steuersatz = 7;
          
        }

        public virtual double Berechnen(double d)

        {
            steuerbetrag =  d /(100+steuersatz)*steuersatz;
            gerundeterSteuerbetrag = Math.Round(steuerbetrag * 100 )/ 100;//für 2 Kommastellen
            return gerundeterSteuerbetrag;

        }

        public int Steuersatz
        {
            get
            {
                return steuersatz;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }

        }

        public string Datum
        {
            get
            {
                return datum;
            }

        }
        public string BezahlZeit
        {
            get
            {
                return bezahlZeit;
            }
        }

       
    }
}
