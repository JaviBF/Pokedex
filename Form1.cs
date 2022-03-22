using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Abrir.FlatAppearance.BorderSize = 0;
            Abrir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Abrir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Abrir.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana2 = new VentanaPrincipal();
            ventana2.Show();
        }
    }
}
