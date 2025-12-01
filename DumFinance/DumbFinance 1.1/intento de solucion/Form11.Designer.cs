namespace intento_de_solucion
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.label1 = new System.Windows.Forms.Label();
            this.AtrasFecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gastos Realizados";
            // 
            // AtrasFecha
            // 
            this.AtrasFecha.Image = ((System.Drawing.Image)(resources.GetObject("AtrasFecha.Image")));
            this.AtrasFecha.Location = new System.Drawing.Point(22, 47);
            this.AtrasFecha.Name = "AtrasFecha";
            this.AtrasFecha.Size = new System.Drawing.Size(40, 35);
            this.AtrasFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AtrasFecha.TabIndex = 10;
            this.AtrasFecha.TabStop = false;
            this.AtrasFecha.Click += new System.EventHandler(this.AtrasFecha_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 499);
            this.Controls.Add(this.AtrasFecha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Gastos Realizados";
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AtrasFecha;
    }
}