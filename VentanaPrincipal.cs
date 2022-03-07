using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{  
    public partial class VentanaPrincipal : Form
    {
        Conexión miConexión = new Conexión();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //guarda el id del pokemon que se esá viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            misPokemons = miConexión.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
        return(Image.FromStream(ms));
        }
        private void derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            misPokemons = miConexión.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
