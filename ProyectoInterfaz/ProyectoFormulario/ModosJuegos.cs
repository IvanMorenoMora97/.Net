using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormulario
{
    public partial class ModosJuegos : Form
    {
        public ModosJuegos()
        {
            InitializeComponent();
        }

        private void ModosJuegos_Load(object sender, EventArgs e)
        {

        }

        private void empezarTrivial_Click(object sender, EventArgs e)
        {
            PreguntasTrivial juegoPreguntas = new PreguntasTrivial();
            //Ocultamos la pantalla de los modos de juego.
            this.Visible = false;
            //Abrimos la pantalla en la que el usuario tendra que responder a una serie de preguntas.
            juegoPreguntas.ShowDialog();
            //Volvemos a mostrar la pantallad e selección de modo de juego.
            this.Visible = true;
        }
    }
}
