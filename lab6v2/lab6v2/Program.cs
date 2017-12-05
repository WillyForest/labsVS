using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6v2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet d = new DataSet();
            DataTable dt = new DataTable();
            d.Tables.Add(dt);
            DataColumn dc1 = new DataColumn("height", System.Type.GetType("System.Int32"));
            DataColumn dc2 = new DataColumn("name", System.Type.GetType("System.String"));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            DataRow dr = dt.NewRow();
            dr["height"] = 180;
            dr["name"] = "Ivan";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["height"] = 160;
            dr["name"] = "Petr";
            dt.Rows.Add(dr);
        }
    }
}
