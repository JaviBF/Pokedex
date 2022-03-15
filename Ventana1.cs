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
    public partial class Ventana1 : Form
    {
        Conexión miConexión = new Conexión();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //guarda el id del pokemon que se esá viendo
        public void cambiaDescripcionPokemon(String descripcion)
        {
            cajaDescripcion1.Text = descripcion;
        }
        public Ventana1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            misPokemons = miConexión.getPokemonPorId(idActual);
            cajaDescripcion1.Text = misPokemons.Rows[0]["Descripcion"].ToString();
        }
    }
}
