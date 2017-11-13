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
    public partial class MallaCurricular : Form
    {
        public MallaCurricular()
        {
            InitializeComponent();
        }


        private void seleccionar_Curso(object sender, EventArgs e)
        {
            Button boton = (sender as Button);
            String tag = boton.Tag.ToString();
            Lista_profesores_curso lista = new Lista_profesores_curso(tag);
            lista.Show();
        }

        private void MallaCurricular_Load(object sender, EventArgs e)
        {
            var Controls = this.tableLayoutPanel1.Controls.Cast<Control>();
            foreach (Control control in Controls)
            {
                if (control.GetType() == (typeof(Button)))
                {
                    control.Click += new EventHandler(seleccionar_Curso);
                }
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Lista_profesores_carrera lista_profes = new Lista_profesores_carrera();
            lista_profes.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
