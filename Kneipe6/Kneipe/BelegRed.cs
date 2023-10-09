using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kneipe
{
    class BelegRed : Beleg
    {

        public BelegRed(): base()
            {
            steuersatz = 5;
        }

        public override double Berechnen(double d)
        {
            return base.Berechnen(d);//durch Steuersatz verändert
        }
    }
}
