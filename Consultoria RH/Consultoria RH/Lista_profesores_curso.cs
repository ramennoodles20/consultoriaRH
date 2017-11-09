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
        }
    }
}
