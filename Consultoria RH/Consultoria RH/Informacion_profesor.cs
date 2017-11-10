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
    public partial class Informacion_profesor : Form
    {
        basedeDatos query = new basedeDatos();
        string nombre;
        public Informacion_profesor(string nom)
        {
            nombre = nom;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Informacion_profesor_Load(object sender, EventArgs e)
        {
            //List<string> res = new List<string>();
            query.make_query("SELECT *" + 
                "FROM(actividadesComplementarias INNER JOIN respuestasRH ON actividadesComplementarias.[ID de respuesta] = respuestasRH.[ID de respuesta])" +
                "WHERE(respuestasRH.[Nombre completo] LIKE '%" + nombre +"%')");

            DataTable tbl = query.table();

            foreach (DataRow row in query.table().Rows)
            {
                richTextBox1.Text = row["Nombre completo"].ToString();
                richTextBox2.Text = row["Tipo Identificacion"].ToString();
                richTextBox3.Text = row["numero identificacion"].ToString();
                richTextBox4.Text = row["numero pasaporte"].ToString();
                richTextBox5.Text = row["pais de procedencia"].ToString();
                richTextBox6.Text = row["pueto actual"].ToString();
                richTextBox7.Text = row["departamento o escuela"].ToString();
                richTextBox8.Text = row["cursos que impartiria"].ToString();
                richTextBox9.Text = row["regimen de pension"].ToString();
                richTextBox10.Text = row["cancelado cuotas"].ToString();
                richTextBox11.Text = row["numero de cuotas canceladas"].ToString();
                richTextBox12.Text = row["edad para pensionarse"].ToString();
                richTextBox13.Text = row["cursos de interes CEDA"].ToString();
                richTextBox14.Text = row["estudios de posgrado obtenidos"].ToString();
                //res.Add(nombre);
            }
            //listBox1.DataSource = res;
        }
    }
}
