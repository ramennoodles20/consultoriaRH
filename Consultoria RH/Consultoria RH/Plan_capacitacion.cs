using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Consultoria_RH
{
    public partial class Plan_capacitacion : reportesUsuarios
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
            DataTable tbl;
            List<string> no_tienen = new List<string>();

            query.make_query("SELECT [Nombre completo] FROM respuestasRH " +
                "WHERE([requiere actividades para capacitación complementaria] = 'No')");

            tbl = query.table();

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
                no_tienen.Add(row["Nombre completo"].ToString());
            }
            if (no_tienen.Contains(nombre))
            {
                string mensaje = "No posee actividades de capacitación complementarias";

                query.make_query("SELECT [ID de respuesta], [Fecha de envío], [Última página], " +
                    "[Lenguaje inicial], [Fecha de inicio], [Fecha de la última acción], " +
                    "[Nombre completo], [Tipo Identificacion], [numero identificacion], " +
                    "[numero pasaporte], [pais de procedencia], [departamento o escuela], " +
                    "[pueto actual], [area de trabajo], [cursos que impartiria], " +
                    "[regimen de pension], [cancelado cuotas], [numero de cuotas canceladas], " +
                    "[edad para pensionarse], " +
                    "[tiene estudios pregrado], [estudios pregrado obtenidos], " +
                    "[estudios pregrado institucion], [estudios pregrado año], " +
                    "[tiene estudios de posgrado], [estudios de posgrado obtenidos], " +
                    "[estudios de posgrado institucion], [estudios de posgrado año], " +
                    "[interes en cursos CEDA], [cursos de interes CEDA], " +
                    "[periodo para cursar cursos CEDA], [año para cursar cursos CEDA], " +
                    "[requiere actividades para capacitación formal]," +
                    " [actividades que requiere en capacitacion formal], " +
                    "[objetivo de las actividades], [periodo para cursar actividades], " +
                    "[actualizacion que realizaria], [lugar de actualizacion], " +
                    "[tiempo estimado capacitacion], " +
                    "[requiere actividades para capacitación complementaria] " +
                    "FROM   respuestasRH " +
                    "WHERE([Nombre completo] LIKE '%" + nombre + "%')");

                tbl = query.table();

                foreach (DataRow row in query.table().Rows)
                {
                    actividades = agregarEspacios(row["actividades que requiere en capacitacion formal"].ToString());
                    objetivos = agregarEspacios(row["objetivo de las actividades"].ToString());
                    periodo = agregarEspacios(row["periodo para cursar actividades"].ToString());
                    lugar = agregarEspacios(row["lugar de actualizacion"].ToString());
                    actualizacion = agregarEspacios(row["actualizacion que realizaria"].ToString());
                    tiempo = agregarEspacios(row["tiempo estimado capacitacion"].ToString());
                }
                llenar_txt(actividades, objetivos, periodo, lugar, actualizacion, tiempo,
                    mensaje, mensaje, mensaje, mensaje);
            }
            else
            {
                query.make_query("SELECT *" +
               "FROM(actividadesComplementarias INNER JOIN respuestasRH ON actividadesComplementarias.[ID de respuesta] = respuestasRH.[ID de respuesta])" +
               "WHERE(respuestasRH.[Nombre completo] LIKE '%" + nombre + "%')");

                tbl = query.table();

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
                llenar_txt(actividades, objetivos, periodo, lugar, actualizacion, tiempo,
                    String.Join("\n", capacitacion), String.Join("\n", objetivos_estrategicos),
                    String.Join("\n", periodos_actividad), actividades);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportesPDF asd = new reportesPDF();
            asd.reporteCapacitacion(label14.Text, richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text, richTextBox5.Text, richTextBox6.Text, richTextBox7.Text, richTextBox8.Text, richTextBox9.Text, richTextBox10.Text);
            MessageBox.Show("Reporte generado con éxito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void llenar_txt(string m1, string m2, string m3, string m4, string m5, string m6,
            string m7, string m8, string m9, string m10)
        {
            richTextBox1.Text = m1;
            richTextBox2.Text = m2;
            richTextBox3.Text = m3;
            richTextBox4.Text = m4;
            richTextBox5.Text = m5;
            richTextBox6.Text = m6;
            richTextBox7.Text = m7;
            richTextBox8.Text = m8;
            richTextBox9.Text = m9;
            richTextBox10.Text = m10;
        }
    }
}
