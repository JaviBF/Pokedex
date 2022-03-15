
namespace Pokedex
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.izquierda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Button();
            this.Movimientos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.Color.Transparent;
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.Location = new System.Drawing.Point(-1, 289);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(101, 67);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.Transparent;
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.Location = new System.Drawing.Point(106, 289);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(101, 67);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemon.Font = new System.Drawing.Font("High Tower Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(2, 231);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(228, 52);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Click += new System.EventHandler(this.label1_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.Descripcion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(236, 289);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(119, 67);
            this.Descripcion.TabIndex = 4;
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.UseVisualStyleBackColor = false;
            this.Descripcion.Click += new System.EventHandler(this.Descripción_Click);
            // 
            // Movimientos
            // 
            this.Movimientos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movimientos.Location = new System.Drawing.Point(236, 215);
            this.Movimientos.Name = "Movimientos";
            this.Movimientos.Size = new System.Drawing.Size(119, 68);
            this.Movimientos.TabIndex = 5;
            this.Movimientos.Text = "Movimientos";
            this.Movimientos.UseVisualStyleBackColor = true;
            this.Movimientos.Click += new System.EventHandler(this.Movimientos_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 364);
            this.Controls.Add(this.Movimientos);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.izquierda);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button Descripcion;
        private System.Windows.Forms.Button Movimientos;
    }
}

