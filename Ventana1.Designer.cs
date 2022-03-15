
namespace Pokedex
{
    partial class Ventana1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana1));
            this.cajaDescripcion1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajaDescripcion1
            // 
            this.cajaDescripcion1.BackColor = System.Drawing.Color.Transparent;
            this.cajaDescripcion1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDescripcion1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cajaDescripcion1.Location = new System.Drawing.Point(130, 93);
            this.cajaDescripcion1.Name = "cajaDescripcion1";
            this.cajaDescripcion1.Size = new System.Drawing.Size(398, 272);
            this.cajaDescripcion1.TabIndex = 1;
            this.cajaDescripcion1.Text = "label2";
            this.cajaDescripcion1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 419);
            this.Controls.Add(this.cajaDescripcion1);
            this.Name = "Ventana1";
            this.Text = "Ventana1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cajaDescripcion1;
    }
}