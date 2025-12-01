namespace intento_de_solucion
{
    partial class RegGastNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegGastNew));
            this.RegGastNew1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PregGast1 = new System.Windows.Forms.Label();
            this.PregGast2 = new System.Windows.Forms.Label();
            this.Córdobas = new System.Windows.Forms.Button();
            this.Dólares = new System.Windows.Forms.Button();
            this.PregGast3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RegGasto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegGastNew1
            // 
            this.RegGastNew1.AutoSize = true;
            this.RegGastNew1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegGastNew1.Location = new System.Drawing.Point(248, 52);
            this.RegGastNew1.Name = "RegGastNew1";
            this.RegGastNew1.Size = new System.Drawing.Size(322, 31);
            this.RegGastNew1.TabIndex = 0;
            this.RegGastNew1.Text = "Registrar gasto nuevo";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(452, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 28);
            this.textBox1.TabIndex = 1;
            // 
            // PregGast1
            // 
            this.PregGast1.AutoSize = true;
            this.PregGast1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregGast1.Location = new System.Drawing.Point(179, 125);
            this.PregGast1.Name = "PregGast1";
            this.PregGast1.Size = new System.Drawing.Size(251, 20);
            this.PregGast1.TabIndex = 2;
            this.PregGast1.Text = "¿Cuál es el monto del gasto?";
            // 
            // PregGast2
            // 
            this.PregGast2.AutoSize = true;
            this.PregGast2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregGast2.Location = new System.Drawing.Point(250, 171);
            this.PregGast2.Name = "PregGast2";
            this.PregGast2.Size = new System.Drawing.Size(180, 20);
            this.PregGast2.TabIndex = 3;
            this.PregGast2.Text = "¿Cuál es la moneda?";
            // 
            // Córdobas
            // 
            this.Córdobas.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Córdobas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Córdobas.Location = new System.Drawing.Point(436, 165);
            this.Córdobas.Name = "Córdobas";
            this.Córdobas.Size = new System.Drawing.Size(101, 32);
            this.Córdobas.TabIndex = 4;
            this.Córdobas.Text = "Córdobas";
            this.Córdobas.UseVisualStyleBackColor = true;
            // 
            // Dólares
            // 
            this.Dólares.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dólares.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Dólares.Location = new System.Drawing.Point(543, 166);
            this.Dólares.Name = "Dólares";
            this.Dólares.Size = new System.Drawing.Size(101, 31);
            this.Dólares.TabIndex = 5;
            this.Dólares.Text = "Dólares";
            this.Dólares.UseVisualStyleBackColor = true;
            // 
            // PregGast3
            // 
            this.PregGast3.AutoSize = true;
            this.PregGast3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregGast3.Location = new System.Drawing.Point(218, 219);
            this.PregGast3.Name = "PregGast3";
            this.PregGast3.Size = new System.Drawing.Size(212, 20);
            this.PregGast3.TabIndex = 6;
            this.PregGast3.Text = "¿El gasto califica como?";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Comida",
            "Biberes",
            "Transporte",
            "Gastos comunes (agua, luz, servicios telefonicos...)",
            "Reparaciones",
            "Compras",
            "Salud",
            "Deporte",
            "Hobbies",
            "Otros"});
            this.listBox1.Location = new System.Drawing.Point(224, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 94);
            this.listBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(452, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 28);
            this.textBox2.TabIndex = 8;
            // 
            // RegGasto
            // 
            this.RegGasto.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegGasto.Location = new System.Drawing.Point(318, 376);
            this.RegGasto.Name = "RegGasto";
            this.RegGasto.Size = new System.Drawing.Size(173, 39);
            this.RegGasto.TabIndex = 9;
            this.RegGasto.Text = "Registrar gasto";
            this.RegGasto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RegGastNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegGasto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PregGast3);
            this.Controls.Add(this.Dólares);
            this.Controls.Add(this.Córdobas);
            this.Controls.Add(this.PregGast2);
            this.Controls.Add(this.PregGast1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RegGastNew1);
            this.Name = "RegGastNew";
            this.Text = "Registrar gasto nuevo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegGastNew1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PregGast1;
        private System.Windows.Forms.Label PregGast2;
        private System.Windows.Forms.Button Córdobas;
        private System.Windows.Forms.Button Dólares;
        private System.Windows.Forms.Label PregGast3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button RegGasto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}