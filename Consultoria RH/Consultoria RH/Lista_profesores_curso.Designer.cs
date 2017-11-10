namespace Consultoria_RH
{
    partial class Lista_profesores_curso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_codigo_curso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(13, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1039, 580);
            this.listBox1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(362, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 130);
            this.button3.TabIndex = 9;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(510, 67);
            this.label15.TabIndex = 12;
            this.label15.Text = "Lista de Profesores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 48);
            this.label13.TabIndex = 13;
            this.label13.Text = "Curso:";
            // 
            // lbl_codigo_curso
            // 
            this.lbl_codigo_curso.AutoSize = true;
            this.lbl_codigo_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_codigo_curso.Location = new System.Drawing.Point(171, 88);
            this.lbl_codigo_curso.Name = "lbl_codigo_curso";
            this.lbl_codigo_curso.Size = new System.Drawing.Size(274, 48);
            this.lbl_codigo_curso.TabIndex = 14;
            this.lbl_codigo_curso.Text = "Codigo Curso";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 743);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 167);
            this.panel1.TabIndex = 15;
            // 
            // Lista_profesores_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 910);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_codigo_curso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBox1);
            this.Name = "Lista_profesores_curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Profesores del Curso";
            this.Load += new System.EventHandler(this.Lista_profesores_curso_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_codigo_curso;
        private System.Windows.Forms.Panel panel1;
    }
}