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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            ModosJuegos mJuegos = new ModosJuegos();
            //Ocultamos la pantalla de registro
            this.Visible = false;
            //Abrimos la pantalla de los modos de juego.
            mJuegos.ShowDialog();
            //Cerramos la pantalla de registro.
            this.Close();
            //Cerramos/Eliminamos todos los recursos que estemos utilizando en la pantalla de registro.
            this.Dispose();

        }
    }
}
