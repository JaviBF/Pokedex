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
            misPokemons = miConexión.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);

            izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            izquierda.FlatAppearance.BorderSize = 0;
            izquierda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            izquierda.FlatAppearance.MouseOverBackColor = Color.Transparent;
            izquierda.BackColor = Color.Transparent;

            derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            derecha.FlatAppearance.BorderSize = 0;
            derecha.FlatAppearance.MouseDownBackColor = Color.Transparent;
            derecha.FlatAppearance.MouseOverBackColor = Color.Transparent;
            derecha.BackColor = Color.Transparent;

            Descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Descripcion.FlatAppearance.BorderSize = 0;
            Descripcion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Descripcion.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Descripcion.BackColor = Color.Transparent;

            Movimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Movimientos.FlatAppearance.BorderSize = 0;
            Movimientos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Movimientos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Movimientos.BackColor = Color.Transparent;
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
        

            idActual--;
            if (idActual <=0)
            {
                idActual = 151;
            }
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
            if(idActual >= 151)
            {
                idActual = 1;
            }
            misPokemons = miConexión.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void Descripción_Click(object sender, EventArgs e)
        {

            Ventana1 v = new Ventana1();

            v.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString());
            v.Show();
        }

        private void Movimientos_Click(object sender, EventArgs e)
        {
            Ventana2 v1 = new Ventana2();
            v1.cambiaMovimientoPokemon1(misPokemons.Rows[0]["movimiento1"].ToString());
            v1.cambiaMovimientoPokemon2(misPokemons.Rows[0]["movimiento2"].ToString());
            v1.cambiaMovimientoPokemon3(misPokemons.Rows[0]["movimiento3"].ToString());
            v1.cambiaMovimientoPokemon4(misPokemons.Rows[0]["movimiento4"].ToString());
            v1.Show();
        }
    }
}
