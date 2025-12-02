namespace intento_de_solucion
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.AtrasFecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // AtrasFecha
            // 
            this.AtrasFecha.Image = ((System.Drawing.Image)(resources.GetObject("AtrasFecha.Image")));
            this.AtrasFecha.Location = new System.Drawing.Point(33, 37);
            this.AtrasFecha.Name = "AtrasFecha";
            this.AtrasFecha.Size = new System.Drawing.Size(40, 35);
            this.AtrasFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AtrasFecha.TabIndex = 12;
            this.AtrasFecha.TabStop = false;
            this.AtrasFecha.Click += new System.EventHandler(this.AtrasFecha_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AtrasFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "Consultar Proyecciones";
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AtrasFecha;
    }
}