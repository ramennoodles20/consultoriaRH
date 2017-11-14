﻿using System.Threading;
using System.Windows.Forms;

namespace Consultoria_RH
{
    public class reportesUsuarios : Form
    {
        private int CW;
        private int CH;
        private int IW;
        private int IH;

        public reportesUsuarios()
        {
             CH = 800;
             CW = 800;
             IH = Height;
             IW = Width;  
        }

        protected string agregarEspacios (string text)
        {
            return text.Replace(", ", "\n");
        }

        protected override void OnResize(System.EventArgs e)
        {
            System.Console.WriteLine("new width " +  Width);
            System.Console.WriteLine("current width " + CW);
            int RW = (Width - CW);
            int RH = (Height - CH);

            foreach (Control control in this.Controls)
            {
                if (control.GetType() != (typeof(Button)))
                {
                    control.Width += RW;
                }
            }
            CW = Width;
            CH = Height;
        }
    }
}