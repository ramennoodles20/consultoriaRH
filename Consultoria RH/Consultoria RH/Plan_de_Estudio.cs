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
    public partial class Plan_de_Estudio : Form
    {
        public Plan_de_Estudio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_profesores_carrera lista_profes = new Lista_profesores_carrera();
            lista_profes.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ingles basico
            Lista_profesores_curso lista = new Lista_profesores_curso("CI0202");
            lista.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //mate general
            Lista_profesores_curso lista = new Lista_profesores_curso("MA0101");
            lista.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //comunicacion tecnica
            Lista_profesores_curso lista = new Lista_profesores_curso("CI1403");
            lista.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //mate discreta
            Lista_profesores_curso lista = new Lista_profesores_curso("MA1403");
            lista.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cultural 1
            Lista_profesores_curso lista = new Lista_profesores_curso("SE1100");
            lista.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //toeria de las organizaciones y sus procesos
            Lista_profesores_curso lista = new Lista_profesores_curso("TI1100");
            lista.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //informacion contable 1
            Lista_profesores_curso lista = new Lista_profesores_curso("TI1101");
            lista.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //introduccion a la programacion
            Lista_profesores_curso lista = new Lista_profesores_curso("TI1400");
            lista.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //tallr de programacion
            Lista_profesores_curso lista = new Lista_profesores_curso("TI1401");
            lista.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //centros de formacion humanistica
            Lista_profesores_curso lista = new Lista_profesores_curso("FH1000");
            lista.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //calculo
            Lista_profesores_curso lista = new Lista_profesores_curso("MA1404");
            lista.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //actividad deportiva 1
            Lista_profesores_curso lista = new Lista_profesores_curso("SE1200");
            lista.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //informacion contable 2
            Lista_profesores_curso lista = new Lista_profesores_curso("TI2102");
            lista.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //algoritmos y estructuras de datos
            Lista_profesores_curso lista = new Lista_profesores_curso("TI2402");
            lista.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //organizacion y arquitectura de computadoras
            Lista_profesores_curso lista = new Lista_profesores_curso("TI2403");
            lista.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //administracion de proyectos 1
            Lista_profesores_curso lista = new Lista_profesores_curso("TI2800");
            lista.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //ingles 1 (ati)
            Lista_profesores_curso lista = new Lista_profesores_curso("CI3400");
            lista.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //algebra lineal para computacion
            Lista_profesores_curso lista = new Lista_profesores_curso("MA2405");
            lista.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //actividad deportiva 1
            Lista_profesores_curso lista = new Lista_profesores_curso("SE1400");
            lista.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //costos en ambientes informaticos
            Lista_profesores_curso lista = new Lista_profesores_curso("TI3103");
            lista.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //lenguajes de programacion
            Lista_profesores_curso lista = new Lista_profesores_curso("TI3404");
            lista.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //bases de datos
            Lista_profesores_curso lista = new Lista_profesores_curso("TI3600");
            lista.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //administracion de proyectos 2
            Lista_profesores_curso lista = new Lista_profesores_curso("TI3801");
            lista.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //ingles 2 (ati)
            Lista_profesores_curso lista = new Lista_profesores_curso("CI4401");
            lista.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //probabilidades
            Lista_profesores_curso lista = new Lista_profesores_curso("MA2404");
            lista.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //planificacion y presupuesto
            Lista_profesores_curso lista = new Lista_profesores_curso("TI4101");
            lista.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //economia
            Lista_profesores_curso lista = new Lista_profesores_curso("TI4200");
            lista.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //ingenieria de requerimientos
            Lista_profesores_curso lista = new Lista_profesores_curso("TI4500");
            lista.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //bases de datos avanzadas
            Lista_profesores_curso lista = new Lista_profesores_curso("TI4601");
            lista.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //seminario de estudios filosoficos historicos
            Lista_profesores_curso lista = new Lista_profesores_curso("CS3401");
            lista.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //estadistica
            Lista_profesores_curso lista = new Lista_profesores_curso("MA3405");
            lista.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //gestion y toma de decisiones financieras
            Lista_profesores_curso lista = new Lista_profesores_curso("TI5100");
            lista.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //comportamiento organizacional y gestion de cambios
            Lista_profesores_curso lista = new Lista_profesores_curso("TI5300");
            lista.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //diseno de software
            Lista_profesores_curso lista = new Lista_profesores_curso("TI5501");
            lista.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //infraestructura tecnologica 1
            Lista_profesores_curso lista = new Lista_profesores_curso("TI5701");
            lista.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //seminario de estudios costarricenses
            Lista_profesores_curso lista = new Lista_profesores_curso("CS4402");
            lista.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //mercadeo de productos de alta tecnologia
            Lista_profesores_curso lista = new Lista_profesores_curso("TI6106");
            lista.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //produccion logistica y calidad
            Lista_profesores_curso lista = new Lista_profesores_curso("TI6108");
            lista.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //especificacion de software
            Lista_profesores_curso lista = new Lista_profesores_curso("TI6502");
            lista.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //infraestructura tecnologica 2
            Lista_profesores_curso lista = new Lista_profesores_curso("TI6702");
            lista.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //inteligencia de negocios
            Lista_profesores_curso lista = new Lista_profesores_curso("TI6900");
            lista.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //legislacion mercantil, laboral y tributaria
            Lista_profesores_curso lista = new Lista_profesores_curso("CS4404");
            lista.Show();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //electiva 1
            Lista_profesores_curso lista = new Lista_profesores_curso("TI5000");
            lista.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //gestion de recursos humanos
            Lista_profesores_curso lista = new Lista_profesores_curso("TI7102");
            lista.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //arquitectura de aplicaciones
            Lista_profesores_curso lista = new Lista_profesores_curso("TI7503");
            lista.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //modelo de toma de decisiones
            Lista_profesores_curso lista = new Lista_profesores_curso("TI7802");
            lista.Show();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //negocios electronicos
            Lista_profesores_curso lista = new Lista_profesores_curso("TI7901");
            lista.Show();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //formulacion y evaluacion de proyectos de ti
            Lista_profesores_curso lista = new Lista_profesores_curso("TI8109");
            lista.Show();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //adquisicion de ti
            Lista_profesores_curso lista = new Lista_profesores_curso("TI8902");
            lista.Show();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //administracion de procesos de negocios
            Lista_profesores_curso lista = new Lista_profesores_curso("TI8904");
            lista.Show();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            //administracion de servicios de tecnologias de informacion 1
            Lista_profesores_curso lista = new Lista_profesores_curso("TI8905");
            lista.Show();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            //computacion y sociedad
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9003");
            lista.Show();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            //auditoria de ti
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9805");
            lista.Show();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            //electiva 2
            Lista_profesores_curso lista = new Lista_profesores_curso("TI6000");
            lista.Show();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            //administracion de servicios de tecnologias de informacion 2
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9004");
            lista.Show();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            //espiritu emprendedor y creacion de empresas
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9005");
            lista.Show();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //consultoria de tecnologias de informacion
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9006");
            lista.Show();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            //planificacion y estrategias de ti
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9804");
            lista.Show();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            //sistemas de informacion empresarial
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9905");
            lista.Show();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            //trabajo final de graduacion
            Lista_profesores_curso lista = new Lista_profesores_curso("TI9000");
            lista.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lista_profesores_carrera lista_profes = new Lista_profesores_carrera();
            lista_profes.Show();
        }

        private void Plan_de_Estudio_Load(object sender, EventArgs e)
        {

        }
    }
}
