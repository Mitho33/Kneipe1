using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kneipe
{
    class Speisekarte
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;

        public DataTable Dt
        {
            get { return dt; }
        }

        public DataRow Dr
        {
            get { return dr; }
        }

        public Speisekarte()
        {
            dt = new DataTable();

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Artikel";
            dc.ReadOnly = true;
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.Int32");
            dc.ColumnName = "Preis";
            dc.ReadOnly = true;
            dt.Columns.Add(dc);

            dr = dt.NewRow();
            dr["Artikel"] = Preisliste.bezeichnerEssen1;
            dr["Preis"] = Preisliste.preisEssen1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Artikel"] = Preisliste.bezeichnerGetränk1;
            dr["Preis"] = Preisliste.preisGetränk1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Artikel"] = Preisliste.bezeichnerEssen2;
            dr["Preis"] = Preisliste.preisEssen2;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Artikel"] = Preisliste.bezeichnerGetränk2;
            dr["Preis"] = Preisliste.preisGetränk2;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Artikel"] = Preisliste.bezeichnerGetränk3;
            dr["Preis"] = Preisliste.preisGetränk3;
            dt.Rows.Add(dr);
        }
    }
}
