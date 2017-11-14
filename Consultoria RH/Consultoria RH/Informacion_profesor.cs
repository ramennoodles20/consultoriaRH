using System;
using System.Data;
using System.Windows.Forms;

namespace Consultoria_RH
{
    public partial class Informacion_profesor : reportesUsuarios
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
                "FROM(respuestasRH)" +
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
                richTextBox8.Text = agregarEspacios(row["cursos que impartiria"].ToString());
                richTextBox9.Text = row["regimen de pension"].ToString();
                richTextBox10.Text = row["cancelado cuotas"].ToString();
                richTextBox11.Text = row["numero de cuotas canceladas"].ToString();
                richTextBox12.Text = row["edad para pensionarse"].ToString();
                richTextBox13.Text = agregarEspacios(row["cursos de interes CEDA"].ToString());
                richTextBox14.Text = agregarEspacios(row["estudios de posgrado obtenidos"].ToString());
                //res.Add(nombre);
            }
            //listBox1.DataSource = res;
        }

    private void button1_Click(object sender, EventArgs e)
    {
      reportesPDF asd = new reportesPDF();
      asd.reporteInformacion(richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text, richTextBox5.Text, richTextBox6.Text, richTextBox7.Text, richTextBox8.Text, richTextBox9.Text, richTextBox10.Text, richTextBox11.Text, richTextBox12.Text, richTextBox13.Text, richTextBox14.Text);
      MessageBox.Show("Reporte generado con éxito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
