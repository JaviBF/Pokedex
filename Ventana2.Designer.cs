
namespace Pokedex
{
    partial class Ventana2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana2));
            this.cajaMovimiento1 = new System.Windows.Forms.Label();
            this.cajaMovimiento2 = new System.Windows.Forms.Label();
            this.cajaMovimiento3 = new System.Windows.Forms.Label();
            this.cajaMovimiento4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajaMovimiento1
            // 
            this.cajaMovimiento1.BackColor = System.Drawing.Color.Transparent;
            this.cajaMovimiento1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaMovimiento1.ForeColor = System.Drawing.Color.Maroon;
            this.cajaMovimiento1.Location = new System.Drawing.Point(25, 71);
            this.cajaMovimiento1.Name = "cajaMovimiento1";
            this.cajaMovimiento1.Size = new System.Drawing.Size(218, 45);
            this.cajaMovimiento1.TabIndex = 0;
            this.cajaMovimiento1.Text = "label1";
            this.cajaMovimiento1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cajaMovimiento2
            // 
            this.cajaMovimiento2.BackColor = System.Drawing.Color.Transparent;
            this.cajaMovimiento2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaMovimiento2.ForeColor = System.Drawing.Color.Maroon;
            this.cajaMovimiento2.Location = new System.Drawing.Point(25, 134);
            this.cajaMovimiento2.Name = "cajaMovimiento2";
            this.cajaMovimiento2.Size = new System.Drawing.Size(218, 43);
            this.cajaMovimiento2.TabIndex = 1;
            this.cajaMovimiento2.Text = "label2";
            this.cajaMovimiento2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cajaMovimiento3
            // 
            this.cajaMovimiento3.BackColor = System.Drawing.Color.Transparent;
            this.cajaMovimiento3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaMovimiento3.ForeColor = System.Drawing.Color.Maroon;
            this.cajaMovimiento3.Location = new System.Drawing.Point(25, 199);
            this.cajaMovimiento3.Name = "cajaMovimiento3";
            this.cajaMovimiento3.Size = new System.Drawing.Size(218, 43);
            this.cajaMovimiento3.TabIndex = 2;
            this.cajaMovimiento3.Text = "label3";
            this.cajaMovimiento3.Click += new System.EventHandler(this.cajaMovimiento3_Click);
            // 
            // cajaMovimiento4
            // 
            this.cajaMovimiento4.BackColor = System.Drawing.Color.Transparent;
            this.cajaMovimiento4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaMovimiento4.ForeColor = System.Drawing.Color.Maroon;
            this.cajaMovimiento4.Location = new System.Drawing.Point(25, 256);
            this.cajaMovimiento4.Name = "cajaMovimiento4";
            this.cajaMovimiento4.Size = new System.Drawing.Size(218, 41);
            this.cajaMovimiento4.TabIndex = 3;
            this.cajaMovimiento4.Text = "label4";
            this.cajaMovimiento4.Click += new System.EventHandler(this.cajaMovimiento4_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 352);
            this.Controls.Add(this.cajaMovimiento4);
            this.Controls.Add(this.cajaMovimiento3);
            this.Controls.Add(this.cajaMovimiento2);
            this.Controls.Add(this.cajaMovimiento1);
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            this.Load += new System.EventHandler(this.Ventana2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cajaMovimiento1;
        private System.Windows.Forms.Label cajaMovimiento2;
        private System.Windows.Forms.Label cajaMovimiento3;
        private System.Windows.Forms.Label cajaMovimiento4;
    }
}