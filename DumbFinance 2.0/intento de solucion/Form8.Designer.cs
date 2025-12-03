namespace intento_de_solucion
{
    partial class AjustPresu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjustPresu));
            this.AjusPresu1 = new System.Windows.Forms.Label();
            this.PresActu = new System.Windows.Forms.Label();
            this.PresNew = new System.Windows.Forms.Label();
            this.ConfPresu = new System.Windows.Forms.Label();
            this.PregPresu = new System.Windows.Forms.Label();
            this.Mensual = new System.Windows.Forms.Button();
            this.Semanal = new System.Windows.Forms.Button();
            this.Anual = new System.Windows.Forms.Button();
            this.DefPresNew = new System.Windows.Forms.Button();
            this.AtrasFlecha = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PregMon = new System.Windows.Forms.Label();
            this.Córdobas = new System.Windows.Forms.Button();
            this.Dólares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFlecha)).BeginInit();
            this.SuspendLayout();
            // 
            // AjusPresu1
            // 
            this.AjusPresu1.AutoSize = true;
            this.AjusPresu1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold);
            this.AjusPresu1.Location = new System.Drawing.Point(236, 32);
            this.AjusPresu1.Name = "AjusPresu1";
            this.AjusPresu1.Size = new System.Drawing.Size(302, 31);
            this.AjusPresu1.Text = "Ajustar presupuesto";
            // 
            // PresActu
            // 
            this.PresActu.AutoSize = true;
            this.PresActu.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.PresActu.Location = new System.Drawing.Point(205, 103);
            this.PresActu.Name = "PresActu";
            this.PresActu.Size = new System.Drawing.Size(173, 20);
            this.PresActu.Text = "Presupuesto actual:";
            // 
            // PresNew
            // 
            this.PresNew.AutoSize = true;
            this.PresNew.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.PresNew.Location = new System.Drawing.Point(204, 162);
            this.PresNew.Name = "PresNew";
            this.PresNew.Size = new System.Drawing.Size(174, 20);
            this.PresNew.Text = "Presupuesto nuevo:";
            // 
            // ConfPresu
            // 
            this.ConfPresu.AutoSize = true;
            this.ConfPresu.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.ConfPresu.Location = new System.Drawing.Point(164, 223);
            this.ConfPresu.Name = "ConfPresu";
            this.ConfPresu.Size = new System.Drawing.Size(214, 20);
            this.ConfPresu.Text = "Confirmar presupuesto:";
            // 
            // PregPresu
            // 
            this.PregPresu.AutoSize = true;
            this.PregPresu.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.PregPresu.Location = new System.Drawing.Point(312, 267);
            this.PregPresu.Name = "PregPresu";
            this.PregPresu.Size = new System.Drawing.Size(192, 20);
            this.PregPresu.Text = "¿El presupuesto será?";
            // 
            // Mensual
            // 
            this.Mensual.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.Mensual.Location = new System.Drawing.Point(345, 304);
            this.Mensual.Name = "Mensual";
            this.Mensual.Size = new System.Drawing.Size(97, 33);
            this.Mensual.Text = "Mensual";
            this.Mensual.UseVisualStyleBackColor = true;
            this.Mensual.Click += new System.EventHandler(this.Mensual_Click);
            // 
            // Semanal
            // 
            this.Semanal.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.Semanal.Location = new System.Drawing.Point(242, 304);
            this.Semanal.Name = "Semanal";
            this.Semanal.Size = new System.Drawing.Size(97, 33);
            this.Semanal.Text = "Semanal";
            this.Semanal.UseVisualStyleBackColor = true;
            this.Semanal.Click += new System.EventHandler(this.Semanal_Click);
            // 
            // Anual
            // 
            this.Anual.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.Anual.Location = new System.Drawing.Point(448, 304);
            this.Anual.Name = "Anual";
            this.Anual.Size = new System.Drawing.Size(97, 33);
            this.Anual.Text = "Anual";
            this.Anual.UseVisualStyleBackColor = true;
            this.Anual.Click += new System.EventHandler(this.Anual_Click);
            // 
            // DefPresNew
            // 
            this.DefPresNew.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.DefPresNew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DefPresNew.Location = new System.Drawing.Point(656, 400);
            this.DefPresNew.Name = "DefPresNew";
            this.DefPresNew.Size = new System.Drawing.Size(132, 49);
            this.DefPresNew.Text = "Definir presupuesto";
            this.DefPresNew.UseVisualStyleBackColor = true;
            this.DefPresNew.Click += new System.EventHandler(this.DefPresNew_Click);
            // 
            // AtrasFlecha
            // 
            this.AtrasFlecha.Image = ((System.Drawing.Image)(resources.GetObject("AtrasFlecha.Image")));
            this.AtrasFlecha.Location = new System.Drawing.Point(24, 21);
            this.AtrasFlecha.Name = "AtrasFlecha";
            this.AtrasFlecha.Size = new System.Drawing.Size(39, 35);
            this.AtrasFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AtrasFlecha.TabStop = false;
            this.AtrasFlecha.Click += new System.EventHandler(this.AtrasFlecha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(405, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 28);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.textBox2.Location = new System.Drawing.Point(405, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 28);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.textBox3.Location = new System.Drawing.Point(405, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 28);
            // 
            // PregMon
            // 
            this.PregMon.AutoSize = true;
            this.PregMon.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.PregMon.Location = new System.Drawing.Point(329, 353);
            this.PregMon.Name = "PregMon";
            this.PregMon.Size = new System.Drawing.Size(140, 20);
            this.PregMon.Text = "¿La moneda es?";
            // 
            // Córdobas
            // 
            this.Córdobas.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.Córdobas.Location = new System.Drawing.Point(290, 387);
            this.Córdobas.Name = "Córdobas";
            this.Córdobas.Size = new System.Drawing.Size(104, 34);
            this.Córdobas.Text = "Córdobas";
            this.Córdobas.UseVisualStyleBackColor = true;
            this.Córdobas.Click += new System.EventHandler(this.Córdobas_Click);
            // 
            // Dólares
            // 
            this.Dólares.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.Dólares.Location = new System.Drawing.Point(400, 387);
            this.Dólares.Name = "Dólares";
            this.Dólares.Size = new System.Drawing.Size(104, 34);
            this.Dólares.Text = "Dólares";
            this.Dólares.UseVisualStyleBackColor = true;
            this.Dólares.Click += new System.EventHandler(this.Dólares_Click);
            // 
            // AjustPresu
            // 
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.Dólares);
            this.Controls.Add(this.Córdobas);
            this.Controls.Add(this.PregMon);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AtrasFlecha);
            this.Controls.Add(this.DefPresNew);
            this.Controls.Add(this.Anual);
            this.Controls.Add(this.Semanal);
            this.Controls.Add(this.Mensual);
            this.Controls.Add(this.PregPresu);
            this.Controls.Add(this.ConfPresu);
            this.Controls.Add(this.PresNew);
            this.Controls.Add(this.PresActu);
            this.Controls.Add(this.AjusPresu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjustPresu";
            this.Text = "Ajustar presupuesto";
            this.Load += new System.EventHandler(this.AjustPresu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFlecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AjusPresu1;
        private System.Windows.Forms.Label PresActu;
        private System.Windows.Forms.Label PresNew;
        private System.Windows.Forms.Label ConfPresu;
        private System.Windows.Forms.Label PregPresu;
        private System.Windows.Forms.Button Mensual;
        private System.Windows.Forms.Button Semanal;
        private System.Windows.Forms.Button Anual;
        private System.Windows.Forms.Button DefPresNew;
        private System.Windows.Forms.PictureBox AtrasFlecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label PregMon;
        private System.Windows.Forms.Button Córdobas;
        private System.Windows.Forms.Button Dólares;
    }
}
