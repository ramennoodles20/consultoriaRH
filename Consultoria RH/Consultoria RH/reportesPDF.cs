using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Windows.Forms;

namespace Consultoria_RH
{
  class reportesPDF

    {
    public reportesPDF() { }

    public void reporteInformacion(string info1, string info2, string info3, string info4, string info5, string info6, string info7, string info8, string info9, string info10, string info11, string info12, string info13, string info14)
    {
      // create filestream object
      SaveFileDialog guardarArchivo = new SaveFileDialog();
      guardarArchivo.Filter = "PDF|*.pdf";
      guardarArchivo.Title = "Guardar Reporte";
      guardarArchivo.FileName = "Reporte - " + info1 + "";
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                var fs = (System.IO.FileStream)guardarArchivo.OpenFile();
                var doc = new Document();

                using (var writer = PdfWriter.GetInstance(doc, fs))
                {
                    Image image = Image.GetInstance(Properties.Resources.ATI,
                                                    System.Drawing.Imaging.ImageFormat.Png);

                    image.Alignment = Element.ALIGN_CENTER;
                    image.ScaleToFit(300f, 450f);

                    doc.Open();
                    doc.Add(image);

                    PdfPTable tabla = new PdfPTable(new float[] {200f,400f});
                    PdfPCell celdas = new PdfPCell();
                    celdas.Phrase = new Phrase("Información del Profesor", new Font(Font.FontFamily.TIMES_ROMAN, 12, 1, BaseColor.BLACK));
                    celdas.Colspan = 2;
                    celdas.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabla.AddCell(celdas);
                    tabla.AddCell(new PdfPCell(new Phrase("Nombre", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info1, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Tipo de Identificación", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info2, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Cédula", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info3, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Pasaporte", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info4, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("País de Origen", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info5, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Puestos Actuales", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info6, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Departamento o Escuela", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info7, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Posibles Cursos", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info8, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Régimen de Pensión", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info9, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Conocimiento de coutas canceladas", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info10, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Coutas canceladas", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info11, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Edad de pensión", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info12, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Cursos de interés CEDA", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info13, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Estudios de Posgrado", new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info14, new Font(Font.FontFamily.TIMES_ROMAN, 11, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });

                    doc.Add(tabla);
                    doc.Close();
                }
                MessageBox.Show("Reporte generado con éxito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha cancelado el reporte", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }


        public void reporteCapacitacion(string nombre, string info1, string info2, string info3, string info4, string info5, string info6, string info7, string info8, string info9, string info10)
        {
            // create filestream object
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "PDF|*.pdf";
            guardarArchivo.Title = "Guardar Reporte";
            guardarArchivo.FileName = "Plan Capacitación - " + nombre + "";
            if (guardarArchivo.ShowDialog() == DialogResult.OK) {
                var fs = (System.IO.FileStream)guardarArchivo.OpenFile();
                var doc = new Document();

                using (var writer = PdfWriter.GetInstance(doc, fs))
                {
                    string currentDir = Environment.CurrentDirectory;
                    string imagePath = currentDir + "\\..\\..\\img\\ATI.PNG";

                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);

                    image.Alignment = Element.ALIGN_CENTER;
                    image.ScaleToFit(300f, 450f);

                    doc.Open();
                    doc.SetMargins(0f, 0f, 10f, 0f);
                    doc.Add(image);

                    PdfPTable tabla = new PdfPTable(2);
                    float[] widths = new float[] { 1f, 2f };
                    tabla.SetWidths(widths);
                    PdfPCell celdas = new PdfPCell();
                    celdas.Phrase = new Phrase("Plan Capacitación", new Font(Font.FontFamily.TIMES_ROMAN, 12, 1, BaseColor.BLACK));
                    celdas.Colspan = 2;
                    celdas.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabla.AddCell(celdas);
                    tabla.AddCell(new PdfPCell(new Phrase("Actividades", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info1, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Objetivos", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info2, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Periodo realización", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info3, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Lugar", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info4, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Tipo de actualización", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info5, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });
                    tabla.AddCell(new PdfPCell(new Phrase("Tiempo capacitación", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                    tabla.AddCell(new PdfPCell(new Phrase(info6, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_JUSTIFIED, Padding = 5 });

                    if (nombre.Equals("Jenny Cortés Ugalde")) {
                        tabla.AddCell(new PdfPCell(new Phrase("Actividades complementarias", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                        tabla.AddCell(new PdfPCell(new Phrase(info7, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                        tabla.AddCell(new PdfPCell(new Phrase("Objetivos", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                        tabla.AddCell(new PdfPCell(new Phrase(info8, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                        tabla.AddCell(new PdfPCell(new Phrase("Periodo realización", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                        tabla.AddCell(new PdfPCell(new Phrase(info9, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                        tabla.AddCell(new PdfPCell(new Phrase("Área de trabajo", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                        tabla.AddCell(new PdfPCell(new Phrase(info10, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                    }

                    doc.Add(tabla);

                    if (!nombre.Equals("Jenny Cortés Ugalde"))
                    {
                        PdfPTable tablaAct = new PdfPTable(4);
                        float[] widthsAct = new float[] { 1f, 2f, 1f, 1f };
                        tablaAct.SetWidths(widthsAct);
                        PdfPCell celdasAct = new PdfPCell();
                        celdas.Phrase = new Phrase("Plan Capacitación-Adicional", new Font(Font.FontFamily.TIMES_ROMAN, 12, 1, BaseColor.BLACK));
                        celdasAct.Colspan = 4;
                        celdasAct.HorizontalAlignment = Element.ALIGN_CENTER;
                        tablaAct.AddCell(celdasAct);
                        tablaAct.AddCell(new PdfPCell(new Phrase("Actividades complementarias", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                        tablaAct.AddCell(new PdfPCell(new Phrase("Objetivos", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                        tablaAct.AddCell(new PdfPCell(new Phrase("Periodo realización", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });
                        tablaAct.AddCell(new PdfPCell(new Phrase("Área de trabajo", new Font(Font.FontFamily.TIMES_ROMAN, 10, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) });

                        String[] actividades = info7.Split('\n');
                        String[] objetivos = info8.Split('\n');
                        String[] periodo = info9.Split('\n');

                        int contador = 0;
                        foreach (string act in actividades)
                        {
                            tablaAct.AddCell(new PdfPCell(new Phrase(actividades[contador], new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                            tablaAct.AddCell(new PdfPCell(new Phrase(objetivos[contador], new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                            tablaAct.AddCell(new PdfPCell(new Phrase(periodo[contador], new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                            tablaAct.AddCell(new PdfPCell(new Phrase(info10, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                            contador += 1;
                        }
                        doc.Add(tablaAct);
                    }
                    
                    
                    doc.Close();
                }
                MessageBox.Show("Reporte generado con éxito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha cancelado el reporte", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
