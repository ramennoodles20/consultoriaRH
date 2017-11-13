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
    public partial class Plan_capacitacion : Form
    {
        basedeDatos query = new basedeDatos();
        string nombre;
        public Plan_capacitacion(string nom)
        {
            nombre = nom;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Plan_capacitacion_Load(object sender, EventArgs e)
        {
            label14.Text = nombre;
            query.make_query("SELECT *" +
               "FROM(actividadesComplementarias INNER JOIN respuestasRH ON actividadesComplementarias.[ID de respuesta] = respuestasRH.[ID de respuesta])" +
               "WHERE(respuestasRH.[Nombre completo] LIKE '%" + nombre + "%')");

            DataTable tbl = query.table();

            List<string> capacitacion = new List<string>();
            List<string> objetivos_estrategicos = new List<string>();
            List<string> periodos_actividad = new List<string>();

            string actividades = "";
            string objetivos = "";
            string periodo = "";
            string lugar = "";
            string actualizacion = "";
            string tiempo = "";

            foreach (DataRow row in query.table().Rows)
            {
                actividades = row["actividades que requiere en capacitacion formal"].ToString();
                objetivos = row["objetivo de las actividades"].ToString();
                periodo = row["periodo para cursar actividades "].ToString();
                lugar = row["lugar de actualizacion"].ToString();
                actualizacion = row["actualizacion que realizaria"].ToString();
                tiempo = row["tiempo estimado capacitacion"].ToString();
                capacitacion.Add(row["actividades para capacitación complementaria?"].ToString());
                objetivos_estrategicos.Add(row["objetivo estratégico"].ToString());
                periodos_actividad.Add(row["periodo para actividades complementarias"].ToString());
            }
            richTextBox1.Text = actividades;
            richTextBox2.Text = objetivos;
            richTextBox3.Text = periodo;
            richTextBox4.Text = lugar;
            richTextBox5.Text = actualizacion;
            richTextBox6.Text = tiempo;
            //richTextBox7.Text = actividades;
            richTextBox7.Text = String.Join(", ",capacitacion);
            richTextBox8.Text = String.Join(", ",objetivos_estrategicos);
            richTextBox9.Text = String.Join(", ",periodos_actividad);
            richTextBox10.Text = actividades;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 asd = new Class1();
            asd.reporteCapacitacion(label14.Text, richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text, richTextBox5.Text, richTextBox6.Text, richTextBox7.Text, richTextBox8.Text, richTextBox9.Text, richTextBox10.Text);
            MessageBox.Show("Reporte generado con éxito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
