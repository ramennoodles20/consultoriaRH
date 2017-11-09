using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultoria_RH
{
    public partial class Lista_profesores_carrera : Form
    {
        basedeDatos query = new basedeDatos();
        public Lista_profesores_carrera()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plan_capacitacion plan = new Plan_capacitacion();
            plan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacion_profesor info_profe = new Informacion_profesor();
            info_profe.Show();
        }

        private void Lista_profesores_carrera_Load(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            query.make_query("SELECT respuestasRH.[Nombre completo] " +
                "FROM(actividadesComplementarias INNER JOIN respuestasRH " +
                "ON actividadesComplementarias.[ID de respuesta] = respuestasRH.[ID de respuesta])" + 
                "Group by [Nombre completo]");

            DataTable tbl = query.table();

            foreach (DataRow row in query.table().Rows)
            {
                string nombre = row["Nombre completo"].ToString();
                res.Add(nombre);
            }
            listBox1.DataSource = res;
        }
    }
}
