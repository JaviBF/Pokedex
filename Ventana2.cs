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
    public partial class Ventana2 : Form
    {
        Conexión miConexión = new Conexión();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //guarda el id del pokemon que se esá viendo
        public void cambiaMovimientoPokemon1(String descripcion)
        {
            cajaMovimiento1.Text = descripcion;
        }
        public void cambiaMovimientoPokemon2(String descripcion)
        {
            cajaMovimiento2.Text = descripcion;
        }
        public void cambiaMovimientoPokemon3(String descripcion)
        {
            cajaMovimiento3.Text = descripcion;
        }
        public void cambiaMovimientoPokemon4(String descripcion)
        {
            cajaMovimiento4.Text = descripcion;
        }
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            misPokemons = miConexión.getPokemonPorId(idActual);
            cajaMovimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            misPokemons = miConexión.getPokemonPorId(idActual);
            cajaMovimiento1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
        }

        private void cajaMovimiento3_Click(object sender, EventArgs e)
        {
            misPokemons = miConexión.getPokemonPorId(idActual);
            cajaMovimiento3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
        }

        private void cajaMovimiento4_Click(object sender, EventArgs e)
        {
            misPokemons = miConexión.getPokemonPorId(idActual);
            cajaMovimiento4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
        }
    }
}
