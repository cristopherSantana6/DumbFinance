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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form11));

            this.label1 = new System.Windows.Forms.Label();
            this.AtrasFecha = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(320, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gastos Realizados";

            // AtrasFecha
            this.AtrasFecha.BackColor = System.Drawing.Color.Transparent;
            this.AtrasFecha.Image = ((System.Drawing.Image)(resources.GetObject("AtrasFecha.Image")));
            this.AtrasFecha.Location = new System.Drawing.Point(25, 20);
            this.AtrasFecha.Name = "AtrasFecha";
            this.AtrasFecha.Size = new System.Drawing.Size(57, 49);
            this.AtrasFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AtrasFecha.TabIndex = 10;
            this.AtrasFecha.TabStop = false;
            this.AtrasFecha.Click += new System.EventHandler(this.AtrasFecha_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 350);
            this.dataGridView1.TabIndex = 11;

            // Add columns
            this.dataGridView1.Columns.Add("Monto", "Monto");
            this.dataGridView1.Columns.Add("Fecha", "Fecha");
            this.dataGridView1.Columns.Add("Moneda", "Moneda");
            this.dataGridView1.Columns.Add("Categoria", "Categoría");

            // Form11
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AtrasFecha);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Gastos Realizados";
            this.Load += new System.EventHandler(this.Form11_Load);

            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
