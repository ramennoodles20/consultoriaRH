using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Consultoria_RH
{
    class basedeDatos
    {
        static string currentDir = Environment.CurrentDirectory;
        string path = currentDir+ "\\..\\..\\bd\\BDRH.mdb"; 

        string provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        string connString;
        OleDbConnection myConnection;
        DataTable userTables;

        DataTable tableResults = new DataTable();

        public basedeDatos()
        {
            this.connString = provider + path;
            this.myConnection = new OleDbConnection(connString);
        }

        public DataTable table()
        {
            return tableResults;
        }

        public void make_query(string query)
        {
            using (myConnection)
            {
                myConnection.ConnectionString = connString;
                myConnection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = new OleDbCommand(query, myConnection);
                tableResults = new DataTable();
                adapter.Fill(tableResults);
                myConnection.Close();
            }
        }
    }
}
