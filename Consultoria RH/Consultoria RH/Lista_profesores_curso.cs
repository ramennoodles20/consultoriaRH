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
    public partial class Lista_profesores_curso : Form
    {
        String codigo;
        basedeDatos query = new basedeDatos();
        public Lista_profesores_curso(String cod)
        {
            codigo = cod;
            InitializeComponent();
            lbl_codigo_curso.Text = codigo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Lista_profesores_curso_Load(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            query.make_query("SELECT        respuestasRH.[Nombre completo]" + 
                               "FROM(actividadesComplementarias INNER JOIN respuestasRH ON actividadesComplementarias.[ID de respuesta] = respuestasRH.[ID de respuesta])" +
                               "WHERE(respuestasRH.[cursos que impartiria] LIKE '%" + codigo + "%')" + 
                               "GROUP BY respuestasRH.[Nombre completo]");

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
