using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Consultoria_RH
{
    class basedeDatos
    {
        string path = Properties.Settings.Default.path;
        string provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        string connString;
        OleDbConnection myConnection;

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
                try
                {
                    myConnection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = new OleDbCommand(query, myConnection);
                    tableResults = new DataTable();
                    adapter.Fill(tableResults);
                    myConnection.Close();
                }
                catch
                {
                    buscarBD();
                }
            }
        }

        private void buscarBD()
        {
            MessageBox.Show("Por favor seleccione la base de Datos correspondiente",
                "No se ha detectado la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.path = dialog.FileName;
                Properties.Settings.Default.Save();
            }
        }
    }
}
