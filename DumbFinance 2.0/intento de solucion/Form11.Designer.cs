using System;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    partial class Form11
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AtrasFecha;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void ExportarPDF()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Gastos.pdf";
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No se pudo escribir en el archivo: " + ex.Message);
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Agregar encabezados
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new BaseColor(240, 240, 240);
                                pdfTable.AddCell(cell);
                            }

                            // Agregar filas
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value?.ToString() ?? "");
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("Gastos Realizados"));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("PDF exportado correctamente", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al exportar PDF: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Info");
            }
        }
        public void ExportarGastosAExcel()
        {
            try
            {
                // Crear la aplicación de Excel
                Excel.Application excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Excel no está instalado.");
                    return;
                }

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = "Gastos";

                // Escribir encabezados
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                // Escribir datos
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Ajustar columnas
                worksheet.Columns.AutoFit();

                // Mostrar Excel
                excelApp.Visible = true;

                // Liberar objetos (opcional, pero recomendable)
                // Marshal.ReleaseComObject(worksheet);
                // Marshal.ReleaseComObject(workbook);
                // Marshal.ReleaseComObject(excelApp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }
        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.label1 = new System.Windows.Forms.Label();
            this.AtrasFecha = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(320, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gastos Realizados";
            // 
            // AtrasFecha
            // 
            this.AtrasFecha.BackColor = System.Drawing.Color.Transparent;
            this.AtrasFecha.Image = ((System.Drawing.Image)(resources.GetObject("AtrasFecha.Image")));
            this.AtrasFecha.Location = new System.Drawing.Point(25, 20);
            this.AtrasFecha.Name = "AtrasFecha";
            this.AtrasFecha.Size = new System.Drawing.Size(57, 49);
            this.AtrasFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AtrasFecha.TabIndex = 10;
            this.AtrasFecha.TabStop = false;
            this.AtrasFecha.Click += new System.EventHandler(this.AtrasFecha_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(50, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 350);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Moneda";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AtrasFecha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Gastos Realizados";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
