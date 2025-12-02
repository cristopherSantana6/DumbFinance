namespace intento_de_solucion
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.AtrasFecha = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 25F);
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenid@";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(239, 47);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(199, 30);
            this.username.TabIndex = 1;
            this.username.Text = "a DumbFinance.";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // AtrasFecha
            // 
            this.AtrasFecha.Image = ((System.Drawing.Image)(resources.GetObject("AtrasFecha.Image")));
            this.AtrasFecha.Location = new System.Drawing.Point(24, 47);
            this.AtrasFecha.Name = "AtrasFecha";
            this.AtrasFecha.Size = new System.Drawing.Size(40, 35);
            this.AtrasFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AtrasFecha.TabIndex = 11;
            this.AtrasFecha.TabStop = false;
            this.AtrasFecha.Click += new System.EventHandler(this.AtrasFecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::intento_de_solucion.Properties.Resources.mdo;
            this.pictureBox1.Location = new System.Drawing.Point(125, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 79);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AtrasFecha);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUser";
            this.Text = "Interfaz de Usuario";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AtrasFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox AtrasFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}